using System;

namespace OOP_PolymorphismL7
{
	public class Geometry
	{
		/*public Geometry()
		{
		}*/

		public virtual double geometricArea()
        /*In OOP, when we mark a method (in a parent 
         * class) as virtual, we are indicating that this method can be 
         * overridden by child classes. The virtual keyword is used for method 
         * overriding, which is a fundamental concept in polymorphism and 
         * inheritance.*/
        {

            return 0.0;

		}
	}
}