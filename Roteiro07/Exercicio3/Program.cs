using System;
using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        HashSet<int> numerosUnicos = new HashSet<int>();
        int entrada;

        Console.WriteLine("Digite números inteiros (0 para parar):");

        while (true)
        {
            Console.Write("> ");
            if (!int.TryParse(Console.ReadLine(), out entrada))
            {
                Console.WriteLine("Entrada inválida.");
                continue;
            }

            if (entrada == 0)
                break;

            numerosUnicos.Add(entrada);
        }

        Console.WriteLine("\n--- Números Únicos Digitados ---");
        if (numerosUnicos.Count > 0)
        {
            var numerosExibicao = numerosUnicos.OrderBy(n => n);
            Console.WriteLine(string.Join(", ", numerosExibicao));
        }
        else
        {
            Console.WriteLine("Nenhum número único digitado.");
        }
    }
}