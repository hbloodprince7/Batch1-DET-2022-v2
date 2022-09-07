using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    class TestIAuthor
    {
        public static void Main()
        {
            Author a = new Author { Name = "mary", EMail = "mary.s", Gender = 'F' };
            SITLAuthor sa = new SITLAuthor { Name = "roja", EMail = "roja.p", Gender = 'F' };

            Console.WriteLine(a.SendEMail());
            Console.WriteLine(a.SendSMS());
            Console.WriteLine(sa.SendEMail());
        }
    }
}
