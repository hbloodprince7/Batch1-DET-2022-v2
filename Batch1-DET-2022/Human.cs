using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Student1 : Human
    {
        public int Marks { get; set; }
    }

    public class Worker : Human
    {
        public int Wage { get; set; }
        public int HoursWorked { get; set; }
        public double HourlyWage(int Wage,int HoursWorked)
        {
            return (Wage / HoursWorked);
        }
    }

}
