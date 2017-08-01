using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Newtonsoft.Json;

namespace Demo.Models
{
    /// <summary>
    /// Summary description for Webtrieve8
    /// </summary>
    public class Webtrieve8 : IHttpHandler
    {
        string connWCUsers = System.Configuration.ConfigurationManager.ConnectionStrings["WCUsers"].ToString();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            string SmplKey = context.Request.QueryString["smplkey"];

            if (String.IsNullOrEmpty(SmplKey))
            {
                context.Response.Write(GetSearch());
            }
            else
            {
                context.Response.Write(GetItem(SmplKey));
            }
        }

        public string GetSearch()
        {
            using (SqlConnection conn = new SqlConnection(connWCUsers))
            {
                conn.Open();
                int totalrecords = 0;
                StringBuilder sb = new StringBuilder();
                StringWriter sw = new StringWriter(sb);

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "webtrieve8.ListCmplsByCoyID";
                    SqlDataReader rdr = cmd.ExecuteReader();
                    using (JsonWriter jsonWriter = new JsonTextWriter(sw))
                    {
                        jsonWriter.WriteStartArray();
                        while (rdr.Read())
                        {
                            jsonWriter.WriteStartObject();
                            int fields = rdr.FieldCount;
                            for (int i = 0; i < fields; i++)
                            {
                                jsonWriter.WritePropertyName(rdr.GetName(i));
                                jsonWriter.WriteValue(rdr[i]);
                            }
                            jsonWriter.WriteEndObject();
                            totalrecords++;
                        }
                        jsonWriter.WriteEndArray();
                    }
                }
                conn.Close();
                return BuildJSonStream(totalrecords, sb);
            }
        }

        public string GetItem(string SmplKey)
        {
            using (SqlConnection conn = new SqlConnection(connWCUsers))
            {
                conn.Open();
                int totalrecords = 0;
                StringBuilder sb = new StringBuilder();
                StringWriter sw = new StringWriter(sb);

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "webtrieve8.ListCmplsByCoyID";
                    cmd.Parameters.AddWithValue("@SmplKey", SmplKey);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    using (JsonWriter jsonWriter = new JsonTextWriter(sw))
                    {
                        jsonWriter.WriteStartArray();
                        while (rdr.Read())
                        {
                            jsonWriter.WriteStartObject();
                            int fields = rdr.FieldCount;
                            for (int i = 0; i < fields; i++)
                            {
                                jsonWriter.WritePropertyName(rdr.GetName(i));
                                jsonWriter.WriteValue(rdr[i]);
                            }
                            jsonWriter.WriteEndObject();
                            totalrecords++;
                        }
                        jsonWriter.WriteEndArray();
                    }
                }
                conn.Close();
                return BuildJSonStream(totalrecords, sb);
            }
        }

        public string BuildJSonStream(Int32 TotalRecords, StringBuilder JSonString)
        {
            //  formatting the JSON stream to work with the DataTable library
            return ("{\"sEcho\":1,\"iTotalRecords\":" + TotalRecords + ",\"iTotalDisplayRecords\":" + TotalRecords + ", \"aaData\":" + JSonString + "}");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

    }
}