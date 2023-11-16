using System;
namespace OOP_PolymorphismL7
{
	public class newEllipse: Geometry
	{

        // properties for ellipse
        public double semMajaxis { get; set; }
        public double semMinaxis { get; set; }


        // constructor to create ellipse object
        public newEllipse(double semmajAxis, double semminAxis)
        {
            semMajaxis = semmajAxis;
            semMinaxis = semminAxis;
        }


        // method to calculate area of the ellipse, where the area method
        // is overriden from parent Geometry
        public override double geometricArea()
        {
            return Math.PI * semMajaxis * semMinaxis;
        }
    }
}

