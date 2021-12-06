using System;

namespace AbstractClassesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Shape ShapeObject = new Shape();
            Rectangle RectangleObject = new Rectangle();
            Square SquareObject = new Square();
            Triangle TriangelObject = new Triangle();
            ShapeObject.Name = Console.ReadLine("Enter Name of Shape");
            ShapeObject.NumSides = Console.ReadLine("Enter number of sides of the shape");
            ShapeObject.LengthOfSides[] = Console.ReadLine("Enter  sides of the shape");
            RectangleObject.GetArea();
            TriangelObject.GetArea();
            SquareObject.GetArea();





        }
    }
}
