using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class SampleController : Controller
    {
        //
        // GET: /Sample/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SampleFullSubmission()
        {
            return View();
        }
        public ActionResult SampleSubmissionList()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
        public ActionResult BulkTopUpList()
        {
            return View();
        }
        public ActionResult BulkTopUpHistory()
        {
            return View();
        }
        public ActionResult BulkTopUp()
        {
            return View();
        }
        public ActionResult SampleSummaryReport()
        {
            return View();
        }
    }
}
