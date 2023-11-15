using System;
namespace OOP_PolymorphismL7
{
    class SquareGeometry : Geometry
    {
        /*  properties of square. We do not need length and width here, because
            the arms of the square is having same length, and that's the special
            property of a square. And the agnle between the arms are 90 degree).
            So here we will go with one special property: side arm.
        */

        public double sideArm { get; set; }
        

        //constructor to create square object
        public SquareGeometry(double sidArm)
        {
            sideArm = sidArm;
        }

        // method to calculate area, overriden from parent Geometry
        public override double geometricArea()
        {
            double squareArea;
            return squareArea = sideArm * sideArm;
        }
    }
}

