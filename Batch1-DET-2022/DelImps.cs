using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class DelImps
    {
        public static void Main()
        {
            Action<string> act = (string name) => { Console.WriteLine($"Hello Mr. {name}"); };
            act.Invoke("Stark");

            Action<int, string> act1 = (int s, string sender) => { Console.WriteLine($"There are {s} new Messages from {sender}"); };
            act1.Invoke(4, "Ms. Potts");
          
            Func<int, int, int> multi = (x, y) => { return x * y; };
            int result = multi(1, 6);
            
            Action<int, string, string, int> act2 = (int a, string b, string c, int d) => { Console.WriteLine($"{a} new sightings of {b} were reported around {c} Area in the {d} hour(s)"); };
            act2.Invoke(result, "Aldrich Killian", "Los Angeles", 24);


        }
    }
}
