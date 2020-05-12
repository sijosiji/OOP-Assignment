using System;

namespace Polymorphism
{
    class Painter
    {
        public virtual void paint()
        {
            Console.WriteLine("Painter Types");
        }
    }

    class Acrylic : Painter
    {
        public override void paint()
        {
            Console.WriteLine("Acrylic Painting Media");
        }
    }

    class Watercolor : Painter
    {
        public override void paint()
        {
            Console.WriteLine("Watercolor Painting Media");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Painter myPainter = new Painter();
            Painter myAcrylic = new Acrylic();
            Painter myWatercolor = new Watercolor();

            myPainter.paint();
            myAcrylic.paint();
            myWatercolor.paint();
        }
    }
}
