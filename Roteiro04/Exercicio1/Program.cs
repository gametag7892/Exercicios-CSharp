using System;

public class Pagamento
{
    public virtual void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento");
    }
}

public class CartaoCredito : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento no cartão de Crédito");
    }
}

public class BoletoBancario : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento no Boleto Bancário");
    }

}

public class Pix : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento no PIX");
    }

}

class Program
{
    static void Main()
    {

        List<Pagamento> listaDePagamentos = new List<Pagamento>();

        listaDePagamentos.Add(new CartaoCredito());
        listaDePagamentos.Add(new BoletoBancario());
        listaDePagamentos.Add(new Pix());

        int i = 1;

        foreach (var pagamento in listaDePagamentos)
        {
            pagamento.ProcessarPagamento();
            i++;
        }
    }
}