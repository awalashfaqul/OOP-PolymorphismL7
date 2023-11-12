using System;

namespace OOP_PolymorphismL7
{
    class RectangleGeometry : Geometry
    {
        // properties of rectangle
        public double L { get; set; }
        public double W { get; set; }

        // constructor to construct rectangle object
        public RectangleGeometry(double length, double width)
        {
            L = length;
            W = width;
        }

        // method to calculate area, which will be overrided from parent Geometry
        public override double area()
        {
            return L * W;
        }
    }
}

