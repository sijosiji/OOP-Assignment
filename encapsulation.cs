using System;

namespace Encapsulation
{
    class Painter 
    {
        private string Name;
        private string Artist;
        private string Medium;
        private int Year;
        public string MyName {
            get 
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public string MyArtist {
            get 
            {
                return Artist;
            }
            set
            {
                Artist = value;
            }
        }
        public string MyMedium {
            get 
            {
                return Medium;
            }
            set
            {
                Medium = value;
            }
        }
        public int MyYear {
            get 
            {
                return Year;
            }
            set
            {
                Year = value;
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Painter myPainter = new Painter();

            myPainter.MyName = "Sijo";
            myPainter.MyArtist = "Jacob";
            myPainter.MyMedium = "Newspaper";
            myPainter.MyYear = 2016;
            Console.WriteLine("Name: " + myPainter.MyName);
            Console.WriteLine("Artist: " + myPainter.MyArtist);
            Console.WriteLine("Medium: " + myPainter.MyMedium);
            Console.WriteLine("Year: " + myPainter.MyYear);
        }
    }
}