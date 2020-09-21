﻿using System;

namespace StringsForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string helloWorld = "Hello World!";
            Console.WriteLine(helloWorld[0]);
            Console.WriteLine(helloWorld[6]);

            int stringlength = helloWorld.Length;
            Console.WriteLine($"Your text is {stringlength} symbols long");

            char searchCriteria = 'o';
            int counter = 0;

            foreach(char letter in helloWorld)
            {
                if(letter == searchCriteria)
                {
                    counter = counter + 1;
                }
            }

            Console.WriteLine($"There are {counter} Os in your text");
        }
    }
}