using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            // create an object of my class
            // an instance of Human
            Human weiZhen = new Human("Lim", "Wei Zhen", "Green", 25);

            // call methods of the class
            weiZhen.IntroductMyself();

            Human zaiYi = new Human("Lim", "Zai Yi", "Blue", 100);
            zaiYi.IntroductMyself();
        }
    }

    internal class Program2
    {
        static void Main(String[] args)
        {
            Box box = new Box();
            box.SetLengt(4);
            box.Height = 4;
            box.Width = 5;
            Console.WriteLine($"Box length is {box.GetLength()}.");
            box.DisplayInfo();
            Console.WriteLine($"Front surface of the box is {box.FrontSurface}");

        }
    }

    internal class Program3
    {
        static void Main(String[] args)
        {
            Members member1 = new Members();
            member1.Introducing(true);
        }
    }
}
