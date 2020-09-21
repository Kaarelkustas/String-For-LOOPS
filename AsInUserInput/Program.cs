using System;

namespace AsInUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your name?");
            string Userinput = Console.ReadLine();

            int counter = 0;
            char searchCriteria = 'a';
            foreach(char letter in Userinput)
            {
                if (letter == searchCriteria)
                {
                    counter = counter + 1;
                }
            }

            if(counter > 0)
            {
                Console.WriteLine($"There are {counter} A's in your text.");
            }else
            {
                Console.WriteLine("There are no A's in your name");
            }

           
        }
    }
}
