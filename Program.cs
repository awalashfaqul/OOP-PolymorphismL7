using System; 
using System.Drawing;

namespace OOP_PolymorphismL7;
class Program
{
    static void Main(string[] args)
    {
        Geometry[] Areas = new Geometry[5];

        Areas[0] = new Rectangle(2, 3);
        Areas[1] = new Square(2);
        Areas[2] = new Circle(4);
        Areas[3] = new Paralllogram(3, 4);
        Areas[4] = new Ellipse(9, 2);

        foreach (Geometry Area in Areas)
        {
                Console.WriteLine($"{Area.GetType().Name} Area: {Area.geometricArea()}");
            
        }


        Console.ReadLine();
    }
    
}


