using System; 
using System.Drawing;

namespace OOP_PolymorphismL7;
class Program
{
    static void Main(string[] args)
    {
        Geometry[] Areas = new Geometry[5];

        Areas[0] = new RectangleGeometry(2, 3);
        Areas[1] = new SquareGeometry(2);
        Areas[2] = new CircleGeometry(4);
        Areas[3] = new Paralllogram(3, 4);
        Areas[4] = new newEllipse(9, 2);

        foreach (Geometry Area in Areas)
        {
                Console.WriteLine($"Area: {Area.geometricArea()}");
         
        }


        Console.ReadLine();
    }
    
}


