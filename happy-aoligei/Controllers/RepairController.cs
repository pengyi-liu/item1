using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using MySql.Data.MySqlClient;

namespace happy_aoligei.Controllers
{
    public class RepairController : Controller
    {
        private string strConn = "server=10.3.1.12; port=3306; database=hp-aoligei; user=liupengyi; password=mysql123456.;";
        // GET: Repair
        public ActionResult Apply()
        {
            return View();
        }
        public ActionResult Demo()
        {
            /*MySqlConnection Conn = new MySqlConnection(strConn);
            string strTable = "users";
            string strSQL = "select * from "+strTable;
            MySqlCommand cmd = new MySqlCommand(strSQL, Conn);
            Conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable("Users");
            da.Fill(dt);
            Conn.Close();
            ViewBag.row = dt.Rows.Count;
            ViewBag.col = dt.Columns.Count;
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                for (int j = 0; j < dt.Columns.Count; ++j)
                {
                    string tmp = i.ToString() + "," + j.ToString();
                    ViewData[tmp] = dt.Rows[i][j].ToString();
                    ViewData[j.ToString()] = dt.Columns[j].ToString();
                }
            }*/
            ViewBag.row = 4;
            ViewBag.col = 5;
            for (int i = 0; i < ViewBag.row; ++i)
            {
                for (int j = 0; j < ViewBag.col; ++j)
                {
                    string tmp = i.ToString() + "," + j.ToString();
                    ViewData[tmp] = tmp;
                    ViewData[j.ToString()] = j.ToString();
                }
            }
            return View();
        }
        public string Req(string code, string row="1", string col="1")
        {
            /*MySqlConnection Conn = new MySqlConnection(strConn);
            string strTable = "users";
            string strSQL = "select * from users";
            MySqlCommand cmd = new MySqlCommand(strSQL, Conn);
            Conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable("Users");
            da.Fill(dt);
            Conn.Close();
            int a = int.Parse(row), b = int.Parse(col);
            if (code == "2") return dt.Rows[a][b].ToString();
            else if (code == "0") return dt.Rows.Count.ToString();
            else if (code == "1") return dt.Columns.Count.ToString();
            else return "";*/
            return "";
        }
    }
}