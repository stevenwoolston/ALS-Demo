using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class KnowledgebaseController : Controller
    {
        //
        // GET: /Knowledgebase/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Results()
        {
            return View();
        }
        public ActionResult Article()
        {
            return View();
        }
    }
}
