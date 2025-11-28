using System;

class Program
{
    static void Main()
    {
        try
        {
            string celsius = Console.ReadLine();
            float toFloat = float.Parse(celsius);
            Console.WriteLine($"Celsius:{toFloat}");
        }
        catch (FormatException e) 
        {
            Console.WriteLine($"Ocorreu um erro ao converter: {e}");
        }
       
    }
}