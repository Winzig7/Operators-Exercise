using System;
using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        var a = 17;
        var b = 4;
        var div = a / b;
        var mod = a % b;

        Console.WriteLine($"{a}/{b} is {div} remainder {mod}");


        var radius = double.Parse(Console.ReadLine());
        var areaOfCircle = CalculateArea(radius);
        Console.WriteLine($"The area of a circle with radius of {radius} is {areaOfCircle}");
    }
    public static double CalculateArea(double radius);
    {
    return Math.PI* ( radius* radius);
    }
}