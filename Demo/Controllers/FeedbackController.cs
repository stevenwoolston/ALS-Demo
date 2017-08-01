using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class FeedbackController : Controller
    {
        //
        // GET: /Feedback/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ActionAlerts()
        {
            return View();
        }
        public ActionResult Search()
        {
            return View();
        }
    }
}
