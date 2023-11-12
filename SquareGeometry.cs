using System;
namespace OOP_PolymorphismL7
{
    class SquareGeometry : Geometry
    {
        // properties of square
        public double Length { get; set; }
        public double Width { get; set; }
        public double AngleDegree { get; set; }



        //constructor to create square object
        public SquareGeometry(double length, double width, double angledegree)
        {
            Length = length;
            Width = width;
            AngleDegree = angledegree;
        }

        // method to calculate area, overriden from parent Geometry
        public override double area()
        {
            double angleRadian = AngleDegree * (Math.PI/180);
            double squareArea;

            if (Length != Width || AngleDegree != 90)
            { 
                Console.WriteLine("Sorry! It is not a Square, as length and width are not same.");
                return 0.0;
            }

            return squareArea = Length * Width * Math.Sin(angleRadian);
        }
    }
}

