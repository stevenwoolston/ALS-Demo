using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class SearchController : Controller
    {
        //
        // GET: /Search/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SearchResults(string id)
        {
            switch (id)
            {
                case "unit":
                    ViewBag.Message = "unit";
                    break;
                case "cmpt":
                    ViewBag.Message = "cmpt";
                    break;
                case "coy":
                    ViewBag.Message = "coy";
                    break;
                default:
                    ViewBag.Message = "smpl";
                    break;
            }

            return View();
        }
        public ActionResult SearchSummary()
        {
            return View();
        }

        public ActionResult SampleSubmissionSearch()
        {
            return View();
        }

        public ActionResult GraphicalAnalysis()
        {
            return View();
        }


        private List<Sample> _samples = new List<Sample>
        {
            new Sample {
                SampleID="123",
                DateSampled="01/01/2012",
                SIFNo="2134",
                Severity="Normal",
                DateDiagnosed="01/01/2012",
                ProblemCode="Water",
                UnitType="Moteur Diesel",
                UnitLocation="",
                UnitID="Noute",
                UnitDescription="Moteur Diesel",
                UIN="00019DF",
                LabNumber="100022714364"
            }
        };
    }
}
