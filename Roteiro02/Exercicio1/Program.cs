using System;
using System.Diagnostics;
using System.Xml.Linq;

public class Produto
{
    private string nome;
    private decimal preco;

    public string Nome
    {
        get { return nome; }
    }

    public decimal Preco
    {
        get { return preco; }

        set
        {
            if (value > 0)
            {
                preco = value;
            }
        }
    }

    public Produto(string name, decimal price)
    {
        nome = name;
        preco = price;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Preço: {Preco}");
    }

}
public class Program
{
    public static void Main()
    {
        Produto p = new Produto("Celular", 1500);
        p.ExibirDetalhes();
        p.Preco = -200;
    }
}
