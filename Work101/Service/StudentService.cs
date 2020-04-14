using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Work101.Context;
using Work101.Entities;

namespace Work101.Service
{
    public class StudentService
    {
        //Solid d'si Dependency Injection 
        private readonly EmployeeContext _employeeContext;

        public StudentService(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        //Service'den Öğrenci listesini Controller 'a return edilecek.
        public List<StudentEntity> GetStudents()
        {
            return _employeeContext.Students;
        }
    }
}
