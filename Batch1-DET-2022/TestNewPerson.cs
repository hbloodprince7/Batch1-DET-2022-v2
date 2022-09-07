using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class TestNewPerson
    {
        public static void Main()
        {
            NewStudent newstd1 = new NewStudent { Name = "Peter Parker", Address = " Queens, NY", Phone = "558-75565", Email= "peter.parker@marvel.com", YearStatus = 3};
            NewStudent newstd2 = new NewStudent { Name = "Gwen Stacy", Address = " Hell's Kitchen, NY", Phone = "548-772654", Email = "gwen_stacy@marvel.com", YearStatus = 3};

            Faculty f1 = new Faculty { Name = "Mary Jane Watson", Address = "Central Park, NYC", Phone = "855-698533", Email = "mj_watson@marvel.com", Title="Junior Reporter", DateWhenHired = new DateOnly(2003, 8, 7), Office = "Daily Bugle Inc", Salary = 30000};
            Staff s2 = new Staff { Name = "Karen Page", Address = "Hell's Kitchen, NYC", Phone = "752-996558", Email = "k_page21@marvel.com", DateWhenHired = new DateOnly(2009, 2, 17), Office = "Nelson And Murdock, Attorney's At Law", Salary = 17000 };
            Console.WriteLine("STUDENTS");
            Console.WriteLine($"Name = {newstd1.Name}");
            Console.WriteLine($"Address = {newstd1.Address}");
            Console.WriteLine($"Phone = {newstd1.Phone}");
            Console.WriteLine($"Email = {newstd1.Email}");
            Console.WriteLine($"Year = {newstd1.YearStatus}");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Name = {newstd2.Name}");
            Console.WriteLine($"Address = {newstd2.Address}");
            Console.WriteLine($"Phone = {newstd2.Phone}");
            Console.WriteLine($"Email = {newstd2.Email}");
            Console.WriteLine($"Year = {newstd2.YearStatus}");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("EMPLOYEES - FACULTY");
            Console.WriteLine($"Name = {f1.Name}");
            Console.WriteLine($"Address = {f1.Address}");
            Console.WriteLine($"Phone = {f1.Phone}");
            Console.WriteLine($"Email = {f1.Email}");
            Console.WriteLine($"Year = {f1.DateWhenHired}");
            Console.WriteLine($"Office = {f1.Office}");
            Console.WriteLine($"Title = {f1.Title}");
            Console.WriteLine($"Salary = {f1.Salary}$");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("EMPLOYEES - STAFF");
            Console.WriteLine($"Name = {s2.Name}");
            Console.WriteLine($"Address = {s2.Address}");
            Console.WriteLine($"Phone = {s2.Phone}");
            Console.WriteLine($"Email = {s2.Email}");
            Console.WriteLine($"Year = {s2.DateWhenHired}");
            Console.WriteLine($"Office = {s2.Office}");
            Console.WriteLine($"Salary = {s2.Salary}$");

        }
    }
}
