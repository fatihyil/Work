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
        //id ye göre istenilen öğrenici geri döndüren sınıf
        public StudentEntity Get(int id)
        {
            return _employeeContext.Students.FirstOrDefault(x => x.Id == id);//id ye göre istenilen öğreniciyi return ediyoruz.
        }
        //id ye göre değişiklik yapılmak istenilen öğrenci veritanından önce siliniyor sonra yeni bilgileri veritabanına gönderiliyor.
        public void  Edit(StudentEntity studentEntity)
        {
            var entity = _employeeContext.Students.FirstOrDefault(x => x.Id == studentEntity.Id);//Eski veriyi bir değişkene atıyoruz.
            _employeeContext.Students.Remove(entity);//eski veri veritabanından siliniyor.
            _employeeContext.Students.Add(studentEntity);//yeni veri ekleniyor.
        }
        //Silinmek istenilen öğrenci bilgileri id ye göre bu class'a gelir ve veritabanına gönderilir.
        public void Delete(int id)
        {
            var entity = _employeeContext.Students.FirstOrDefault(x=>x.Id == id);
            _employeeContext.Students.Remove(entity);
        }

        //Eklenmek istenilen öğrenci bu class'da veritabanına gönderilir.
        public void Add(StudentEntity studentEntity)
        {
            _employeeContext.Students.Add(studentEntity);
        }
    }
}
