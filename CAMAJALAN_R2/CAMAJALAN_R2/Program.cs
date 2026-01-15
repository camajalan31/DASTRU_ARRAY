using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAMAJALAN_R2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create instances of each type of shape and a parameterized constructor
            Shape circle = new Circle("Yellow", 9);
            Shape rectangle = new Rectangle("Black", 2, 3);

            //Display the Area of the Circle
            circle.DisplayInfo();
            Console.WriteLine($"Area of Circle: {circle.GetArea()}");

            //Display the Area of the rectangle
            rectangle.DisplayInfo();
            Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}");

            Console.ReadKey();
        }
    }
}
