namespace ConsoleApp1 
{
class Program 
{
	static void Main(string[] args)
	{
		Console.WriteLine("Wellcome Devs");
        int age  = 26;
		Console.WriteLine("my age is" + age);
        float cent = 0.76F;
        double price = 21.09;
        char letter = '!';
        byte p = 1; //0-255
        long trillions = 9999999999;
        Console.WriteLine("Price is" + price);
        string name = "Martin";
        bool isRunning = true;
        Console.WriteLine(name + isRunning);
        // Console.WriteLine(1 == isRunning);
        string _fullName = "";
        Console.WriteLine("10 + 3 = " + 10 + 3);
        Console.WriteLine("10 - 3 = " + (10 - 3));
        Console.WriteLine("10 * 3 = " + 10 * 3);
        Console.WriteLine("10 / 3 = " + 10 / 3);
        Console.WriteLine("10 % 3 = " + 10 % 3);
        Console.WriteLine("10 < 3 =" + (10 < 3));
        Console.WriteLine("10 > 3 =" + (10 > 3));
        Console.WriteLine("1 <= 1 =" + (1 <= 1));
        Console.WriteLine("3 >= 3 =" + (3 >= 3));
        Console.WriteLine("1 == 1 =" + (1 == 1));
        Console.WriteLine("2 != 3 =" + (2 != 3));

        Console.WriteLine("true && true =" + (true && true));
        Console.WriteLine("false && true =" + (false && true));
        Console.WriteLine("true && false =" + (true && false));
        Console.WriteLine("false && false =" + (false && false));
        
        Console.WriteLine("true || true =" + (true || true));
        Console.WriteLine("false || true =" + (false || true));
        Console.WriteLine("true || false =" + (true || false));
        Console.WriteLine("false || false =" + (false || false));

        Console.WriteLine("!true = " + !true);
        Console.WriteLine("!false = " + !false);
        Console.WriteLine("!(!false) = " + !(!false));

	}
}
}