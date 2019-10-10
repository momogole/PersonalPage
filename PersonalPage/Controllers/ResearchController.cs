using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalPage.Controllers
{
    public class ResearchController : Controller
    {
        public ActionResult Index(string id)
        {
            ViewBag.ResearchName = $"{id}.cshtml";
            return View();
        }
    }
}