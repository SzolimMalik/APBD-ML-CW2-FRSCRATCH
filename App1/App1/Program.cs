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
    
}