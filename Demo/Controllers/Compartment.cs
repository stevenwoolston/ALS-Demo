using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Controllers
{
    public class Compartment
    {
        public string LastSampled { get; set; }
        public string Severity { get; set; }
        public string SIFNo { get; set; }
        public string UnitID { get; set; }
        public string UnitDescription { get; set; }
        public string UINNo { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string CompanyName { get; set; }
        public string CustomerNumber { get; set; }
        public string Grade { get; set; }
    }
}