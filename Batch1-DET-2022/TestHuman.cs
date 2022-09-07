using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestHuman
    {
        public static void Main()
        {
            Student1 std1 = new Student1 { FirstName = "Peter", LastName = "Parker", Marks = 4 };
            Student1 std2 = new Student1 { FirstName = "Gwen", LastName = "Stacy", Marks = 3 };
            Worker wrk1 = new Worker { FirstName = "Maria", LastName = "Hill", HoursWorked = 162, Wage = 70000};
            Worker wrk2 = new Worker { FirstName = "Nicholas", LastName = "Fury", HoursWorked = 168, Wage = 90000 };

            Console.WriteLine($"Name: {std1.FirstName} {std1.LastName}");
            Console.WriteLine($"Marks: {std1.Marks} GPA");
            Console.WriteLine($"Name: {std2.FirstName} {std2.LastName}");
            Console.WriteLine($"Marks: {std2.Marks} GPA");

            double Hw1, Hw2;
            Hw1 = wrk1.HourlyWage(wrk1.Wage, wrk1.HoursWorked);
            Hw2 = wrk2.HourlyWage(wrk2.Wage, wrk2.HoursWorked);

            Console.WriteLine($"Name: {wrk1.FirstName} {wrk1.LastName}");
            Console.WriteLine($"Earnings: {wrk1.Wage}$");
            Console.WriteLine($"Hours Worked: { wrk1.HoursWorked}");
            Console.WriteLine($"Hourly Earning: {Hw1}$");
            Console.WriteLine($"Name: {wrk2.FirstName} {wrk2.LastName}");
            Console.WriteLine($"Earning: {wrk2.Wage}$");
            Console.WriteLine($"Hours Worked: {wrk2.HoursWorked}");
            Console.WriteLine($"Hourly Earning: {Hw2}$");
        }
    }
}
