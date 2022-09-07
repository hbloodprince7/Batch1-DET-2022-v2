using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class EmployeeLinqMain
    {
        public static void Main()
        { 
            List<EmployeeLinq> list = new List<EmployeeLinq>();
            list = EmployeeLinq.GetListofEmployees();
        }


    }
}
