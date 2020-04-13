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
    public class EmployeeController : Controller
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        public IActionResult Index()
        {
            var employeeEntities = _employeeService.GetEmployees();
            List<EmployeeVM> employeeList = new List<EmployeeVM>();
            foreach (var entity in employeeEntities)
            {
                employeeList.Add(new EmployeeVM
                {
                    Id = entity.Id,
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    IdentityNumber = entity.IdentityNumber,
                    PhoneNumber = entity.PhoneNumber,
                    EmployeeNumber = entity.EmployeeNumber,
                    Birthday = entity.Birthday,
                    Address = entity.Address

                });
            }
            return View(employeeList);
        }
        public IActionResult Edit(int id)
        {
            var employeeEntities = _employeeService.Get(id);
            var model = new EmployeeVM()
            {
                Id = employeeEntities.Id,
                FirstName = employeeEntities.FirstName,
                LastName = employeeEntities.LastName,
                IdentityNumber = employeeEntities.IdentityNumber,
                PhoneNumber = employeeEntities.PhoneNumber,
                EmployeeNumber = employeeEntities.EmployeeNumber,
                Birthday = employeeEntities.Birthday,
                Address = employeeEntities.Address
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(EmployeeVM model)
        {
            var employeeEntity = new EmployeeEntity
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                IdentityNumber = model.IdentityNumber,
                Address = model.Address,
                Birthday = model.Birthday,
                EmployeeNumber = model.EmployeeNumber,
                PhoneNumber = model.PhoneNumber
            };
            _employeeService.Edit(employeeEntity);
            //var updateEntity = _employeeService.Get(model.Id);
            //return View(
            //    new EmployeeVM
            //    {
            //        Id = updateEntity.Id,
            //        FirstName = updateEntity.FirstName,
            //        LastName = updateEntity.LastName,
            //        Address = updateEntity.Address,
            //        IdentityNumber = updateEntity.IdentityNumber,
            //        EmployeeNumber = updateEntity.EmployeeNumber,
            //        Birthday = updateEntity.Birthday,
            //        PhoneNumber = updateEntity.PhoneNumber

            //    });
            return RedirectToAction("Index","Employee");
        }
        public IActionResult Delete(int id)
        {
            _employeeService.Delete(id);
            return RedirectToAction("Index","Employee");
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(EmployeeVM employee)        
        {
            var lastentityID = _employeeService.GetEmployees().Count;

            var employeeEntity = new EmployeeEntity
            {
                Id = lastentityID + 1,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                IdentityNumber =employee.IdentityNumber,
                EmployeeNumber = employee.EmployeeNumber,
                PhoneNumber = employee.PhoneNumber,
                Birthday = employee.Birthday,
                Address = employee.Address
            };
            _employeeService.Add(employeeEntity);
            return RedirectToAction("Index");
        }
    }
}