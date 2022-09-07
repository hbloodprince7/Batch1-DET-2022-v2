using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class TestPerson
    {
        public static void Main()
        {
            try
            {
                Person t = new Person("Anthony", "Stark", "tonystark@stark.com", new DateOnly(1970, 05, 29));
                int byear = t.BirthYear();
                if (byear < 1900 )
                {
                    throw new InvalidBirthYearException("ENTER VALID BIRTH YEAR AFTER 1900");
                }
                else if (byear > DateTime.Now.Year)
                {
                    throw new InvalidBirthYearException("BIRTH YEAR CANNOT BE IN THE FUTURE");
                }
                    string r = t.GetSunSign();
                string s = t.ChineseZodiac();
                string w = t.IsAdult();
                string b = t.BDayStatus();
                string u = t.DefaultUsername();
                string n = t.GetInfo();
                Console.WriteLine($"NAME = {n}");
                Console.WriteLine($"Sun Sign = {r}");
                Console.WriteLine($"Chinese Zodiac = {s}");
                Console.WriteLine($"Age Status = {w}");
                Console.WriteLine($"Birthday Status = {b}");
                Console.WriteLine($"Default Username = {u}");
            }
            catch (InvalidBirthYearException e)
            {
                Console.WriteLine(e.Message);   
            }
            catch (Exception m)
            {
                Console.WriteLine(m.Message);   
            }
        }
    }
}
