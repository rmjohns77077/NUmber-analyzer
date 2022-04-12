public class Program
{
    public static void Main()
    {
        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        Console.WriteLine($"Hello, " + name + " please pick a number between 1 and 100");
        var num = Console.ReadLine();
        int i = int.Parse(num);

        if (i < 60 && i % 2 != 0)
        {
            Console.WriteLine(name + " your number is less than 60 and odd.");
        }
        else if (i < 60 && i % 2 == 0)
        {
            Console.WriteLine(name + " your number is less than than 60 and even.");
        }
        else if (i > 60 && i % 2 != 0)
        {
            Console.WriteLine(name + " your number is greater than 60 and odd.");
            //ryan
        }
        else if (i < 60 && i % 2 == 0)
        {
            Console.WriteLine(name + " your number is less than 60 and even.");
        }
        bool condition = true;
        if (i >= 2 && i <= 24 && i % 2 == 0)
        {
            Console.WriteLine(name + " your number is less than 25 and even.");

        }
        else if(i >=26 && i <=60 && i % 2 == 0 )
            Console.WriteLine(name + " your number is even and in the inclusive range of 26 to 60 ");
    }
}


