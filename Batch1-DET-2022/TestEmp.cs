using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestEmp
    {
        enum Grade { Pass = 60, Distinction = 85 };
        /// <summary>
        /// method that returns Grade based on the mark
        /// </summary>
        /// <param name="mark">mark as the input</param>
        /// <returns></returns>
        public static string GetGrade(int mark) //IN parameter
        {
            if (mark >= (int)Grade.Distinction)
                return "Distinction";
            else if (mark >= (int)Grade.Pass)
                return "PASS";
            else
                return "FAIL";
        }
        public static void Main()
        {
            try
            {
                Empl m = new Manager(4671, "Karthika", new DateTime(2005, 5, 10), "techtrng", 10);

                Empl m1 = new Manager(2345, "Jeeva", new DateTime(2010, 1, 14), "PEMS", 450);
                // Console.WriteLine(m1.Print());  //base class ref can point to derived object

                Empl e1 = new Empl(1, "Jiyana", new DateTime(2020, 1, 5));
                //Console.WriteLine(e1.Print());

                Console.WriteLine("enter empid b.w 1001 - 25000");
                int id = Convert.ToInt32(Console.ReadLine());
                if (id < 1001 || id > 25000)
                    throw new InvalidEmpIdException("Entered empid is not in the range...");

                Console.WriteLine("enter emp name");
                string name = Console.ReadLine();

                Console.WriteLine("enter doj");
                DateTime doj = DateTime.Parse(Console.ReadLine());

                Empl e2 = new(id, name, doj);


                List<Empl> list = new List<Empl>();
                list.Add(m);
                list.Add(m1);
                list.Add(e1);
                foreach (Empl x in list)
                    Console.WriteLine(x.Print());
            }
            catch (InvalidEmpIdException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            { }
        }
    }

}

