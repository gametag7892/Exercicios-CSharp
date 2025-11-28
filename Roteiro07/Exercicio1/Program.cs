using System;

class Program
{
    public static void Main()
    {
        List<string> listaDeCompra = new List<string>();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("1 - Adicionar\n2 - Remover\n3 - Listar\n4 - Sair");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Clear();
                Console.Write("Digite o nome do item que deseja Adicionar: ");
                string item = Console.ReadLine();
                listaDeCompra.Add(item);
            }

            if (opcao == 2)
            {
                Console.Clear();
                Console.Write("Digite o nome do item que deseja remover: ");
                string item = Console.ReadLine();
                for (int i = 0; i < listaDeCompra.Count; i++)
                {
                    string verificacao = listaDeCompra[i].ToString().ToLower();
                    if (item.ToLower() == verificacao) listaDeCompra.Remove(item);
                } 
            }

            if (opcao == 3)
            {
                Console.Clear();
                for (int i = 0; i < listaDeCompra.Count; i++)
                {
                    Console.WriteLine($"Item {i + 1} - {listaDeCompra[i]}");
                }
            }

            if (opcao == 4)
            {
                break;
            }
        }
    }
}