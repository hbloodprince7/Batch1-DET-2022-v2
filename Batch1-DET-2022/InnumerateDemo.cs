using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class InnumerateDemo
    {
        static void Main()
        {
            //foreach (int number in SomeNumbers())
            //{
            //    Console.Write(number.ToString() + " ");
            //}
            //// Output: 3 5 8
            //Console.ReadKey();
            var Avengers = new HashSet<string>(){ "Ironman", "Hulk", "Captain America", "Black Widow", "Ironman","Hulk", "Captain America", "Black Widow", "Hawkeye", "Thor", "Spider Man", "Star Lord", "Loki" };       

            foreach (var avenger in Avengers)
            {
                Console.WriteLine(avenger);
            }
        }

        //public static System.Collections.IEnumerable SomeNumbers()
        //{
        //    yield return 3;
        //    yield return 5;
        //    yield return 8;
        //}
    }
}
