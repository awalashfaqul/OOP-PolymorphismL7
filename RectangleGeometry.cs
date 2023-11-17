using System;

namespace OOP_PolymorphismL7
{
    class Rectangle : Geometry
    {
        // properties of rectangle
        public double rectLen { get; set; }
        public double rectWid { get; set; }

        // constructor to construct rectangle object
        public Rectangle(double lenGth, double wiDth)
        {
            rectLen = lenGth;
            rectWid = wiDth;
        }

        // method to calculate area, which will be overrided from parent Geometry
        public override double geometricArea()
        {
            double rectArea;
            return rectArea = rectLen * rectWid;
        }
    }
}

