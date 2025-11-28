using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Qual é seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Qual é a data e hora de um compromisso no formato dd/MM/yyyy HH:mm: ");
        string dataInput = Console.ReadLine();

        DateTime dataCompromisso = DateTime.ParseExact(dataInput, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture); // Data compromisso
        TimeSpan diferenca = dataCompromisso - DateTime.Now;                                                         // Dias restantes 
        string diaDaSemana = dataCompromisso.ToString("dddd", new CultureInfo("pt-BR"));                             // Dia da semana para PT-br

        
        int diaRestantes = (int)Math.Ceiling(diferenca.TotalDays);                                                   // Arredondamento (Não existe fração de dias)

        string horaCompromisso = dataCompromisso.ToString("HH:mm");                                                  // Horário marcado

        string mensagem = string.Format("Olá {0}!\nSeu compromisso será em {1} dia(s), na {2}.\nData marcada: {3:dd/MM/yyyy} às {4:HH:mm}", nome, diaRestantes ,diaDaSemana, dataCompromisso, horaCompromisso);
        Console.WriteLine(mensagem);
    }
}