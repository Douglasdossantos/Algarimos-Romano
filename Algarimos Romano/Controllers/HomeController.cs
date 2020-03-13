using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Algarimos_Romano.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// get
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}