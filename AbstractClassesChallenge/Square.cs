using System;

namespace AbstractClassesChallenge
{
    public class Square : Rectangle
    {
        // Implement your Square Class here.
        int i;
        double Area;
        public double GetArea()
        {
            for (i = 0; i < LengthOfSides.Length; i++)

            {
                Area = LengthOfSides[i] * LengthOfSides[i];
            }
            return this.Area;

        }
            

    }
}
