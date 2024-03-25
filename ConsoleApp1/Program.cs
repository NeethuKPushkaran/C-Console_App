// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public  void Add(double X)
    {
        X++;
        Console.WriteLine($"inside value: {X}");

    }

    public static void Main()
    {
        double number = 5;
        Program p1 = new Program();
        p1.Add(number);
        Console.WriteLine($"Outside Value: {number}");
    }
}


