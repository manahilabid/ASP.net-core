using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using class_06.Models;

namespace class_06.Controllers
{
    public class studentController : Controller
    {
        // GET: student
        public ActionResult Index()
        {
            var students = new Student
            {
                Id = 1,
                Name = "zara",
                Email = "zara123@gamil.com",
                phone = 0324324
            };
            return View(students);
        }
    }
}