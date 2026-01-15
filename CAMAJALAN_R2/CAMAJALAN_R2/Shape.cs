using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CAMAJALAN_R2
{
    class Shape
    {
        //Private Fields Declaration
        private string Color { get; set; }

        //Constructor
        public Shape(string color)
        {
            Color = color;
        }

        //virtual method 
        public virtual double GetArea()
        {
            return 0;
        }

        //Method to display shoes info
        public void DisplayInfo() 
        {
            Console.WriteLine($"\nType of Shape: {this.GetType().Name}  \nColor: {Color} ");
        }

    }

    class Circle : Shape //Derived Class1
    {
        //Private Fields Declaration
        private double Radius { get; set; }

        //Constructor
        public Circle(string color, double radius) : base(color)
        {
            Radius = radius;
        }
        //override method
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        //Private Fields Declaration
        private double Width { get; set; }
        private double Height { get; set; }

        //Constructor
        public Rectangle(string color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }
        // method override
        public override double GetArea()
        {
            return Width * Height;
        }

    }
}
