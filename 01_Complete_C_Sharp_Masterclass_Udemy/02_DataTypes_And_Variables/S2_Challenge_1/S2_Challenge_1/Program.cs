using System;
using System.Diagnostics;

namespace S2_Challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.Write("Please enter your name and press enter:");
            input = Console.ReadLine();
            Console.WriteLine("Processing Output...");
            Console.WriteLine($"Uppercase:{input.ToUpper()}");
            Console.WriteLine($"Lowercase:{input.ToLower()}");
            Console.WriteLine($"Trimmed:{input.Trim()}");
            Console.Write("Staring index of Substring:");
            int startIndex = Int32.Parse(Console.ReadLine());
            Console.Write("Length of Substring:");
            int lenInput = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Substring:{input.Substring(startIndex,lenInput)}");
        }
    }
}
