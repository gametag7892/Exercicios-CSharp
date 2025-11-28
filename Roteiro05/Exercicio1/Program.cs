using System;

class Program
{
    static void Main()
    {
        decimal num = decimal.Parse(Console.ReadLine());

        Console.WriteLine(num);
        Console.WriteLine(Math.Round(num));
        Console.WriteLine(Math.Floor(num));
        Console.WriteLine(Math.Ceiling(num));
        Console.WriteLine(Math.Truncate(num));
    }
}