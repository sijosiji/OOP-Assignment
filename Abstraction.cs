using System;

namespace Abstraction
{
    abstract class HiddenMessage
    {
        public void myHiddenMessage()
        {
            Console.WriteLine("Only Visible to Acrylic Painting Media!");
        }
    }

    class VisibleMessage : HiddenMessage
    {
        public void myVisibleMessage()
        {
            Console.WriteLine("Visible to all Painter!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            VisibleMessage myVibMsg = new VisibleMessage();
            myVibMsg.myVisibleMessage();
            myVibMsg.myHiddenMessage();
        }
    }
}
