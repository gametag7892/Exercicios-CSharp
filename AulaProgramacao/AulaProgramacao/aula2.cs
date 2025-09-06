using System;
using System.Diagnostics;
using System.Xml.Linq;

public class Produto
{
	private string _nome;
	private decimal _preco;

	public string Nome {
		get { return _nome; } 
	}

	public decimal Preco {
		get { return _preco; }

		set
		{
			if (_preco > 0)
			{
				_preco = value;
			}
		}
	}

	public Produto(string name, decimal price) 
	{
		_nome = name;
		_preco = price;

	}

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Preço: {Preco}");

    }

}

public class aula2
{
	public static void Main()
	{
		Produto p = new Produto("Celular", 1500);
		p.ExibirDetalhes();
		p.Preco = -200;
	}
}
