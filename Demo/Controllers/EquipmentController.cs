using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class EquipmentController : Controller
    {
        //
        // GET: /Equipment/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Unit()
        {
            return View();
        }

        public ActionResult EditUnit()
        {
            return View();
        }
        public ActionResult NewUnit()
        {
            return View();
        }
        public ActionResult Compartment()
        {
            return View();
        }
        public ActionResult EditCompartment()
        {
            return View();
        }

        public ActionResult Company()
        {
            return View();
        }
        public ActionResult EditCompany()
        {
            return View();
        }
    }
}
