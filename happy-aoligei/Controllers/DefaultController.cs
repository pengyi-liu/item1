using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using happy_aoligei.Models;
using System.Data;
using MySql.Data.MySqlClient;

namespace happy_aoligei.Controllers
{
    public class DefaultController : Controller
    {
        private string strConn = "server=10.3.1.12; port=3306; database=hp-aoligei; user=liupengyi; password=mysql123456.;";
        [HttpGet]
        public ActionResult Login()
        {
            if (Session.Count == 0)
            {
                ViewBag.JumpUrl = "/Home/Index";
                return View();
            }
            else
            {
                Response.Redirect("/Home/Index");
                return Content("");
            }
        }
        [HttpPost]
        public ActionResult Login(Models.LoginViewModel user, string JumpUrl)
        {
            Session["username"] = "123";
            MySqlConnection Conn = new MySqlConnection(strConn);
            string strSQL = "select * from users where users.username=@username and users.password=@pwd";
            MySqlCommand cmd = new MySqlCommand(strSQL, Conn);
            if (ModelState.IsValid)
            {
                try
                {
                    cmd.Parameters.AddWithValue("@username", user.username);
                    cmd.Parameters.AddWithValue("@pwd", user.password);
                    Conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        Response.Redirect("/Home/Index");
                        return Content("");
                    }
                    else
                    {
                        Session.Clear();
                        return Content("No");
                    }
                }
                catch (MySqlException E)
                {
                    Session.Clear();
                    return Content("Error");
                }
                finally
                {
                    Conn.Close();
                }
            }
            else
            {
                Session.Clear();
                return Content("Error");
            }
        }
        public void Log_out()
        {
            Session.Clear();
            Response.Redirect("/Login");
        }
    }
}