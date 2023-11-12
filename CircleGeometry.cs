using System;
namespace OOP_PolymorphismL7
{
    class CircleGeometry : Geometry
    {
        // properties for circle
        public double Radius { get; set; }

        // constructor to create circle object
        public CircleGeometry(double radius)
        {
            Radius = radius;
        }

        // method to calculate area of the circle, where the area method
        // is overriden from parent Geometry
        public override double area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

