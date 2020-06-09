using System;
using System.IO;
using System.Linq;

namespace Peeps
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\temp\derp.txt";

            var content = ReadFile(path);
            var longestWord = FindLongestWordInSentence(content);
            Console.WriteLine(longestWord);
        }

        private static string FindLongestWordInSentence(string content)
        {
            var words = content.Split(" ");
            var longest = 0;
            string word = "";
            foreach (String s in words)
            {
                if (s.Length > longest)
                {
                    longest = s.Length;
                    word = s;
                }
            }
            return word;
        }

        private static string ReadFile(string path)
        {
            var content = File.ReadAllText(path);
            return content;
        }

        private static void FileMethods2()
        {
            //Directory.CreateDirectory(@"c:\temp\folder1");
            var files = Directory.GetFiles(@"C:\Users\David\source\repos", "*.sln", SearchOption.AllDirectories);
            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}
            var directories = Directory.GetDirectories(@"C:\Users\David\source\repos", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }
        }

        private static void FileMethods()
        {
            var path = @"c:\temp\somefile.jpeg";
            File.Copy(@"c:\temp\myfile.jpeg", @"c:\temp\myfile2.jpeg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);


            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {

            }
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
