using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestICar
    {
        public static void Main()
        {
            Ford a1 = new Ford { ModelName = "Mustang", ModelVersion = "Shelby GT" };
            BMW a2 = new BMW { ModelName = "M3", ModelVersion = "F80" };
            Console.WriteLine($"NAME : {a1.ModelName}, VERSION : {a1.ModelVersion}");
            Console.WriteLine(a1.SendEngine(a1.ModelName) + a1.SendPrice(a1.ModelName)) ;
            Console.WriteLine($"NAME : {a2.ModelName}, VERSION : {a2.ModelVersion}");
            Console.WriteLine(a2.SendEngine(a2.ModelName)+a2.SendPrice(a2.ModelName));
        }
    }
}
