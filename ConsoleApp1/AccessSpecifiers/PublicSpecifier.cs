namespace ConsoleApp1.AccessSpecifiers;

public class PublicSpecifier
{
    static void Main(string[] args)
    {
        AccessPublic ap1 = new AccessPublic();
        ap1.Method();
    }
}

public class AccessPublic
{
    public int publicCode = 21434;
    public void Method ()
    {
        Console.WriteLine("Public Method");
    }
}