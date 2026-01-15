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
            //Convert your program in Activity 1 into Object-Oriented Programming Approach.
            //Make sure the class objects will be stored and accessed using an Array. Then, display the details of all objects.

            //Create an array of objects
            Songs[] song = new Songs[6];

            //Assign value each objects
            song[0] = new SadSongs("Multo", "Cup of Joe", "September 14, 2024");
            song[1] = new SadSongs("Take All the Love", "Arthur Nery", "April 23, 2021");
            song[2] = new SadSongs("The Archer", "Taylor Swift", "July 23, 2019");
            song[3] = new LoveSongs("Lover", "Taylor Swift", "English");
            song[4] = new LoveSongs("Padaba Taka", "Dwta", "Tagalog");
            song[5] = new LoveSongs("Pasabta Ko", "Kuya Bryan ft. Leela LAburada", "Cebuano");

            //Display information for each songs
            foreach (Songs Song in song)
            {
                Song.DisplayInfo();
            }

            Console.ReadKey();
        }
    }
}
