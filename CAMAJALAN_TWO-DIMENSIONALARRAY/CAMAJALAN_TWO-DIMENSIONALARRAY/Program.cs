using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAMAJALAN_TWO_DIMENSIONALARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aivy Camajalan, IT401P
            //Two- Dimensional Array
            string[,] colors = new string[3, 3] //3 ROWS AND 3 COLUMNS
            {

                {"WHITE "," BLACK "," GRAY" },
                {"CYAN  "," YELLOW ","MAGENTA AND KEY/BLACK" },
                {"RED   "," GREEN "," BLUE" },
            };

            //Display the words in the 2dimensional array
            Console.WriteLine("The rows represents the NEUTRAL, CMYK and RGB colors.\n");
            for (int r = 0; r < colors.GetLength(0); r++)
            {
                
                for (int c = 0; c < colors.GetLength(1); c++) 
                {
                    Console.Write(colors[r, c] + " ");
                }
                Console.WriteLine(); //this is the line after each rows
                
            }
            Console.ReadKey();
        }
    }
}
