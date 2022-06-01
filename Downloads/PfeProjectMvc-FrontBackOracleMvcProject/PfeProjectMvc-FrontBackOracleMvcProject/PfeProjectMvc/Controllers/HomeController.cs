using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PfeProjectMvc.Models;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace PfeProjectMvc.Controllers
{
    public class HomeController : Controller
    {
        Sco_Entities db = new Sco_Entities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {

            if (ModelState.IsValid)
            {


                var id_ens = collection["id"].ToString();
                var pwd_ens = collection["pwd"].ToString();
                var id= db.ESP_ENSEIGNANT.Select(x => x.ID_ENS);

                if (id_ens.Equals("test") && pwd_ens.Equals("a"))
                {
                    return View("admin");
                }
                else
                {
                    
                  //  OracleConnection mySqlConnection2 = new OracleConnection("DATA SOURCE=localhost:1521/db10g;PERSIST SECURITY INFO=True;USER ID=SCOESP;PASSWORD=scoesp");

                  //  mySqlConnection2.Open();

                  //  string cmdQuery2 = "select  pwd_ens  from ep_enseignant where ID_ENS='" + id_ens + "'";

                  //  OracleCommand myCommand2 = new OracleCommand(cmdQuery2);
                  //  myCommand2.Connection = mySqlConnection2;
                  //  myCommand2.CommandType = CommandType.Text;
                  //  //byte[] lib2 = (byte[])myCommand2.ExecuteScalar();
                  //  //mySqlConnection2.Close();
                  //  //string result2 = System.Text.Encoding.UTF8.GetString(lib2);
                  ////  var ee2 = BitConverter.ToString(lib2).Replace("-", "");
                  //string ee2= myCommand2.ExecuteScalar().ToString();
                    var ens = db.ESP_ENSEIGNANT.Where(x => x.ID_ENS.Equals(id_ens) && x.PWD_ENS.Equals(pwd_ens)).FirstOrDefault();

                    if (ens != null)
                    {
                        Session["ID_ENS"] = id_ens;
                        //Session["PWD_ENS"] = pwd_ens;
                        Session["type"] = "Direction";
                        Session["NOM_ENS"] = ens.NOM_ENS.ToString();
                      //  Session["departement"] = "";
                       // Session["message"] = null;

                        return View("ens");
                    }
                }

            }

            return View(collection);
        }
    }
}