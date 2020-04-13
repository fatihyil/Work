using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Work101.Context;
using Work101.Entities;

namespace Work101.Service
{
    public class EmployeeService
    {
        private readonly EmployeeContext _employeeContext;

        public EmployeeService( EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public List<EmployeeEntity> GetEmployees()
        {
            return _employeeContext.Employees;
        }
        public EmployeeEntity Get(int id)
        {
            return _employeeContext.Employees.FirstOrDefault(x => x.Id == id);
        }
        public void Edit(EmployeeEntity employeeEntity)
        {
            var entity = _employeeContext.Employees.FirstOrDefault(x => x.Id == employeeEntity.Id);
            _employeeContext.Employees.Remove(entity);
            _employeeContext.Employees.Add(employeeEntity);
        }
        public void Delete(int id)
        {
            var entity = _employeeContext.Employees.FirstOrDefault(x => x.Id == id);
            _employeeContext.Employees.Remove(entity);
        }
        public void Add(EmployeeEntity employeeEntity)
        {
            _employeeContext.Employees.Add(employeeEntity);
        }
    }
}
