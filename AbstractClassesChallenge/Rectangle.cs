using System;

namespace AbstractClassesChallenge
{
    public class Rectangle : Shape
    {
        // Implement your Rectangle class here.
        double Area;
        public double GetArea()
        {
            foreach(item in LengthOfSides)
            {
                Area = LengthOfSides[item] * LengthOfSides[item + 1];
            }
            return this.Area;
        }

    }



    }
}
