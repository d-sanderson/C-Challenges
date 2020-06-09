using System;
using System.Linq;

namespace Peeps
{
    partial class Program
    {
        static void Main(string[] args)
        {
            CountVowels();

        }

        private static void CountVowels()
        {
            Console.WriteLine("enter a word");
            var word = Console.ReadLine();
            var vowels = word.Count("aeiouAEIOU".Contains);
            Console.WriteLine("# of vowels equals: " + vowels);
        }

        private static void PascalCase()
        {
            Console.WriteLine("enter a few words separated by a space");
            var input = Console.ReadLine().ToLower();
            var arr = input.Split(' ');
            var uppercased = Array.ConvertAll(arr, s => char.ToUpper(s[0]) + s.Substring(1));
            Console.WriteLine(string.Join("", uppercased));
        }

        private static void ValidateTime()
        {
            Console.WriteLine("enter a time value in the 24-hour time format (e.g. 19:00)");
            var input = Console.ReadLine();
            var isValidDate = DateTime.TryParse(input, out var validDate);
            if (isValidDate)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        private static string DuplicateChecker()
        {
            Console.WriteLine("Enter hyphen separated values i.e '5-6-7-8-9' or '20-19-18-17-16'");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                return "EXITING YOU FOOL!";
            }

            else
            {
                var stringNums = input.Split('-');
                var ints = Array.ConvertAll(stringNums, s => int.Parse(s));
                var ContainsDupes = ints.Length != ints.Distinct().Count();
                return ContainsDupes ? "Contains Dupes" : "All values entered are unique";

            }
        }

        private static string ConsecutiveChecker()
        {
            Console.WriteLine("Enter hyphen separated values i.e '5-6-7-8-9' or '20-19-18-17-16'");
            var input = Console.ReadLine();
            var stringNums = input.Split('-');
            var ints = Array.ConvertAll(stringNums, s => int.Parse(s));
            var max = ints.Max();
            var min = ints.Min();

            var isConsecutive = min + (ints.Length - 1) == max;

            return isConsecutive ? "CONSECUTIVE!" : "NOT CONSECUTIVE!";
        }
    }
}
