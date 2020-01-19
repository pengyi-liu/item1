using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace happy_aoligei.Controllers
{
    public class ReturnController : Controller
    {
        // GET: Return
        public ActionResult Apply()
        {
            return View();
        }
        public ActionResult History()
        {
            return View();
        }
    }
}