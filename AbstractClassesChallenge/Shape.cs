using System;

namespace AbstractClassesChallenge
{
    abstract public class Shape
    {
        public string Name { get; set; } = "";
        public int NumSides { get; set; } = 0;
        public double[] LengthOfSides = new double[Numsides];
        public LengthOfSides{
            get { return LengthOfSides; }
            set { LengthOfSides = value;}}
           
        protected double area;
        
        protected double Area 
        { 
            get
            {
                return this.area;
            } 
            set
            {
                if(value > 0)
                    this.area = value;
            }
        }

        //You must only accept the length of the sides in the constructors along with the name and number of sides.
        // Constructor
        public Shape(string Name, int NumSides)
{
            this.Name = Name;
            this.NumSides = NumSides;
            
        }

        // This method returns the general information about the shape.
        public void GetInfo()
        {
            System.Console.WriteLine($"This {Name} has {NumSides} sides  and an area of {Area}");
        }

        // This method returns the area of the shape
        public double GetArea()
        {
            return this.Area;
        }
        
        // This method sets the Area of the shape
        protected abstract void SetArea();

    }
}
