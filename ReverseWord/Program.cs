﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReverseWord
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, ".*?[a-zA-Z].*?") || !string.IsNullOrEmpty(input))
                {
                    var resultsReverseWords = SpinWords(input);
                    Console.WriteLine(resultsReverseWords);
                }
                else
                    Console.WriteLine("not a string, string can't be empty");
            }
        }

        static string SpinWords(string word)
        {
            var splitWord = word.Split(' ');
            string sortedReversedString = string.Empty;
            if (splitWord.Count() != 0)
            {
                var wordsUnderFiveLength = splitWord.Where(x => x.Length < 5)
                   .OrderBy(s => s).ThenBy(k => k.Length);

                if (wordsUnderFiveLength.Count() != 0)
                {
                    foreach (var item in wordsUnderFiveLength)                  
                        sortedReversedString += $"{item} ";
                }

                for (int idx = 0; idx < splitWord.Length; idx++)
                {
                    if (splitWord[idx].Length >= 5)
                    {
                        char[] ch = splitWord[idx].ToArray();
                        Array.Reverse(ch);
                        var join = string.Join("", ch);
                        sortedReversedString += $"{join} ";
                    }
                }
            }
            return sortedReversedString.TrimEnd();
        }
    }
}
