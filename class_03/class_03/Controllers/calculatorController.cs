using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace class_03.Controllers
{
    public class calculatorController : Controller
    {
        // GET: calculator
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult index(FormCollection obj)
        {
            try
            {

                int num1 = Convert.ToInt32(obj["num1"]);
                int num2 = Convert.ToInt32(obj["num2"]);

                string opt = obj["Operator"];
                string result = string.Empty;
                switch (opt)
                {
                    case "add":
                        {
                            result = $"Addition: {num1 + num2}";
                            break;
                        }
                    case "sub":
                        {
                            result = $"Subltion: {num1 - num2}";
                            break;
                        }
                    case "multi":
                        {
                            result = $"Multiple: {num1 * num2}";
                            break;
                        }
                    case "div":
                        {
                            result = $"Division:{num1 / num2}";
                            break;
                        }
                        ViewBag.result = result;

                }
            }
            catch (Exception ex)
            {
                ViewBag.result = $"Error:{ex.Message}";

            }
            return View();
        }
    }

}