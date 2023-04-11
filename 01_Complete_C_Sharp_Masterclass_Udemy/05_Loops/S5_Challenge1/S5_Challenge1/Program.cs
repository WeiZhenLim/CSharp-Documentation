using System;

namespace S5_Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string scoreInput;
            double totalScore = 0;
            double numOfStudent = 0;
            double avgScore;

            while (true)
            {
                Console.WriteLine("Please Enter Student's Score (Enter -1 To Exit): ");
                scoreInput = Console.ReadLine();

                // check for number entry
                if (!double.TryParse(scoreInput, out double scoreInputAsInt))
                {
                    Console.WriteLine("Please Enter A Valid Number.\n" +
                        "---------------------------------------------------------------------------------------------------------------");
                    continue;
                }
                // check if number entered is -1
                else if (scoreInputAsInt == -1)
                {
                    Console.WriteLine("Exit Program.");
                    break;
                }
                // check entry range
                else if (scoreInputAsInt >= 0 & scoreInputAsInt <= 20)
                {
                    totalScore += scoreInputAsInt;
                    numOfStudent++;
                    avgScore = totalScore / numOfStudent;
                    Console.WriteLine($"Total Number of Input : {numOfStudent}\nTotal Score : {totalScore.ToString("0.00")}\n" +
                        $"Average Score : {avgScore.ToString("0.00")}");
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("Value Out Of Range. Please Enter A Value Between 0 And 20.\n" +
                        "---------------------------------------------------------------------------------------------------------------");
                    continue;
                }
            }
        }
    }
}
