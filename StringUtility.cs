using System;
using System.Collections.Generic;

namespace Peeps
{
    public class StringUtility
    {
        public static void Summarize(string summary, int maxLength = 20)
        {
            if (summary.Length < maxLength)
            {
                Console.WriteLine(summary);
            }

            else
            {
                var words = summary.Split(" ");
                var totalChars = 0;
                var summaryWords = new List<string>();
                foreach (var word in words)
                {
                    summaryWords.Add(word);
                    totalChars += word.Length + 1;
                    if (totalChars > maxLength)
                    {
                        break;
                    }
                }

                var res = String.Join(" ", summaryWords) + "...";
                Console.WriteLine(res);
            }
        }
    }
}
