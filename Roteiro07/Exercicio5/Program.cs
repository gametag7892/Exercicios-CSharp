using System;
using System.Collections.Generic;
using System.Text;

public class InversorPalavrasSimples
{
    public static void Main(string[] args)
    {
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();

        if (string.IsNullOrEmpty(palavra)) return;

        Stack<char> pilha = new Stack<char>();

        foreach (char caractere in palavra)
        {
            pilha.Push(caractere);
        }

        StringBuilder palavraInvertida = new StringBuilder();

        while (pilha.Count > 0)
        {
            palavraInvertida.Append(pilha.Pop());
        }

        Console.WriteLine($"Original: **{palavra}**");
        Console.WriteLine($"Invertida: **{palavraInvertida.ToString()}**");
    }
}