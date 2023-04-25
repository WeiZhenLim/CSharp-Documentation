using System;
using System.Linq;

namespace S3_Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myFriend1 = "Lim";
            string myFriend2 = "Wei";
            string myFriend3 = "Zhen";

            GreetFriend(myFriend1);
            GreetFriend(myFriend2);
            GreetFriend(myFriend3);
            Console.Read();
        }

        private static void GreetFriend(string friendName)
        {
            string startGreet = "Hi ";
            string endGreet = ",my friend!";

            Console.WriteLine(startGreet + friendName + endGreet);

        }
    }
}
