using System;
using System.Security.Cryptography.X509Certificates;


public class Pessoa
{
    public string Nome;
    public int Idade;
    public string Cargo;

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos. Meu cargo é {Cargo}.");
    }

    public void Salario()
    {
        if (Cargo == "Gerente") Console.WriteLine("Gerente: 10000");
        else if (Cargo == "Desenvolvedor") Console.WriteLine("Desenvolvedor: 500"); 
        else Console.WriteLine("Estagiario: 100");
    }
}

public class Fantasma
{
    public string Habilidade;
    public string Nick;
    public string Cor;

    public void GerarFantasma()
    {
        Console.WriteLine($"Fantasma {Nick} gerado! Habilidade: {Habilidade}, Cor: {Cor}.");
    }

    public void Mover(String direction)
    {
        Console.WriteLine($"O fantasma {Nick} moveu para {direction}");
    }
}

public class Program
{
    public static void Main()
    {
        Pessoa p1 = new();
        Pessoa p2 = new();
        Pessoa p3 = new();

        Fantasma f = new();

        f.Nick = "Suzy";
        f.Cor = "Rosa";
        f.Habilidade = "Atravessar paredes";

        p1.Idade = 30;
        p1.Nome = "Joao";
        p1.Cargo = "Gerente";

        p2.Idade = 30;
        p2.Nome = "Daher";
        p2.Cargo = "Desenvolvedor";

        p3.Idade = 30;
        p3.Nome = "Lino";
        p3.Cargo = "Estagiário";

        p1.Apresentar();
        p2.Apresentar();
        p3.Apresentar();

        Console.WriteLine();

        p1.Salario();
        p2.Salario();
        p3.Salario();

        f.GerarFantasma();
        f.Mover("Esquerda");
    }

}
