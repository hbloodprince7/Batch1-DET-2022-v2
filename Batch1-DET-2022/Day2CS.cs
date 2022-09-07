namespace Batch1_DET_2022
{
    public class Day2CS
    {
        public static int Sum(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
                sum += i;
            return sum;
        }

        public static void Main()
        {
            Console.WriteLine(Sum(1, 2, 3));
            Console.WriteLine(Sum(2, 3, 4));
            try
            {
                Console.WriteLine("ENTER A NUMBER BETWEEN 1 & 10,000");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine(Sum(x, 1, 2, 99));
                Console.WriteLine($"Square Root of {x} is {Math.Sqrt(x)}");
                if (x > 10000)
                {
                    throw new InvalidDataException("Number not in range");
                }
            }
            catch (OverflowException Ex)
            {
                Console.WriteLine("ENTER A VALID NUMBER");
            }
            catch (FormatException Form)
            {
                Console.WriteLine("CANNOT PROCESS STRING VALUES");
            }
            catch (Exception exp)
            {
                Console.WriteLine($"Invalid Input" + "ERROR MESSAGE: " + exp.Message);
            }
            finally
            {
                Console.WriteLine("THANK YOU");
            }
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            Console.WriteLine(Sum(a));
            Console.WriteLine("ENTER YOUR BIRTHDATE");
            DateTime Dob = DateTime.Parse(Console.ReadLine());
            DateTime Tday = DateTime.Today;
            Console.WriteLine($"Your Age is {Tday.Year - Dob.Year}");
        }
    }
}
