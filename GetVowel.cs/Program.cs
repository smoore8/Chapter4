﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                String input;

                Console.WriteLine("Enter a Vowel. Any Vowel");
                input = Console.ReadLine().ToLower();
                if (input == "a" || input == "e" || input == "i" || input == "o" || input == "u")
                {
                    Console.WriteLine("Please Enter Another Vowel");

                }
                else if (input != "a" || input != "e" || input != "i" || input != "o" || input != "u")
                {
                    break;
                }
            }
        }
    }
}