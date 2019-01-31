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
            bool itisokaytocontinue = false;
            Console.WriteLine("We're going to be adding two numbers within 10. Press enter to confirm." );

            Console.ReadKey();
            while (itisokaytocontinue != true )
            { 
                Console.WriteLine("Please enter a number between 1 and 10.");
                number1 = int.Parse(Console.ReadLine());

                if (number1 > 10)
        
                    Console.WriteLine("Hey! The number should be 10 or less:");
                
                else if (number1 < 1)
                    Console.WriteLine("Hey! The number should be 1 or more!");
                else
                {
                    itisokaytocontinue = true;
                    Console.WriteLine("Well done!");
                }

            }

            itisokaytocontinue = false;
            while (itisokaytocontinue != true)
            {
                Console.WriteLine("Thank you. One more:");

                number2 = int.Parse(Console.ReadLine());

                if (number2 > 10)
                    Console.WriteLine("Hey! The number should be 10 or less:");
                else if (number2 < 1)
                    Console.WriteLine("Hey! The number should be 1 or more!");
                else
                {
                    itisokaytocontinue = true;
                        Console.WriteLine("Well done!"); }
            }
               
            

            Console.ReadKey();
            
          
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
