# Composite
Ідея компонувальника: 

дозволяє працювати з окремими елементами та групами однаково.

Як працює код: 

Букет — це колекція квітів, але ми можемо додавати й виводити їх єдиним способом.
Патерн корисний, коли потрібно будувати ієрархічні структури — наприклад, букет -> квіти -> пелюстки.

Навіщо: 

можна створювати складні структури й поводитися з ними як з одним об’єктом.

## Код
```csharp
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

```
## Результат
![Результат виконання](sc8.png)
