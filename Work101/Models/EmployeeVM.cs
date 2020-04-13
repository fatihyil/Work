using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Work101.Models
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public string EmployeeNumber { get; set; }
        public string Address { get; set; }
        public string Birthday { get; set; }
        public string PhoneNumber { get; set; }

    }
}
