using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bai3.Controllers
{
    public class ShiftController : Controller
    {
        // GET: Shift
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Trangchu()
        {
            // return RedirectToAction("Image");
            // return RedirectToAction("About", "Home");
            // return Redirect("https://www.facebook.com/ThanBacKhuynhY");
            return View();
        }

        public ActionResult Image()
        {
            return View();
        }

        public ActionResult Findkeypoint()
        {
            return View();
        }

        public ActionResult Findmatching()
        {
            return View();
        }

        public ActionResult Matching()
        {
            return View();
        }
    }
}