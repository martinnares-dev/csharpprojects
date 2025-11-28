namespace ConsoleApp1. TypesInC;

enum Status :byte // byte, short, int, long & sbyte, unshort, uint, ulong
{
    Alive =1, //0 if Alive =1 Injured =2 UnAlive =3
    Injured, //1
    UnAlive, //2
}

public class EnumLesson
{
    static void Main(string[] args)
    {
        Status player = Status.Alive;
        switch (player)
        {
            case Status.Alive:
            //Do Alive Code
            System.Console.WriteLine($"the player status is {player}");
            break;

            case Status.Injured:
            //Do Injured Code
            System.Console.WriteLine($"the player status is {player}");
            break;

            case Status.UnAlive:
            //Do Unlive Code
            System.Console.WriteLine($"the player status is {player}");
            break;
        }
        System.Console.WriteLine((int)Status.UnAlive);
    }
}