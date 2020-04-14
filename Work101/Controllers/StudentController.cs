using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Work101.Models;
using Work101.Service;

namespace Work101.Controllers
{
    public class StudentController : Controller
    {
        //'Dependency Injection'-- Service'den gelen veriler burada işlenir sonra controllerda işlem görür.
        private readonly StudentService _studentService;

        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            //serviceden gelen öğrenci listesi bir değişkene atanır.
            var studentEntities = _studentService.GetStudents();
            List<StudentVM> studentList = new List<StudentVM>();
            foreach (var item in studentEntities)
            {
                studentList.Add(new StudentVM
                {
                    Id = item.Id,
                    FirtsName = item.FirtsName,
                    LastName = item.LastName,
                    StudentNo = item.StudentNo,
                    ClassNo = item.ClassNo,
                    Birthday = item.Birthday
                });
            }
            return View(studentList);
        }
    }
}