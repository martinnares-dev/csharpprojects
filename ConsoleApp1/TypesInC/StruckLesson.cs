using System.Diagnostics.Contracts;

namespace ConsoleApp1.TypesInC;

struct Vector
{
    public int x;

    public int y;

    public Vector(int a, int b)
    {
        x = a;
        x = b;
    }

}

public class StructLesson
{
    static void Main(string[] args)
    {
        Vector vector1 = new Vector();
        vector1.x = 10;
        vector1.y = 20;
        System.Console.WriteLine($"x = {vector1.x}");
        System.Console.WriteLine($"y = {vector1.y}");
    }
}