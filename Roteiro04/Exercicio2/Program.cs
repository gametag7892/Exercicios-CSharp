using System;

abstract class Funcionario
{
    public string Nome { get; set; }
    public double SalarioBase { get; set; }

    public Funcionario(string nome, double salarioBase)
    {
        Nome = nome;
        SalarioBase = salarioBase;
    }

    public abstract double CalcularSalario();
}

class Gerente : Funcionario
{
    public double Bonus { get; set; }

    public Gerente(string nome, double salarioBase, double bonus)
        : base(nome, salarioBase)
    {
        Bonus = bonus;
    }

    public override double CalcularSalario()
    {
        return SalarioBase + Bonus;
    }
}

class Programador : Funcionario
{
    public int HorasExtras { get; set; }
    public double ValorHoraExtra { get; set; }

    public Programador(string nome, double salarioBase, int horasExtras, double valorHoraExtra)
        : base(nome, salarioBase)
    {
        HorasExtras = horasExtras;
        ValorHoraExtra = valorHoraExtra;
    }

    public override double CalcularSalario()
    {
        return SalarioBase + (HorasExtras * ValorHoraExtra);
    }
}

class Program
{
    static void Main()
    {
        Funcionario gerente = new Gerente("Carlos", 5000, 2000);
        Funcionario programador = new Programador("Ana", 4000, 10, 50);

        Console.WriteLine($"{gerente.Nome} - Salário: R$ {gerente.CalcularSalario()}");
        Console.WriteLine($"{programador.Nome} - Salário: R$ {programador.CalcularSalario()}");
    }
}