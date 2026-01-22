using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAMAJALAN_ACT5_USERINPUTMETHOD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aivy Camajalan IT401P          
            //Re-use your code in Activity 4, both your main class and main program.
            //Develop your own user-input method or user-input class, which you will reuse in the main program.
            //Make sure to capture all instances when running your program, but only after you have polished your code.
            //DO NOT CAPTURE YET WHEN YOU ARE STILL TESTING YOUR PROGRAM.


            //Create an array of objects
            Songs[,] song = new Songs[2, 2]; // 2 rows and 2 columns

            //user input for the sadsongs
            Console.WriteLine("----List your fav Sad Songs----");
            for (int a = 0; a < 2; a++)
            {

                Console.WriteLine($"\nSadSongs 0.{a + 1}");

                Console.Write("Enter a Title: ");
                string Title = Console.ReadLine();

                Console.Write("Name of the Artist: ");
                string Artist = Console.ReadLine();

                Console.Write("Date Released: ");
                string Date = Console.ReadLine();

                song[0, a] = new SadSongs(Title, Artist, Date);

            }

            // user input for the love songs
            Console.WriteLine("\n----List your fav Love Songs----");
            for (int a = 0; a < 2; a++)
            {
                Console.WriteLine($"\nLoveSongs 0.{a + 1}");

                Console.Write("Enter a LoveSongs Title: ");
                string Title = Console.ReadLine();

                Console.Write("Name of the Artist: ");
                string Artist = Console.ReadLine();

                Console.Write("Language (Bisaya, Tagalog, English): ");
                string Language = Console.ReadLine();

                song[1, a] = new LoveSongs(Title, Artist, Language);

            }


            Console.Clear(); // to clear all data inputted by the user

            //to show the output
            Console.WriteLine("===All list of your favorite Sadsongs & LoveSongs===");            
            for (int row = 0; row < song.GetLength(0); row++)
            {
                for (int col = 0; col < song.GetLength(1); col++)
                {
                    song[row, col].DisplayInfo();

                }
            }

            Console.ReadKey();
        }
    }
}
