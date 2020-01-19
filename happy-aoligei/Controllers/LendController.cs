using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace happy_aoligei.Controllers
{
    public class LendController : Controller
    {
        // GET: Lend
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