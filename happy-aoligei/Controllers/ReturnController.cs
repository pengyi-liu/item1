using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace happy_aoligei.Controllers
{
    public class ReturnController : Controller
    {
        //归还控制器
        public ActionResult Apply()
        {
            return View();
        }
        public ActionResult History()
        {
            return View();
        }
        public ActionResult EnterStore()
        {
            return View();
        }
        public ActionResult EnterBuffer()
        {
            return View();
        }
    }
}