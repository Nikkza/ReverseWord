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
                if (Regex.IsMatch(input, ".*?[a-zA-Z].*?"))
                {
                    var resultsReverseWords = SpinWords(input);
                    Console.WriteLine(resultsReverseWords);
                }
                else
                    Console.WriteLine("not a string");
            }
        }

        static string SpinWords(string word)
        {
            var splitWord = word.Split(' ');
            string name = string.Empty;

            for (int idx = 0; idx < splitWord.Length; idx++)
            {
                if (splitWord[idx].Length < 5)
                    name += $"{splitWord[idx]} ";
                if (splitWord[idx].Length >= 5)
                {
                    char[] ch = splitWord[idx].ToArray();
                    Array.Reverse(ch);
                    var join = string.Join("", ch);
                    name += $"{join} ";
                }
            }
            return name.TrimEnd();
        }
    }
}