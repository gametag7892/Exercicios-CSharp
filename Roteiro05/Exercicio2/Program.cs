using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma frase com espaços no inicio e no fim e com palavras separadas por virgulas: ");
        string frase = Console.ReadLine();

        Console.WriteLine(frase.Trim());
        Console.WriteLine($"Parte 1: { frase.Split(',')[0]} | Parte 2: {frase.Split(',')[1]}");
        Console.WriteLine(frase.Replace("Dia", "Tarde"));
        Console.WriteLine(frase.StartsWith("Dia"));
        Console.WriteLine(frase.EndsWith("feliz!"));
    }
}