using System;
using System.Collections.Generic;

class Bouquet
{
    private List<string> flowers = new List<string>();

    public void Add(string flower) => flowers.Add(flower);
    public void Show()
    {
        Console.WriteLine("Букет містить:");
        foreach (var f in flowers) Console.WriteLine(" - " + f);
    }
}

class Program
{
    static void Main()
    {
        var bouquet = new Bouquet();
        bouquet.Add("Троянда ");
        bouquet.Add("Тюльпан ");
        bouquet.Add("Ромашка ");

        bouquet.Show();
    }
}








