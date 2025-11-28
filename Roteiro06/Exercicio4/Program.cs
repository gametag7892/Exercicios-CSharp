using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Digite a idade: ");
        int idade = int.Parse(Console.ReadLine());

        if (idade < 18)
        {
            throw new IdadeInvalidaException("Erro: Idade minima para acesso é de 18 anos");
        }
        else
        {
            Console.WriteLine("Acesso permitido");
        }

    }
}

public class IdadeInvalidaException : Exception
{
    public IdadeInvalidaException(string message) : base(message) { }
}