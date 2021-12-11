using System;

namespace AbstractClassesChallenge
{
    public class Square : Rectangle
    {
        // Implement your Square Class here.
        // Implement your Rectangle class here.
        double squareSide;
        public override double  GetArea()
        {
            Console.WriteLine("Enter side of the Square");
            squareSide = Console.ReadLine();
            Area = squareSide * squareSide;
            return this.Area;
        }

    }
}
