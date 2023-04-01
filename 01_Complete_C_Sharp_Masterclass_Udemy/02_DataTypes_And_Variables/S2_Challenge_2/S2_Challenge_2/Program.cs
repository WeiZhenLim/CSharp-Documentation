using System;

namespace S2_Challenge_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string here: ");
            string input = Console.ReadLine();
            Console.Write("Enter a character to search: ");
            char inputChar = Console.ReadLine()[0];
            Console.WriteLine($"The index of the first occurrence is {input.IndexOf(inputChar)}.");

            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Your full name is {firstName} {lastName}.");
        }
    }
}
