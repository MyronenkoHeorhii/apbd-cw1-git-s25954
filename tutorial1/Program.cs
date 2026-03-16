// See https://aka.ms/new-console-template for more information

public class MyClass
{
    public static void Main()
    {
        checkNumber();
        Console.WriteLine("Hello, World!");
    }

    public static void checkNumber()
    {
        Console.WriteLine("Please enter a number: \n");
        string number = Console.ReadLine();
        try
        {
            if (Convert.ToInt32(number).GetType() == typeof(int))
            {
                Console.WriteLine("Thanks");
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine("not a number");
        }
        
    }
}


