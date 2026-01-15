using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAMAJALAN_2D_Array_of_Objects
{
    internal class Songs
    {
        public string Title { get; set; }
        public string Artist { get; set; }

        //parameterized constructor
        public Songs(string title, string artist)
        {
            Title = title;
            Artist = artist;
        }

        public virtual void DisplayInfo() //virtual method to overriden
        {
            Console.WriteLine($"Title:  {Title}");
            Console.WriteLine($"by: {Artist}");

        }
    }
    class SadSongs : Songs //Derived Class1
    {
        //another property
        public string Date { get; set; }

        //parameterized Constructor
        public SadSongs(string title, string artist, string date) : base(title, artist)
        {
            Date = date;
        }

        public override void DisplayInfo() //Overriding method
        {
            Console.WriteLine("\n----SadSongs List----");
            base.DisplayInfo(); //call the virtual method in base class
            Console.WriteLine($"Date Released: {Date}");

        }
    }
    class LoveSongs : Songs //Derived Class2
    {
        //another property
        public string Language { get; set; }


        //parameterized constructor
        public LoveSongs(string title, string artist, string language) : base(title, artist)
        {
            Language = language;

        }

        public override void DisplayInfo() //Overriding method
        {
            Console.WriteLine("\n----LoveSongs List----");
            base.DisplayInfo();  //call the virtual method in base Class          
            Console.WriteLine($"Language Used: {Language}");


        }
    }
}
