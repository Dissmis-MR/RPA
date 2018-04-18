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
        List<student> studentList = new List<student>{
            new student() { StudentID = 1, StudentName = "Marko", Age = 20 } ,
            new student() { StudentID = 3, StudentName = "Janez", Age = 30 } ,
            new student() { StudentID = 4, StudentName = "Ram" , Age = 16 } ,
            new student() { StudentID = 5, StudentName = "Rom" , Age = 20 } ,
            new student() { StudentID = 4, StudentName = "Miha" , Age = 20 } ,
            };
        // GET: Student
        public ActionResult Index()
        {
          

          return View(studentList);
        }
        public ActionResult Edit (int id)
        {
            var študent = studentList.Where(s => s.StudentID == id).FirstOrDefault();
            return View(študent);
        }
        [HttpPost]
        public ActionResult Edit(student std)
        {
            if(ModelState.IsValid)
            {
                //posodobi podatke
                return RedirectToAction("Index");
            }
            return View(std);
            
        }
    }
}