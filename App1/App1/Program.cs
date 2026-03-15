// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("New feature!!");
Console.WriteLine("Second new feature!!");



Console.WriteLine("New main feature!");

//Zad2
public static class StatisticsHelper
{
    public static double Average(double a, double b)
    {
        return (a + b)/2;
    }
    public static double Divide(double a, double b)
    {
        try
        {
            return a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("ERROR: Division by zero!");
            return 0;
        }
    }
    public static string Concat(double a, string b)
    {
        string aStr = a.ToString();
        return aStr + " " + b;
    }
    public static int PowerOfTwo(int a)
    {
        int c = 2;
        for (int b = 0; b != a; b++)
        {
            c *= 2;
        }

        if (a == 0)
        {
            c /= 2;
        }
        return c;
    }

    public static double CalculateAverage(int[] values)
    {
        if (values.Length == 0)
        {
            Console.WriteLine("ERROR: Empty array!");
            return 0;
        }
        double sum = 0.0;
        foreach (int value in values)
        {
            sum += value;
        }
        return sum / values.Length;
    }
    public static double CalculateMax(int[] values)
    {
        if (values.Length == 0)
        {
            Console.WriteLine("ERROR: Empty array!");
            return 0;
        }
        int max = values[0];
        foreach (int value in values)
        {
            if (value > max)
            {
                max = value;
            }
        }
        return max;
    }
    public static double CalculateMaxSecond(int[] values)
    {
        if (values.Length == 0)
        {
            Console.WriteLine("ERROR: Empty array!");
            return 0;
        }
        int max = values[0];
        foreach (int value in values)
        {
            if (value > max)
            {
                max = value;
            }
        }
        return max;
    }
    public static double CalculateMin(int[] values)
    {
        if (values.Length == 0)
        {
            Console.WriteLine("ERROR: Empty array!");
            return 0;
        }
        int min = values[0];
        foreach (int value in values)
        {
            if (value < min)
            {
                min = value;
            }
        }
        Console.WriteLine("Finished!");
        return min;
    }
    //This is where conficts begin...
    public static void ConflictMaker(int[] values)
    {
        Console.WriteLine("This message is common in both branches!!");
    }
}