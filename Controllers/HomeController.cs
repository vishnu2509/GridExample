using GridExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GridExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var students = getStudents();
            return View(students);
        }

        private List<Student> getStudents()
        {
            var list=new List<Student>();

            var student1=new Student();
            student1.Id = 1;
            student1.Name = "Siva";
            student1.Age = 19;

            var student2 = new Student();
            student2.Id = 2;
            student2.Name = "John";
            student2.Age = 19;

            var student3 = new Student();
            student3.Id = 3;
            student3.Name = "Sathish";
            student3.Age = 19;

            var student4 = new Student();
            student4.Id = 4;
            student4.Name = "Mohit";
            student4.Age = 19;

            var student5 = new Student();
            student5.Id = 5;
            student5.Name = "Sanjay";
            student5.Age = 19;

            var student6 = new Student();
            student6.Id = 6;
            student6.Name = "Subhash";
            student6.Age = 19;

            var student7 = new Student();
            student7.Id = 7;
            student7.Name = "Kumar";
            student7.Age = 19;

            list.Add(student1);
            list.Add(student2);
            list.Add(student3);
            list.Add(student4);
            list.Add(student5);
            list.Add(student6);
            list.Add(student7);

            return list;
        }
    }
}