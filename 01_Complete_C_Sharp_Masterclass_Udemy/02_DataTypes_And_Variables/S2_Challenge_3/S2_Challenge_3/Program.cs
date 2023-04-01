using System;

namespace S2_Challenge_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 25;
            Console.WriteLine(myByte);
            sbyte mySbyte = -15;
            Console.WriteLine(mySbyte);
            int myInt = -123456;
            Console.WriteLine(myInt);
            uint myUint = 123456;
            Console.WriteLine(myUint);
            short myShort = -12345;
            Console.WriteLine(myShort);
            float myFloat = -123.22f;
            Console.WriteLine(myFloat);
            double myDouble = 12.312321;
            Console.WriteLine(myDouble);
            char myChar = 'A';
            Console.WriteLine(myChar);
            bool myBool = false;
            Console.WriteLine(myBool);
            string myText = "I control text";
            Console.WriteLine(myText);
            string numText = "15";
            Console.WriteLine($"{int.Parse(numText)}");
            Console.ReadLine();
            
        }
    }
}
