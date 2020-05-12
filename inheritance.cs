using System;

namespace Inheritance
{
    class Group
    {
        public string groupName = "Oil Painter";
    }

    class Painter : Group
    {
        public string PainterName = "Sijo Jacob";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Painter newPainter = new Painter();
            Console.WriteLine("Painter " + newPainter.PainterName + " is a type of: " + newPainter.groupName);
        }
    }
}
