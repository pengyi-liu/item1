﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace happy_aoligei.Controllers
{
    public class MessageController : Controller
    {
        //信息模块控制器
        public ActionResult Index()
        {
            return View();
        }
    }
}