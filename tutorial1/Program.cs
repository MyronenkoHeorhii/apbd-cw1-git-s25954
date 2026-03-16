// See https://aka.ms/new-console-template for more information

namespace tutorial1;
    
public class MyClass
{
    public static void Main()
    {
        CheckNumber();
        //Console.WriteLine("Hello, World!");
        Console.WriteLine("Average: " + CalculateAverage(new []{1, 2, 3, 4, 5}));
        
    }

    public static void CheckNumber()
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
        //catch ()
        
    }

    public static int CalculateAverage(int[] values)
    {
        int sum = 0;
        foreach(int x in values){
            sum += x;
        }
        return sum / values.Length;
    }

    public static int CalculateMax(int[] values)
    {
        int max = values[0];

        foreach (var x in values)
        {
            if (x > max)
            {
                max = x;
            }
        }
        return max;
    }

    public static int CalculateMin(int[] values)
    {
        Console.WriteLine("Calculating minimum...");
        int minValue = values[0];
        int minResult = values[0];
        foreach (var x in values)
        {
            if (x < minResult)
            {
                minResult = x;
            }
        }
        return minResult;
    }
}


