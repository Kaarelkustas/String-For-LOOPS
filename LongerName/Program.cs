using System;

namespace LongerName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first name.");
            string nameone = Console.ReadLine();
            Console.WriteLine("Enter the second name.");
            string nametwo = Console.ReadLine();

            int lenghtone = 0;
            int lenghttwo = 0;

            foreach(char letter in nameone)
            {
                lenghtone = lenghtone + 1;
            }
             foreach (char letter in nametwo)
            {
                lenghttwo = lenghttwo + 1;
            }

            if (lenghtone > lenghttwo)
            {
                Console.WriteLine("The first name is longer.");
            }else if (lenghtone < lenghttwo)
            {
                Console.WriteLine("The second name is longer.");
            }else Console.WriteLine("The names are exactly as long.");


        }
    }
}
