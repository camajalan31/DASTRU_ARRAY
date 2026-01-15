using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camajalan_ControlStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Main:
           //User input
            Console.Clear();
            Console.WriteLine("This program will determine what type of number and display its range.");
            Console.Write("\nEnter a number: ");

            int num;
            string input = Console.ReadLine();
            if (!int.TryParse(input, out num))

            {
               //this message will display if the user input a letters.
                Console.WriteLine("Please re-try to enter a numeric value.");
                Console.Write("\nDo you want to Try Again (y/n)? ");
                char a = Convert.ToChar(Console.ReadLine());

                if (a == 'y')
                {
                    goto Main;

                }

                else if (a == 'n')
                {
                    
                    Console.Clear();
                    Console.WriteLine("Thankyou for using this program."); //It will display when the user will enter n (no) if he doesn't want to try again.
                    Console.ReadKey();
                }
            }
           
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is an EVEN number");
                Console.WriteLine("\nThis is the range of numbers based from the number you entered. ");
                for (int i = 1; i <= num; num -= 2)
                {

                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

            else
            {
                //this message will display when the user input an ODD number.
                Console.WriteLine("Sorry! I cannot provide the range of numbers based from the number you entered.");
            }


            Console.Write("\nDo you want to Try Again (y/n)? ");
            char n = Convert.ToChar(Console.ReadLine());

            if (n == 'y')
            {
                goto Main;

            }

            else if (n == 'n')
            {
                
                Console.Clear();
                Console.WriteLine("Thankyou for using this program.");//It will display when the user will enter n (no) if he doesn't want to try again.             
            }
            Console.ReadKey();

        }
    }
}




