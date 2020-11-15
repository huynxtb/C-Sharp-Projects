using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_04.DTO.lab3
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int YearOfExp { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DateOfJoin { get; set; }
        public override string ToString()
        {
            return Name + ", " + Age + ", " + Address + ", " + YearOfExp + ", " + Phone + "," + Email + ", " + DateOfJoin.ToString(("yyyy-MM-dd"));
        }
    }
}
