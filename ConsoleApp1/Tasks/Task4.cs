namespace ConsoleApp1.Tasks;

class Task4
{
    public static float AddTwoNums (float a, float b)
    {
        return a+b;
    }
    public static float SubTwoNums (float a, float b)
    {
        return a-b;
    }
    public static float MulTwoNums (float a, float b)
    {
        return a*b;
    }
    public static float DivTwoNums (float a, float b)
    {
        return a/b;
    }

    public static void ask()
    {
        System.Console.WriteLine("1 - Addition");
        System.Console.WriteLine("2 - Subtraction");
        System.Console.WriteLine("3 - Multipliation");
        System.Console.WriteLine("4 - Division");
        int option = 0;
        option= int.Parse(Console.ReadLine());
        System.Console.Write("Enter value 1: ");
        float val1 = int.Parse(Console.ReadLine());
        System.Console.Write("Enter value 2: ");
        float val2 = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1: System.Console.WriteLine($"{val1} + {val2} = {AddTwoNums(val1,val2)}");
            break;
            case 2: System.Console.WriteLine($"{val1} - {val2} = {SubTwoNums(val1,val2)}");
            break;
            case 3: System.Console.WriteLine($"{val1} * {val2} = {MulTwoNums(val1,val2)}");
            break;
            case 4: System.Console.WriteLine($"{val1} / {val2} {DivTwoNums(val1,val2)}");
            break;
            default: System.Console.WriteLine("Enter a valid option");
            break;
        }
    }
    static void Main(string[] args)
    {
         bool repeat = true;
         while(repeat)
        {
            ask();
            System.Console.WriteLine("Do you want to continue again (Y/N)?");
            string continueProg = Console.ReadLine();
            if (continueProg.ToUpper().Equals("N"))
            {
                repeat = true;
            }
            else
            {
                repeat = false;
            }
        }
         
    }
}