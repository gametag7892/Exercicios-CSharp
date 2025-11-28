using System;


public class Animal
{
    public string nome;

    public void EmitirSom()
    {
        Console.WriteLine("Som genérico do animal");
    }
}

public class Cachorro : Animal
{
    public new void EmitirSom()
    {
        Console.WriteLine("Au au au");
    }
}

class Program
{
    static void Main()
    {
        Cachorro cachorro = new Cachorro();
        cachorro.nome = "Baby";
        Console.WriteLine(cachorro.nome);
        cachorro.EmitirSom();
    }
}