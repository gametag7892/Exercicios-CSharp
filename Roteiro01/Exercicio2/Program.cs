using System;
using System.Security.Cryptography.X509Certificates;

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

        Fantasma f = new();

        f.Nick = "Suzy";
        f.Cor = "Rosa";
        f.Habilidade = "Atravessar paredes";

        f.GerarFantasma();
        f.Mover("Esquerda");
    }

}
