using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("digite um número:");
            string numero = Console.ReadLine();
            int toInt = int.Parse(numero);
        }
        catch
        {
            Console.WriteLine("Valor invalido. Por favor, digite um número inteiro");
        }
    }
}