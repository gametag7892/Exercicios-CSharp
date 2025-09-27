using System;

public class Item
{
    public string nomeItem;
}
public class Pedido
{
    public Item item;

    public Pedido()
    {
        item = new Item();
    }

    public void pedirItem()
    {
        item.nomeItem = "Prato";
        Console.WriteLine("Quero um " + item.nomeItem);
    }
}

class Program
{
    static void Main()
    {
        Pedido pedido = new Pedido();
        pedido.pedirItem();
    }
}