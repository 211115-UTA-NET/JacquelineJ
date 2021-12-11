using System;

namespace AbstractClassesChallenge
{
    public class Triangle : Shape
    {
            // Implement your Triangle class here.
            // HINT: Use Herons Formula to calculate and set the area.
             
            //Array[] sidesArray = new Array[3];
            double S;
            double a;
            double b;
            double c;
            double mul;
            
            public override double GetArea()
            {
            Console.WriteLine("Enter sides of the Triangle");
            //sidesArray[] = Console.ReadLine();
            //a = sidesArray[0];
            //b = sidesArray[1];
            //c = sidesArray[2];

            a = Console.ReadLine();
            b = Console.ReadLine();
            c= Console.ReadLine();
            S = (a + b+c)/2;
            mul = S * ((S - a) * (S - b) * (S - c));
            Area = sqrt(mul);
           
            return this.Area;
    
            }

    }    
    
}
