using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camajalan_Single_Dimensional_Array_Objects_in_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aivy Camajalan IT401P          
            //Re-use your code in Activity 2.
            //In your main program, use two-dimensional array of objects
            //You have to use loop structure to access the 2D array of objects

            //Create an array of objects
            Songs[,] song = new Songs[2, 3]; // 2 rows and 3 columns

            //Assign values to the array
            //Row 0: Sadsongs
            song[0, 0] = new SadSongs("Multo", "Cup of Joe", "September 14, 2024");
            song[0, 1] = new SadSongs("Take All the Love", "Arthur Nery", "April 23, 2021");
            song[0, 2] = new SadSongs("The Archer", "Taylor Swift", "July 23, 2019");

            //Row 1: LoveSongs
            song[1, 0] = new LoveSongs("Lover", "Taylor Swift", "English");
            song[1, 1] = new LoveSongs("Padaba Taka", "Dwta", "Tagalog");
            song[1, 2] = new LoveSongs("Pasabta Ko", "Kuya Bryan ft. Leela LAburada", "Cebuano");

            //Display information for each songs
            for (int row = 0; row < song.GetLength(0); row++) 
            {
                for (int col = 0; col < song.GetLength(1); col++) 
                {
                    song[row, col].DisplayInfo ();
                }
            }    
            
            Console.ReadKey();
        }
    }
}
