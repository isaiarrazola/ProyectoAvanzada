using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoAvanzada.Models;
using ProyectoAvanzada.DAL;

namespace ProyectoAvanzada.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            System.Diagnostics.Debug.WriteLine("<3 UWU :3");

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
        [HttpPost]
        public ActionResult Index(string number_0, string name_0, string number_1, string name_1, string number_2, string name_2, string number_3, string name_3, string number_4, string name_4, string number_5, string name_5, string number_6, string name_6, string number_7, string name_7, string number_8, string name_8)
        {
            System.Diagnostics.Debug.WriteLine("ISAI ENTRA EN COMPRAR");
            System.Diagnostics.Debug.WriteLine("number");
            System.Diagnostics.Debug.WriteLine(number_0);
            System.Diagnostics.Debug.WriteLine("name");
            System.Diagnostics.Debug.WriteLine(name_0);
            System.Diagnostics.Debug.WriteLine("number");
            System.Diagnostics.Debug.WriteLine(number_1);
            System.Diagnostics.Debug.WriteLine("name");
            System.Diagnostics.Debug.WriteLine(name_1);
            System.Diagnostics.Debug.WriteLine("number");
            System.Diagnostics.Debug.WriteLine(number_2);
            System.Diagnostics.Debug.WriteLine("name");
            System.Diagnostics.Debug.WriteLine(name_2);
            System.Diagnostics.Debug.WriteLine("number");
            System.Diagnostics.Debug.WriteLine(number_3);
            System.Diagnostics.Debug.WriteLine("name");
            System.Diagnostics.Debug.WriteLine(name_3);
            System.Diagnostics.Debug.WriteLine("number");
            System.Diagnostics.Debug.WriteLine(number_4);
            System.Diagnostics.Debug.WriteLine("name");
            System.Diagnostics.Debug.WriteLine(name_4);
            System.Diagnostics.Debug.WriteLine("number");
            System.Diagnostics.Debug.WriteLine(number_5);
            System.Diagnostics.Debug.WriteLine("name");
            System.Diagnostics.Debug.WriteLine(name_5);
            System.Diagnostics.Debug.WriteLine("number");
            System.Diagnostics.Debug.WriteLine(number_6);
            System.Diagnostics.Debug.WriteLine("name");
            System.Diagnostics.Debug.WriteLine(name_6);
            System.Diagnostics.Debug.WriteLine("number");
            System.Diagnostics.Debug.WriteLine(number_7);
            System.Diagnostics.Debug.WriteLine("name");
            System.Diagnostics.Debug.WriteLine(name_7);
            System.Diagnostics.Debug.WriteLine("number");
            System.Diagnostics.Debug.WriteLine(number_8);
            System.Diagnostics.Debug.WriteLine("name");
            System.Diagnostics.Debug.WriteLine(name_8);

            return View();
        }
    }
}