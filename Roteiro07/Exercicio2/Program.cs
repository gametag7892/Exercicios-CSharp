using System;
using System.Collections.Generic;

public class Programs
{
    public static void Main()
    {
        Dictionary<int, string> produtos = new Dictionary<int, string>();

        while (true)
        {
            
            Console.WriteLine("1 - Adicionar\n2 - Pesquisar\n3 - Listar\n4 - Sair");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Clear();
                Console.Write("Digite o código do produto que deseja Adicionar: ");
                int codigo = int.Parse(Console.ReadLine());

                Console.Clear();
                Console.Write("Digite o nome do produto que deseja Adicionar: ");
                string nome = Console.ReadLine();

                if (produtos.ContainsKey(codigo))
                {
                    Console.WriteLine($"O código {codigo} já está em uso: {produtos[codigo]}");
                }
                else
                {
                    produtos.Add(codigo, nome);
                    Console.WriteLine($"Produto '{nome}' ({codigo}) adicionado.");
                }

            }
            if (opcao == 2)
            {
                Console.Clear();
                Console.Write("Digite o código do produto que deseja Adicionar: ");
                int codigo = int.Parse(Console.ReadLine());

                if (produtos.TryGetValue(codigo, out string nome))
                {
                    Console.WriteLine($"Produto encontrado: {nome}");
                }
                else
                {
                    Console.WriteLine($"Produto com código {codigo} não encontrado.");
                }

            }
            if (opcao == 3)
            {
                Console.Clear();
                if (produtos.Count > 0)
                {
                    foreach (var item in produtos)
                    {
                        Console.WriteLine($"Cód: {item.Key} | Nome: {item.Value}");
                    }
                }
                else
                {
                    Console.WriteLine("Catálogo vazio.");
                }
            }
            if (opcao == 4)
            {
                break;
            }
        }
    }
}