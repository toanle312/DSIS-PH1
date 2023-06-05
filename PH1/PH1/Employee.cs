using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH1
{
    internal class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Salary { get; set; }
        public string Allowance { get; set; }

        public string Role { get; set; }
        public string ManagerId { get; set; }
        public string Department { get; set; }
    }
}