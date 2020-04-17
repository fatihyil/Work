using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Work101.Entities;
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
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(StudentVM model)
        {
            var studentEntity = new StudentEntity();
            var studentEntityCount = _studentService.GetStudents().Count;
            studentEntity.Id = studentEntityCount + 1;
            studentEntity.FirtsName = model.FirtsName;
            studentEntity.LastName = model.LastName;
            studentEntity.StudentNo = model.StudentNo;
            studentEntity.ClassNo = model.ClassNo;
            studentEntity.Birthday = model.Birthday;
            _studentService.Add(studentEntity);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var studententity = _studentService.Get(id);
            var model = new StudentVM();
            model.Id = studententity.Id;
            model.FirtsName = studententity.FirtsName;
            model.LastName = studententity.LastName;
            model.StudentNo = studententity.StudentNo;
            model.ClassNo = studententity.ClassNo;
            model.Birthday = studententity.Birthday;
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(StudentVM model)
        {
            var studententity = _studentService.Get(model.Id);
            studententity.FirtsName = model.FirtsName;
            studententity.LastName = model.LastName;
            studententity.Birthday = model.Birthday;
            studententity.ClassNo = model.ClassNo;
            studententity.StudentNo = model.StudentNo;
            _studentService.Edit(studententity);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            _studentService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}