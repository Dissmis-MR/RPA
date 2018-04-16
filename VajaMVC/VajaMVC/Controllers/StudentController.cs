using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VajaMVC.Models;

namespace VajaMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
          var studentList = new List<student>{
            new student() { StudentID = 1, StudentName = "Marko", Age = 20 } ,
            new student() { StudentID = 3, StudentName = "Janez", Age = 30 } ,
            new student() { StudentID = 4, StudentName = "Ram" , Age = 16 } ,
            new student() { StudentID = 5, StudentName = "Rom" , Age = 20 } ,
            new student() { StudentID = 4, StudentName = "Miha" , Age = 20 } ,
            };

          return View(studentList);
        }
    }
}