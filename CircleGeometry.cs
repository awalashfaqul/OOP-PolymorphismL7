using System;
namespace OOP_PolymorphismL7
{
    class CircleGeometry : Geometry
    {
        // properties for circle
        public double crclRadius { get; set; }

        // constructor to create circle object
        public CircleGeometry(double raDius)
        {
            crclRadius = raDius;
        }

        // method to calculate area of the circle, where the area method
        // is overriden from parent Geometry
        public override double geometricArea()
        {
            return Math.PI * crclRadius * crclRadius;
        }
    }
}

