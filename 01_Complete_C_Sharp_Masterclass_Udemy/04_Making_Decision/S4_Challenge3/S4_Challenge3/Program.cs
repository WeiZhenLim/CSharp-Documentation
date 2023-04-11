using System;

namespace S4_Challenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputTemperature = 0;
            string temperatureMessage = string.Empty;
            string inputValue = string.Empty;

            // takes input from console
            Console.WriteLine("Enter the current temperature : ");
            inputValue = Console.ReadLine();

            // validate the input as valid input integer value
            bool validTemperature = int.TryParse(inputValue, out inputTemperature);

            if (validTemperature)
            {
                temperatureMessage = inputTemperature <= 15 ? "it is too cold here" :
                    (inputTemperature >= 16 && inputTemperature <= 28) ? "it is cold here" :
                    inputTemperature >= 28 ? "it is hot here" : "";
                Console.WriteLine(temperatureMessage);
            }
            else
            {
                Console.WriteLine("Not a valid Temperature.");
            }
        }

    }
}
