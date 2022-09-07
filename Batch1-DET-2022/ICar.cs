using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public interface ICar
    {
        string SendEngine(string ModelName);
        int SendPrice(string ModelName);
    }
    public class Ford : ICar
    {
        public string ModelName { get; set; }
        public string ModelVersion { get; set; }

        public string SendEngine(string ModelName)
        {
            if(ModelName == "Mustang")
            {
                if (ModelVersion == "Shelby GT")
                {
                    return $"V8 5.0L Petrol Engine ";
                }
                else if (ModelVersion == "Mach E")
                {
                    return $"Electric Engine ";
                }
                else
                {
                    return "No Matching Models Found";
                }
            }
            else
            {
                return "No Models Found";
            }
        }
        public int SendPrice(string ModelName)
        {
            if (ModelName == "Mustang")
            {
                if (ModelVersion == "Shelby GT")
                {
                    return 7400000;
                }
                else if (ModelVersion == "Mach E")
                {
                    return 7000000;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
    }
    public class BMW : ICar 
    {
        public string ModelName { get; set; }
        public string ModelVersion { get; set; }

        public string SendEngine(string ModelName)
        {
            if (ModelName == "M3")
            {
                return $"V6 4.0L Diesel Engine ";
            }
            else if (ModelName == "iX")
            {
                return "Electric Vehicle";
            }
            else
            {
                return "No Matching Models Found";
            }
        }
        public int SendPrice(string ModelName)
        {
            if (ModelName == "M3")
            {
                return 13000000;
            }
            else if (ModelName == "iX")
            {
                return 11600000;
            }
            else
            {
                return 0;
            }
        }
    }

}
