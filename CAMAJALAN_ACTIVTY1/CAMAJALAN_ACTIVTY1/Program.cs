using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAMAJALAN_ACTIVTY1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aivy Camajalan, IT401P
            // Problem: Build a procedural program that will allow the user to store elements into an array and
            //display the elements either in descending or ascending order. Choose a theme for the elements that
            //you would like your user to input into your array. Consider a minimum of 5 or a maximum of 10 as the size or length of your array. 


            //Declare an Array
            string[] Songs = new string[6];

            //User input there top 6 songs
            Console.WriteLine("Please enter your top 6 Title Songs this year.\n");
            for (int idx =0; idx < Songs.Length; idx++)
            {
                Songs[idx] = Console.ReadLine();                  
            }
            //Arranging the Array Elements into ascending order
            Array.Sort(Songs);

            //Display the array elements
            Console.WriteLine("\nHere is the list of your top 6 Title Songs this year in alphabetical order.");
            foreach (string A in Songs) 
            {
                Console.WriteLine(A);
            }
            Console.ReadKey();
           
        }
    }
}
