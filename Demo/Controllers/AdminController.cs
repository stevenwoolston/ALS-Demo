using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChangeUserPassword()
        {
            return View();
        }

        public ActionResult UpdateUserProfile()
        {
            return View();
        }
        public ActionResult UserPasswordReset()
        {
            return View();
        }
        public ActionResult UserAddressBook()
        {
            return View();
        }
        public ActionResult UserChangeStartPage()
        {
            return View();
        }
        public ActionResult UserMenuAccess()
        {
            return View();
        }
        public ActionResult SampleConfig()
        {
            return View();
        }
        public ActionResult ThresholdConfig()
        {
            return View();
        }
        public ActionResult UserRegionalSettings()
        {
            return View();
        }
        public ActionResult ChangeEntityColours()
        {
            return View();
        }
        public ActionResult NewsArticleTypes()
        {
            return View();
        }
        public ActionResult NewsArticles()
        {
            return View();
        }
        public ActionResult SiteLabels()
        {
            return View();
        }
        public ActionResult UserManagement()
        {
            return View();
        }
    }
}
