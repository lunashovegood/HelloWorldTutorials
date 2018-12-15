using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1, number2;

            Console.WriteLine("We're going to be adding two numbers within 10. Press any key to confirm." );

            Console.ReadKey();

            Console.WriteLine("Please enter a number between 1 and 10:");
            number1 = int.Parse(Console.ReadLine());

            if (number1 > 10)
                Console.WriteLine("Hey! The number should be 10 or less:");
            else if (number1 < 0)
                Console.WriteLine("Hey! The number should be 0 or more!");
            else
                Console.WriteLine("Well done!");

            Console.WriteLine("Thank you. One more:");

            number2 = int.Parse(Console.ReadLine());

            if (number2 > 10)
                Console.WriteLine("Hey! The number should be 10 or less:");
            else if (number2 < 0)
                Console.WriteLine("Hey! The number should be 0 or more!");
            else
                Console.WriteLine("Well done!");

            Console.ReadKey();
            
          
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
