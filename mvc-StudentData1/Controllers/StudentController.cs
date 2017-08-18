using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_StudentData1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            // string[] strStudent = new string[4];
            // strStudent[0] = "a";
            // strStudent[1] = "b";
            // strStudent[2] = "b";
            // strStudent[3] = "d";
            //  return (strStudent);

            ViewBag.Name = "aaaa";
            return View();


            
            
        }
        
    }
}