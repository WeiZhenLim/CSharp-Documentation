using System;
using System.ComponentModel;

namespace S4_Challenge2
{
    internal class Program
    {
        static int highScore = 100;
        static string highscorePlayer = "Lim Wei Zhen";
        static void Main(string[] args)
        {
            checkScore(90,"A");
            checkScore(101,"B");
            checkScore(200, "C");
            checkScore(300, "Lim Wei Zhen");
            checkScore(100, "D");
            Console.Read();
        }

        public static void checkScore(int score, string playerName)
        {
            if (score > highScore)
            {
                highScore = score;
                highscorePlayer = playerName;

                Console.WriteLine($"New highscore is {score}");
                Console.WriteLine($"New highscore holder is {playerName}");
            }
            else
            {
                Console.WriteLine($"The old highscore of {highScore} could not be broken and is still " +
                    $"held by {highscorePlayer}");
            }

        }
    }
}
