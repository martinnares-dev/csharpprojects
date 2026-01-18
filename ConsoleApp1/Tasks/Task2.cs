namespace ConsoleApp1.Tasks;

class Task2
{
        static void Main(string[] args)
    {
        int[][] numberMatrix = new int[][]
    {
        new int[] { 2, 4, 6, 8, 10 },
        new int[] { 1, 3, 5, 7, 9 }
    };
    Console.WriteLine("The number matrix has been initialized.");
    //Digit 1 The number at Row 1, Index 3.
    //Digit 2 The number at Row 0, Index 0.
    //Digit 3 The number at Row 1, Index 4.
    int Digit1 = numberMatrix[1][3];
    int Digit2 = numberMatrix[0][0];
    int Digit3 = numberMatrix[1][4];
    string password = "";
    password+=Digit1;
    password+=Digit2;
    password+=Digit3;
    System.Console.WriteLine("The password is: "+ password );
    }
}


