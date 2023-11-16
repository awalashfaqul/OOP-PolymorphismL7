using System;
namespace OOP_PolymorphismL7
{
	public class Paralllogram : Geometry
	{
        // properties for parallelogram
        public double prlloBase { get; set; }
        public double prlloHeight { get; set; }


        // constructor to create object of parallelogram
        public Paralllogram(double @base, double height)
        {
            prlloBase = @base;
            prlloHeight = height;
        }

        /*
            method to calculate area of the parallelogram, where the area method
            is overriden from parent Geometry 
        */
        public override double geometricArea()
        {
            return prlloBase * prlloHeight;
        }
    }
}

