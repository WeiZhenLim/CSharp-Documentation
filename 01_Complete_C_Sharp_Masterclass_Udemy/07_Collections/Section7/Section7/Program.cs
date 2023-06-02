using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace Section7
{
    internal class Program // array 
    {
        static void Main(string[] args)
        {
            // initialise the array by assigning the array size
            int[] grades = new int[5];
            grades[0] = 20;
            grades[1] = 15;

            Console.WriteLine("grades at index 0 : {0}", grades[0]);

            // initialise the array by directly assiging it to a list
            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            // weird way of initialise an array
            int[] gradesOfMathStudentsB = new int[] { 20, 13, 12, 8, 9 };
        }
    }

    internal class Program1 // for each loop
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 10;
            }

            int counter = 0;
            foreach (int i in nums)
            {
                Console.WriteLine("Element {0} = {1}", counter, i);
                counter++;
            }
        }
    }

    internal class Program2 // smol challenge
    {
        static void Main(string[] args)
        {
            // Create an array with 5 of your best friends
            string[] friends = { "Jason Ha", "Lim Zai Yi", "Wong Han Woon", "Chang Zi Fong", "Henry Lee" };

            foreach (string friend in friends)
            {
                Console.WriteLine("Hi {0}", friend);
            }
        }
    }

    internal class Challenge1 // foreach loops and switch statement
    {
        static void Main(string[] args)
        {
            bool valid = false;
            string inputValueType;

            // take input value
            Console.Write("Enter a value: ");
            string input = Console.ReadLine();

            // ask for the data type of the input value
            Console.Write("Select the Data type to validate the input you have entered.\n" +
                "Press 1 for String\n" + "Press 2 for Integer\n" + "Press 3 for Boolean\n" + "Your answer is : ");
            int dataType = Int32.Parse(Console.ReadLine());

            switch (dataType)
            {
                case 1: // check for String
                    valid = IsAllAlphabetic(input);
                    inputValueType = "String";
                    break;
                case 2: // check for Integer
                    int retValue = 0;
                    valid = int.TryParse(input, out retValue);
                    inputValueType = "Integer";
                    break;
                case 3: // check for Boolean
                    bool retBool = false;
                    valid = bool.TryParse(input, out retBool);
                    inputValueType = "Boolean";
                    break;
                default:
                    inputValueType = "unknown";
                    Console.WriteLine("Not able to detect input wrong, something is wrong.");
                    break;
            }

            Console.WriteLine("You have entered a value : {0}", input);
            if (valid)
            {
                Console.WriteLine("It is valid : {0}", inputValueType);
            }
            else
            {
                Console.WriteLine("It is an invalid : {0}", inputValueType);
            }
        }

        /// <summary>
        /// function to check if the input string is a pure letter string.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static bool IsAllAlphabetic(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                    return false;
            }

            return true;
        }
    }

    internal class Program3 // multidimensional array
    {
        static void Main(string[] args)
        {
            // declare 2D array
            string[,] matrix;

            // 3D array
            int[,,] threeD;

            // two dimensional array
            int[,] array2D = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine("Central value is {0}", array2D[1, 1]);

            // three dimensional array
            int[,,] array3D = new int[,,]
            {
                {
                    {1,2,3 },
                    { 4, 5, 6 }
                },
                {
                    {7, 8, 9 },
                    {10, 11, 12}
                }
            };

            int dimension = array2D.Rank; // number of dimension
        }
    }

    internal class Program4 // nested loops and 2D array
    {
        static int[,] matrix =
        {
            {1,2,3,4},
            {5,6,7,8},
            {9,10,11,12}
        };

        static void Main(string[] args)
        {
            foreach (int item in matrix)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nThis is our 2D array printed using nested for loop");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0;j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]%2==0)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
            }
        }
    }

    internal class TicTacToe
    {
        /// <summary>
        /// main program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int moves; // input from player
            int player; // player number (Odd = player 1, Even = player 2)
            string[,] board; // tic tac toe board
            bool win = false; // if there are winner
            int maxRound = 9; // max number of round
            string gameEndRespond; // respond when game end
            Dictionary<int, int[]> moveSetsDict;

            RestartGame:

            board = CreateEmptyBoard(); // reset/empty board
            moveSetsDict = CreateDict(); // create moveDict

            for (int i = 1; i <= maxRound; i++)
            {
                ShowBoard(board);
                if (i%2 != 0) // odd = player 1
                {
                    player = 1;

                    Console.WriteLine("Player {0}: Choose your field!", player);
                    int.TryParse(Console.ReadLine(), out moves); // Store moves
                    WriteBoard(player, moves, moveSetsDict, board);  
                }
                else
                {
                    player = 2;
                    Console.WriteLine("Player {0}: Choose your field!", player);
                    int.TryParse(Console.ReadLine(), out moves); // Store moves
                    WriteBoard(player, moves, moveSetsDict, board);
                }

                if (i >=3) // only check when there are more than 3 moves
                {
                    win = Checker(board);

                    if (win)
                    {
                        Console.Clear();
                        ShowBoard(board);
                        Console.WriteLine("Player {0} wins.", player);
                        goto ExitLoop;
                    }
                }
                Console.Clear();
            }
            ExitLoop:
            Console.WriteLine("Game Ended. Press R to restart or press any key to exit the game.");
            gameEndRespond = Console.ReadLine();
            if (gameEndRespond.ToUpper() == "R")
            {
                Console.Clear();
                goto RestartGame;
            }
        }

        /// <summary>
        /// initialize emptyBoard
        /// </summary>
        /// <returns></returns>
        static string[,] CreateEmptyBoard()
        {
            string[,] emptyBoard = new string[,] // empty board
            {
                {"1","2","3"},
                {"4","5","6"},
                {"7","8","9"}
            };

            return emptyBoard;
        }

        /// <summary>
        /// initialize movesets
        /// </summary>
        static Dictionary<int, int[]> CreateDict()
        {
            int moveCounter = 1;
            Dictionary<int, int[]> moveDict = new Dictionary<int, int[]>();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    moveDict.Add(moveCounter, new int[] {i,j});
                    moveCounter++;
                }
            }
            return moveDict;
        }

        /// <summary>
        /// write on board based on player's move
        /// </summary>
        /// <param name="player"></param>
        /// <param name="moves"></param>
        /// <param name="board"></param>
        public static void WriteBoard(int player, int moves, Dictionary<int,int[]> moveDict, string[,] board)
        {
            int row;
            int col;

            switch (player)
            {
                case 1: // use "X"
                    try
                    {
                        row = moveDict[moves][0];
                        col = moveDict[moves][1];
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid Input. Try Again");
                        break;
                    }

                    if (board[row,col] != "X" && board[row,col] != "O")
                    {
                        board[row, col] = "X"; 
                    }

                    break;

                case 2: // use "O"
                    try
                    {
                        row = moveDict[moves][0];
                        col = moveDict[moves][1];
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid Input. Try Again.");
                        break;
                    }

                    if (board[row, col] != "X" && board[row, col] != "O")
                    {
                        board[row, col] = "O";
                    }

                    break;
            }
        }

        /// <summary>
        /// to print out the board
        /// </summary>
        /// <param name="board"></param>
        public static void ShowBoard(string[,] board)
        {
            // create board
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[2, 0], board[2, 1], board[2, 2]);
            Console.WriteLine("     |     |     ");
        }

        /// <summary>
        /// check result, return true if winner is found, else return false
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        public static bool Checker(string[,] board)
        {
            // horizontal
            for(int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i,0] == board[i,1] && board[i,1] == board[i,2])
                {
                    return true;
                }
            }

            // vertical
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[0,j] == board[1,j] && board[1,j] == board[2,j])
                {
                    return true;
                }
            }

            // diagonal check 1
            if (board[0,0] == board[1,1] && board[1,1] == board[2,2])
            {
                return true;
            }

            // diagonal check 2
            if (board[0,2] == board[1,1] && board[1,1] == board[2,0])
            {
                return true;
            }

            return false;
        }
    }

    internal class Program5 // jagged array
    {
        static void Main(string[] args)
        {
            // declare jaggedArray
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] {1,2,3,4,5};
            jaggedArray[1] = new int[] {1, 2, 3 };
            jaggedArray[2] = new int[] { 1, 2 };

            // alternative way
            int[][] jaggedArray2 = new int[][]
            {
                new int[] {1,2,3,4,5 },
                new int[] {1,2,3},
                new int[] {1,2}
            };

            Console.WriteLine("The value in the middle of the first entry is {0}", jaggedArray2[0][2]);
        }
    }

    internal class JaggedArrayChallenge
    {
        static void Main(String[] args)
        {
            // create a jagged array, which contains 3 "friends arrays", in which two family members should be stored
            // intorduce family members from different families to each other via console

            string[][] jaggedArray = new string[][]
            {
                new string[] {"Zai Yi father", "Zai Yi mother"},
                new string[] {"Jason father", "Jason mother"},
                new string[] {"Henry father", "Henry mother"}
            };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine("Hi I am {0}", jaggedArray[i][j]);
                }
            }
        }
    }

    internal class ArrayAsParameters
    {
        static void Main(string[] args)
        {
            int[] studentGrades = new int[] { 15,13,14,16,18,20,11};
            double averageResult = GetAverage(studentGrades);

            Console.WriteLine("The average score is {0}.",averageResult);
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }

            average = (double)sum/size;
            return average;
        }
    }

    internal class ArrayAsParametersChallenge
    {
        // Create an array of happiness in the main method and assign 5 values to it
        // Create a method which has an array of type int as its parameter
        // This method should increase the argument given by 2, for each entry
        // Call this method in the main method and use "happiness" as the argument
        // Create a foreach loop in the main method to write all values onto the console
        static void Main(String[] args)
        {
            int[] happiness = new int[] { 4, 6, 8, 10, 7 };

            // rescale happiness
            int[] rescaleHappiness = AddHappiness(happiness);

            // print rescaleHappiness
            foreach (var item in rescaleHappiness)
            {
                Console.WriteLine("The rescale happiness index are {0}.",item);
            }

        }

        static int[] AddHappiness(int[] happinessArray)
        {
            for (int i = 0; i < happinessArray.Length; i++)
            {
                happinessArray[i] += 2; 
            }

            return happinessArray;
        }
    }
}