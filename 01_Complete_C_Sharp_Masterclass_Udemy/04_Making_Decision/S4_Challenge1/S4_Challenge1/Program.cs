using System;

namespace S4_Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string password;
            string verUserName;
            string verPassword;

            registerAgain:

            Console.WriteLine("New user, please enter your username for registration:");
            userName = Console.ReadLine().Trim();
            Console.WriteLine("Please enter your password:");
            password = Console.ReadLine().Trim();

            if (userName == "" || password == "")
            {
                Console.WriteLine("Empty username/password, please try again. \n" +
                    "-----------------------------------------------------------------------------------" +
                    "----------------------------------");
                goto registerAgain;
            }
            else
            {
                verAgain:

                Console.WriteLine("For verification purpose, please re-enter your username:");
                verUserName = Console.ReadLine();
                Console.WriteLine("Please re-enter your password:");
                verPassword = Console.ReadLine();

                if (verUserName != userName || verPassword != password)
                {
                    Console.WriteLine("Wrong username/password, please enter the correct username.");
                    goto verAgain;
                }
                else
                {
                    Console.WriteLine("You have successfully registered a new account. \n Welcome, " + userName);
                }
                
            }

            Console.ReadLine();
        }
    }
}
