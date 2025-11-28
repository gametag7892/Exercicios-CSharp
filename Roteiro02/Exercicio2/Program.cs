using System;
using System.Diagnostics;
using System.Xml.Linq;

public class Carro
{
    private string modelo;
    private int velocidadeAtual;

    public string Modelo
    {
        get { return modelo; }
    }

    public int VelocidadeAtual
    {
        private set
        {
            if (value <= 0)
            {
                velocidadeAtual = 0;
            }
            else
            {
                velocidadeAtual = value;
            }
        }

        get { return velocidadeAtual; }
    }

    public Carro(string model)
    {
        modelo = model;
    }

    public void Acelerar(int valor)
    {
        VelocidadeAtual += valor;
    }

    public void Frear(int valor)
    {
        VelocidadeAtual -= valor;
    }
}
public class Program
{
    public static void Main()
    {
        Carro c = new Carro("Corolla");
        c.Acelerar(50);
        Console.WriteLine(c.VelocidadeAtual);
        c.Frear(30);
        Console.WriteLine(c.VelocidadeAtual);
        c.Frear(50);
        Console.WriteLine(c.VelocidadeAtual);
    }
}