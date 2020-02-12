using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using happy_aoligei.Models;
using System.Data;
using MySql.Data.MySqlClient;

namespace Test.Controllers
{
    public class HomeController : Controller
    {   
        //主页控制器
        public ActionResult Index()
        {
            if (Session.Count != 0)
                return View();
            else
            {
                ViewBag.JumpUrl = "/Home/Index";
                Response.Redirect("/Login");
                return Content("");
            }
        }
        public ActionResult UserInf()
        {
            if (Session.Count != 0)
                return View();
            else
            {
                ViewBag.JumpUrl = "/Home/UserInf";
                return View("Login");
            }
        }  
    }
}