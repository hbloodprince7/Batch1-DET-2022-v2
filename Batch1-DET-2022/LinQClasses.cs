using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class LinQClasses
    {
        public static void String_Groupby()
        {
            List<string> words = new List<string>
            {
                "basket","blueberry","chimpanze","abacus","banana","apple","cheese"
            };
            var wordGroups = words.GroupBy(x => x.Length).Select(y => new { lengthOfWord = y.Key, Words = y });

            foreach (var item in wordGroups)
            {
                Console.WriteLine("Words with '{0}' letters :", item.lengthOfWord);
                foreach (var w in item.Words)
                {
                    Console.WriteLine(w);
                }
            }
        }
        //    public static void SampleInList()
        //    {
        //        //1.DATA SOURCE
        //        List<string> avengers = new List<string>();
        //        avengers.Add("Iron Man");
        //        avengers.Add("Captain America");
        //        avengers.Add("Hawk Eye");
        //        avengers.Add("Hulk");
        //        //2.QUERY CREATION
        //        //DEFERRED EXECUTION:
        //        //var numQuery = from num in numbers where num>100 select num;
        //        var AvengersQuery = from hero in avengers select hero;
        //        //EARLY EXECUTION:
        //        //var numQuery = (from num in numbers select num).ToList();
        //        avengers.Add("Thor Odinson");
        //        avengers.Add("Black Widow");

        //        //3.QUERY EXECUTION
        //        foreach (string hero in AvengersQuery)
        //        {
        //            Console.WriteLine($"{hero}");
        //        }
        //    }

        //    public static void SampleOrderBy()
        //    {
        //        int[] numbers = { 1, 18, 7, 5, 99, 9, 77, 25 };

        //        var res = numbers.OrderBy(n => n);



        //        Console.WriteLine("Ordered list of numbers:");
        //        foreach (int number in res)
        //            Console.WriteLine(number);
        //    }

        //    public static void SampleOrderByDescending()
        //    {
        //        string[] ShieldMembers = { "Tony Stark", "Bucky Barnes", "Steve Rogers", "Peter Parker", "Sam Wilson", "T'Challa", "Natasha Romanova", "Loki Jottunhiem" };

        //        var result = ShieldMembers.OrderByDescending(n => n);

        //        Console.WriteLine("Descending ordered list of names:");
        //        foreach (string name in result)
        //            Console.WriteLine(name);
        //    }

        //    public static void SampleReverse()
        //    {
        //        char[] characters = { 'l', 'e', 'v', 'r', 'a', 'm' };

        //        var str = characters.Reverse();

        //        Console.WriteLine("Characters in reverse order:");
        //        foreach (char character in str)
        //            Console.WriteLine(character);
        //    }

        //    public static void SampleThenBy()
        //    {
        //        string[] teams = { "Avengers", "Gaurdians Of The Galaxy", "Fantasic Four", "Inhumans", "Defenders", "Mutants" };

        //        var result = teams.OrderBy(c => c.Length).ThenBy(c => c);

        //        Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
        //        foreach (string team in result)
        //            Console.WriteLine(team);
        //    }

        //    public static void SampleThenByDescending()
        //    {
        //        var spideyallies = new string[] { "Peter Parker", "MJ Watson", "Gwen Stacy", "Harry Osborn", "Eddie Brock" };

        //        var allies = spideyallies.OrderByDescending(d => d).ThenByDescending(d => d.Length);

        //        Console.WriteLine("List Of Known Allies of Spider Man:");
        //        foreach (string ally in allies)
        //            Console.WriteLine($"{ally}");
        //    }
        //    public static void SampleSkip()
        //    {
        //        string[] stark = { "Pepper Potts", "Anthony Stark", "Happy Hogan", "Maria Hill", "Peter Parker", "Vision" };

        //        var result = stark.Skip(4);

        //        Console.WriteLine("Skips the first 4 names:");
        //        foreach (string word in result)
        //            Console.WriteLine(word);
        //    }
        //    public static void SampleSkipWhile()
        //    {
        //        string[] words = { "Steve Rogers", "Bucky Barnes", "Samuel Wilson", "Nicholas J Fury", "Matt Murdock" };

        //        var result = words.SkipWhile(w => w.Length == 12);

        //        Console.WriteLine("Skips words while the condition is met:");
        //        foreach (string word in result)
        //            Console.WriteLine(word);
        //    }
        //    public static void SampleTake()
        //    {
        //        int[] numbers = { 7077, 8055, 0588, 6595, 6859, 4523, 7734 };

        //        var result = numbers.Take(5);

        //        Console.WriteLine("Takes the first 5 numbers only:");
        //        foreach (int number in result)
        //            Console.WriteLine(number);
        //    }
        //    public static void SampleTakeWhile()
        //    {
        //        int[] numbers = { 1, 17, 25, 26, 56, 5, 2, 32, 45 };

        //        var result = numbers.TakeWhile(n => n <= 25);

        //        Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
        //        foreach (int number in result)
        //            Console.WriteLine(number);
        //    }

        //    public static void SampleAggregate()
        //    {
        //        var numbers = new int[] { 1, 2, 3, 4, 5 };

        //        var result = numbers.Aggregate((a, b) => a * b);

        //        Console.WriteLine("Aggregated numbers by multiplication:");
        //        Console.WriteLine(result);
        //    }
        //    public static void SampleAverage()
        //    {
        //        int[] numbers = { 10, 10, 11, 11 };

        //        var result = numbers.Average();

        //        Console.WriteLine("Average is:");
        //        Console.WriteLine(result);
        //    }
        //    public static void SampleCount()
        //    {
        //        string[] names = { "Wanda", "Pietro", "Agatha", "Vision", "Jane" };

        //        var result = names.Count();

        //        Console.WriteLine("Counting names gives:");
        //        Console.WriteLine(result);
        //    }
        //    public static void SampleLongCount()
        //    {
        //        var largeArr = Enumerable.Range(0, Int32.MaxValue).Concat(Enumerable.Range(0, 5));

        //        Int64 result = largeArr.LongCount();

        //        Console.WriteLine("Counting largeArr elements:");
        //        Console.WriteLine(result);
        //    }
        //    public static void SampleMax()
        //    {
        //        int[] numbers = { 8, 9, 7, 5, 45, 65 };

        //        var result = numbers.Max();

        //        Console.WriteLine("Highest number is:");
        //        Console.WriteLine(result);
        //    }
        //    public static void SampleMin()
        //    {
        //        int[] numbers = { 5, 3, -3, 8, 4, 21, 7 };

        //        var result = numbers.Min();

        //        Console.WriteLine("Lowest number is:");
        //        Console.WriteLine(result);
        //    }
        //    public static void SampleSum()
        //    {
        //        int[] numbers = { 2, 5, 10 };

        //        var result = numbers.Sum();

        //        Console.WriteLine("Summing the numbers yields:");
        //        Console.WriteLine(result);
        //    }
        //    public static void SampleAll()
        //    {
        //        string[] names = { "Clint", "Bruce", "Blake", "J Jonah Jamieson" };

        //        var result = names.All(n => n.StartsWith("B"));

        //        Console.WriteLine("Does all of the names start with the letter 'B':");
        //        Console.WriteLine(result);
        //    }
        //    public static void SampleAny()
        //    {
        //        string[] names = { "Bruce", "Mathew", "Frank", "Foggy", "Brendon" };

        //        var result = names.Any(n => n.StartsWith("B"));

        //        Debug.WriteLine("Does any of the names start with the letter 'B':");
        //        Debug.WriteLine(result);
        //    }
        //    public static void SampleContains()
        //    {
        //        int[] numbers = { 1, 3, 5, 7, 9 };

        //        var result = numbers.Contains(5);

        //        Console.WriteLine("sequence contains the value 5:");
        //        Console.WriteLine(result);
        //    }
        //    public static void SampleDistinct()
        //    {
        //        int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };

        //        var result = numbers.Distinct();

        //        Console.WriteLine("Distinct removes duplicate elements:");
        //        foreach (int number in result)
        //            Console.WriteLine(number);
        //    }
        //    public static void SampleExcept()
        //    {
        //        int[] numbers1 = { 1, 2, 3 };
        //        int[] numbers2 = { 3, 4, 5 };

        //        var result = numbers1.Except(numbers2);

        //        Console.WriteLine("Except creates a single sequence from numbers1 and removes the duplicates found in numbers2:");
        //        foreach (int number in result)
        //            Console.WriteLine(number);
        //    }
        //    public static void SampleIntersect()
        //    {
        //        int[] numbers1 = { 1, 2, 3 };
        //        int[] numbers2 = { 3, 4, 5 };

        //        var result = numbers1.Intersect(numbers2);

        //        Console.WriteLine("Intersect creates a single sequence with only the duplicates:");
        //        foreach (int number in result)
        //            Console.WriteLine(number);
        //    }
        //    public static void SampleUnion()
        //    {
        //        int[] numbers1 = { 1, 2, 3 };
        //        int[] numbers2 = { 3, 4, 5 };

        //        var result = numbers1.Union(numbers2);

        //        Console.WriteLine("Union creates a single sequence and eliminates the duplicates:");
        //        foreach (int number in result)
        //            Console.WriteLine(number);
        //    }
        //    public static void SampleElementAt()
        //    {
        //        string[] words = { "One", "Two", "Three" };

        //        var result = words.ElementAt(1);

        //        Console.WriteLine("Element at index 1 in the array is:");
        //        Console.WriteLine(result);
        //    }
        //    public static void SampleElementAtOrDefault()
        //    {
        //        string[] colors = { "Red", "Green", "Blue" };

        //        var resultIndex1 = colors.ElementAtOrDefault(1);

        //        var resultIndex10 = colors.ElementAtOrDefault(10);

        //        Console.WriteLine("Element at index 1 in the array contains:");
        //        Console.WriteLine(resultIndex1);

        //        Console.WriteLine("Element at index 10 in the array does not exist:");
        //        Console.WriteLine(resultIndex10 == null);
        //    }
        //    public static void SampleFirstSimple()
        //    {
        //        string[] fruits = { "Banana", "Apple", "Orange" };

        //        var result = fruits.First();

        //        Console.WriteLine("First element in the array is:");
        //        Console.WriteLine(result);
        //    }
        //    public static void SampleFirstConditional()
        //    {
        //        string[] countries = { "Denmark", "Sweden", "Norway" };

        //        var result = countries.First(c => c.Length == 6);

        //        Console.WriteLine("First element with a length of 6 characters:");
        //        Console.WriteLine(result);
        //    }
        //    public static void SampleFirstOrDefault()
        //    {
        //        string[] countries = { "Denmark", "Sweden", "Norway" };
        //        string[] empty = { };

        //        var result = countries.FirstOrDefault();

        //        var resultEmpty = empty.FirstOrDefault();

        //        Console.WriteLine("First element in the countries array contains:");
        //        Console.WriteLine(result);

        //        Console.WriteLine("First element in the empty array does not exist:");
        //        Console.WriteLine(resultEmpty == null);
        //    }
        //    public static void SampleLast()
        //    {
        //        int[] numbers = { 7, 3, 5 };

        //        var result = numbers.Last();

        //        Console.WriteLine("Last number in array is:");
        //        Console.WriteLine(result);
        //    }
        //    public static void SampleLastOrDefault()
        //    {
        //        string[] words = { "one", "two", "three" };
        //        string[] empty = { };

        //        var result = words.LastOrDefault();

        //        var resultEmpty = empty.LastOrDefault();

        //        Console.WriteLine("Last element in the words array contains:");
        //        Console.WriteLine(result);

        //        Console.WriteLine("Last element in the empty array does not exist:");
        //        Console.WriteLine(resultEmpty == null);
        //    }
        //    public static void SampleLastOrDefaultConditional()
        //    {
        //        string[] words = { "one", "two", "three" };

        //        var result = words.LastOrDefault(w => w.Length == 3);

        //        var resultNoMatch = words.LastOrDefault(w => w.Length == 2);

        //        Console.WriteLine("Last element in the words array having a length of 3:");
        //        Console.WriteLine(result);

        //        Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
        //        Console.WriteLine(resultNoMatch == null);
        //    }
        //    public static void SampleSingleLambda()
        //    {
        //        string[] names1 = { "Peter" };
        //        string[] names3 = { "Peter", "Joe", "Wilma" };
        //        string[] empty = { };

        //        var result1 = names1.Single();

        //        Console.WriteLine("The only name in the array is:");
        //        Console.WriteLine(result1);

        //        try
        //        {
        //            // This will throw an exception because array contains no elements
        //            var resultEmpty = empty.Single();
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }

        //        try
        //        {
        //            // This will throw an exception as well because array contains more than one element
        //            var result3 = names3.Single();
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //    }
        //    public static void SampleSingleOrDefault()
        //    {
        //        string[] names1 = { "Peter" };
        //        string[] names3 = { "Peter", "Joe", "Wilma" };
        //        string[] empty = { };

        //        var result1 = names1.SingleOrDefault();

        //        var resultEmpty = empty.SingleOrDefault();

        //        Console.WriteLine("The only name in the array is:");
        //        Console.WriteLine(result1);

        //        Console.WriteLine("As array is empty, SingleOrDefault yields null:");
        //        Console.WriteLine(resultEmpty == null);

        //        try
        //        {
        //            // This will throw an exception as well because array contains more than one element
        //            var result3 = names3.SingleOrDefault();
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //    }


    }
}