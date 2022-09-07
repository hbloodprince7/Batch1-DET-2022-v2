using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class NewPerson
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

    public class NewStudent:NewPerson
    {
        public int YearStatus { get; set; }
    }

    public class Employee:NewPerson
    {
        public string Office { get; set; }
        public int Salary { get; set; }
        public DateOnly DateWhenHired { get; set; }
    }

    public class Faculty: Employee
    {
        public string Title { get; set; }
    }

    public class Staff: Employee
    {
    }
}
