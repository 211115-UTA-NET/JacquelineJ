using System;

namespace AbstractClassesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            Shape ShapeObject = new Shape();
            Rectangle RectangleObject = new Rectangle();
            Square SquareObject = new Square();
            Triangle TriangelObject = new Triangle();
            ShapeObject.NumSides = Console.ReadLine("Enter number of sides of the shape");
            ShapeObject.Name = Console.ReadLine("Enter Name of Shape");

            if (ShapeObject.Name == "Triangle")
            {
               
                Console.WriteLine($"Area of the Triangle is : TriangelObject.GetArea()");

            }
            if (ShapeObject.Name == "Square")
            {
               
                 Console.WriteLine($"Area of the Triangle is : SquareObject.GetArea()");

            }
            if (ShapeObject.Name == "Rectangle")
            {
               
                Console.WriteLine($"Area of the Triangle is : RectangleObject.GetArea()");

            }
        }
    }
}
