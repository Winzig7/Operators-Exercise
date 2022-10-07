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


        var r = 20;
        var pi= Math.PI;
        var areaOfCirlce = pi * (r * r);
        Console.WriteLine($"The area of a cirlcle with the radius {r} is {areaOfCirlce}");
    }
}