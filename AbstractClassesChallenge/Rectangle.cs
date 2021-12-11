using System;

namespace AbstractClassesChallenge
{
    public class Rectangle : Shape
    {
        // Implement your Rectangle class here.
        double rectangleLength;
        double rectangleWidth;
        public override double GetArea()
        {
            Console.WriteLine("Enter sides of the Rectangle");
            rectangleLength = Console.ReadLine();
            rectangleWidth = Console.ReadLine();
            Area = rectangleLength * rectangleWidth;
            return this.Area;
        }
    }
}
