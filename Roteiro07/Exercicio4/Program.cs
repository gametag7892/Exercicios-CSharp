using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Queue<string> fila = new Queue<string>();
        string escolha;

        do
        {
            Console.WriteLine("\n--- Fila de Atendimento ---");
            Console.WriteLine($"3. Clientes na fila: {fila.Count}");
            Console.WriteLine("1. Adicionar Cliente | 2. Atender Próximo | 4. Sair");
            Console.Write("Opção: ");
            escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Console.Write("Nome do cliente: ");
                    string nome = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(nome))
                    {
                        fila.Enqueue(nome);
                        Console.WriteLine($"'{nome}' entrou na fila.");
                    }
                    break;

                case "2":
                    if (fila.Count > 0)
                    {
                        string clienteAtendido = fila.Dequeue();
                        Console.WriteLine($"*** Cliente atendido: {clienteAtendido} ***");
                    }
                    else
                    {
                        Console.WriteLine("Fila vazia. Nenhum cliente para atender.");
                    }
                    break;

                case "3":
                    Console.WriteLine($"Clientes esperando: {fila.Count}");
                    break;

                case "4":
                    Console.WriteLine("Encerrando a simulação.");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (escolha != "4");
    }
}
