using System;
using System.Diagnostics;
using System.Xml.Linq;

public class Elevador
{
    private int andarAtual;
    private int totalAndares;

    public int AndarAtual
    {
        get { return andarAtual; }
        set
        {
            if (value < 0)
            {
                andarAtual = 0;
            }
            else if (value >= totalAndares)
            {
                andarAtual = totalAndares;
            }
            else
            {
                andarAtual = value;
            }
        }
    }

    public int TotalAndares
    {
        get { return totalAndares; }
    }

    public Elevador(int totalAndar)
    {
        totalAndares = totalAndar;
    }

    public void Subir()
    {
        AndarAtual += 1;
    }
    public void Descer()
    {
        AndarAtual -= 1;
    }

}
public class Program
{
    public static void Main()
    {
        Elevador e = new Elevador(10);
        e.Subir();
        e.Subir();
        Console.WriteLine(e.AndarAtual);
        e.Descer();
        Console.WriteLine(e.AndarAtual);
        e.Descer();
        e.Descer();
    }
}