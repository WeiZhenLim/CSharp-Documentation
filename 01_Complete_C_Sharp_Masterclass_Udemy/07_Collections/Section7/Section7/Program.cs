namespace Section7
{
    internal class Program
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
}