using System;
using System.Data;
using System.Runtime.CompilerServices;


class Program
{
    static void Main()
    {
        string nomeProduto = Console.ReadLine();

        if (nomeProduto == "") throw new Exception("Nome do produto não pode estar em branco");

        double precoProduto = double.Parse(Console.ReadLine());

        if (precoProduto <= 0) throw new Exception("Preço não pode ser menor ou igual a zero");
    }
}
