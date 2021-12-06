using System;

namespace AbstractClassesChallenge
{
    public class Triangle : Shape
    {
        // Implement your Triangle class here.
        // HINT: Use Herons Formula to calculate and set the area.
        double S;
        double a;
        double b;
        double c;
        double mul;
        double Area;

        public double GetArea()
        {
            
        a =  LengthOfSides;
        b = LengthOfSides[1];
        c = LengthOfSides[2];
        S = (a + b+c)/2;
        mul = S * ((S - a) * (S - b) * (S - c));
        Area = sqrt(mul);
       
            return this.Area;
        }




    }
}
