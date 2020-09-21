using System;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string userInput = Console.ReadLine();
            int counter = 0; 

            foreach(char letter in userInput)
            {
                Console.WriteLine(letter);
                counter = counter + 1;
                Console.WriteLine($"letter {letter} is at {counter}");
            }

            Console.WriteLine($"Your name is {counter} characters long");
        }
    }
}
