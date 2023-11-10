using System;

namespace OOP_PolymorphismL7
{
    class RectangleGeometry : Geometry
    {
        public double L { get; set; }
        public double W { get; set; }

        public RectangleGeometry(double length, double width)
        {
            L = length;
            W = width;
        }

        public override double area()
        {
            return L * W;
        }
    }
}

