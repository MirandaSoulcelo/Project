using System.Globalization;
using Order;
using System.Collections.Generic;


List<Product> list = new List<Product>();

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product #{i} data: ");
    Console.Write("Common, used or imported (c/u/i)? ");
    char ch = char.Parse(Console.ReadLine());
    Console.Write("What is the product name? ");
    string name = Console.ReadLine();
    Console.Write("Product Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if(ch == 'u' || ch == 'U')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateOnly manuDate = DateOnly.Parse(Console.ReadLine());
        list.Add(new UsedProduct(name, price, manuDate));
        Console.WriteLine();
    }

    else if(ch == 'i'|| ch =='I')
    {
        Console.Write("Customs Fee: ");
        double customsFee = double.Parse(Console.ReadLine());
        list.Add(new ImportedProduct(name, price, customsFee));
         Console.WriteLine();
    }

    else
    {
        list.Add(new Product(name, price));
         Console.WriteLine();
    }
}


Console.WriteLine();

foreach(Product prod in list)
{
    Console.WriteLine("Price Tags: ");
    Console.WriteLine(prod.PriceTag());
}

Console.ReadKey();