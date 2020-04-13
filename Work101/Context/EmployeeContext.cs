using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Work101.Entities;

namespace Work101.Context
{
    public class EmployeeContext
    {
        public List<EmployeeEntity> Employees { get; set; }

        public EmployeeContext()
        {
            Employees = new List<EmployeeEntity>
            {
                new EmployeeEntity
                {
                    Id =1,
                    FirstName = "Fatih",
                    LastName = "YILMAZ",
                    EmployeeNumber = "909321",
                    PhoneNumber = "5467654343",
                    IdentityNumber = "32415434587",
                    Address = "Üsküdar",
                    Birthday = "29021992"
                },
                new EmployeeEntity
                {
                    Id =2,
                    FirstName = "Eren",
                    LastName = "BÜKÜ",
                    EmployeeNumber = "556495",
                    PhoneNumber = "5427214140",
                    IdentityNumber = "56984878965",
                    Address = "Üsküdar",
                    Birthday = "10121993"
                },
                new EmployeeEntity
                {
                    Id =3,
                    FirstName = "Yavuz",
                    LastName = "KURU",
                    EmployeeNumber = "456525",
                    PhoneNumber = "5326578996",
                    IdentityNumber = "56699845423",
                    Address = "Ünye",
                    Birthday = "23021996"
                }
            };
        }


    }
}
