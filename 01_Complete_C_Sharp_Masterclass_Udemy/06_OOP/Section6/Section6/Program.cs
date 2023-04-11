using System;

namespace Section6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create an object of my class
            // an instance of Human
            Human weiZhen = new Human("Lim","Wei Zhen","Green",25);

            // call methods of the class
            weiZhen.IntroductMyself();

            Human zaiYi = new Human("Lim", "Zai Yi", "Blue", 100);
            zaiYi.IntroductMyself();
        }
    }
}
