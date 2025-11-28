using System;

public interface IVeiculo
{
    void Mover();
}

public class Carro : IVeiculo
{
    public void Mover()
    {
        Console.WriteLine("O carro está se movendo.");
    }
}

public class Bicicleta : IVeiculo
{
    public void Mover()
    {
        Console.WriteLine("A bicicleta está se movendo.");
    }
}

class Program
{
    static void Main()
    {
        Carro carro = new Carro();
        Bicicleta bicicleta = new Bicicleta();

        carro.Mover();
        bicicleta.Mover();
    }
}