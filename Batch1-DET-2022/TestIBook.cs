using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class TestIBook
    {
        public static void Main()
        {
            IBook b = new IBook
            {
                Name = "Mastering C#",
                author = new Author { Name = "Mary", EMail = "mary.s", Gender = 'f' },
                Price = 500,
                Qty = 45
            };

            Author alex = new Author { Name = "Roja", EMail = "roja.p", Gender = 'f' };
            IBook dummyBook = new IBook { Name = "C#", author = alex, Price = 19, Qty = 99 };
        }
    }
}
