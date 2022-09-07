using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class LinQAssignment
    {
        public static void Main()
        {
            string[] names = { "John", "Jacob", "Peter", "Jackson", "Harry" };
            var name = from n in names where n.Contains("o") select n;

            foreach (string n in name)
                Console.WriteLine(n);
            Console.WriteLine("_____________");   
            var result = names.OrderByDescending(n => n.Length);
            var largest = result.Take(1);
            foreach(string n in largest)
                Console.WriteLine(n);



            Console.WriteLine("_____________");
            string[] words = { "believe", "relief", "reciept", "field" };
            foreach (string m in words)
                Console.WriteLine($"{m} -- {m.Length}");


            Console.WriteLine("_____________");
            string[] str = { "blueberry", "blackberry", "abacus" };
            var res = str.OrderBy(x => x);
            foreach (string item in res)
                Console.WriteLine(item.Reverse().ToArray());
        }
    }
}
