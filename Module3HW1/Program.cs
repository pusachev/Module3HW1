// See https://aka.ms/new-console-template for more information

using Module3HW1.Collection;
using Module3HW1.Comparer;
using Module3HW1.Entity;
using Module3HW1.Factory;

GenericList<int> intList = new GenericList<int>();
GenericList<IProduct> products = new GenericList<IProduct>();
IProductFactory productFactory = new ProductFactory();

Random rnd = new Random();

Console.WriteLine("Fill int collection");

for (int i = 0; i < 10; i++)
{
    intList.Add(rnd.Next(1, 1000));
}

Console.WriteLine("The int collection filled");
Console.WriteLine("Count items in int collection {0}", intList.Count());

Console.WriteLine("\nFill proudct collection");

products.Add(productFactory.Create("Iphone 14 pro max", "iph14", 1599, 100));
products.Add(productFactory.Create("Samsung Galaxy Note 6", "smng6", 999.99m, 100));
products.Add(productFactory.Create("Xaomi Mi 20", "xm20", 599.80m, 100));

Console.WriteLine("Count items in product collection {0}", intList.Count());

Console.WriteLine("\nItems in int collection before add range: ");

foreach (int item in intList)
{
    Console.WriteLine("Int item: {0}", item);
}

Console.WriteLine("\nAdd range to int collection");

intList.AddRange(new int[3] { 5, 9, 77 });

Console.WriteLine("\nItems in int collection after added range: ");

foreach (int item in intList)
{
    Console.WriteLine("Int item: {0}", item);
}

Console.WriteLine("\nSort int collection by default comparer");

intList.Sort();

Console.WriteLine("\nItems after sorting: ");

foreach (int item in intList)
{
    Console.WriteLine("Int item: {0}", item);
}

Console.WriteLine("\nSort int collection by custom comparer");

intList.Sort(new ReverseIntComparer());

Console.WriteLine("Items after sorting: ");

foreach (int item in intList)
{
    Console.WriteLine("Int item: {0}", item);
}

Console.WriteLine("\nItems in product collection before add range: ");

foreach (IProduct item in products)
{
    Console.WriteLine("\nName: {0}", item.Name);
    Console.WriteLine("Sku: {0}", item.Sku);
    Console.WriteLine("Name: {0}", item.Price);
    Console.WriteLine("Qty: {0}", item.Qty);
}

Console.WriteLine("\nAdd range to product collection");

products.AddRange(
    new IProduct[2]
    {
        productFactory.Create("Nokia 3310", "nk33", 99, 20),
        productFactory.Create("Motorola Razer v5", "mtr5", 199, 25)
    });

Console.WriteLine("\nItems in product collection after added range: ");

foreach (IProduct item in products)
{
    Console.WriteLine("\nName: {0}", item.Name);
    Console.WriteLine("Sku: {0}", item.Sku);
    Console.WriteLine("Name: {0}", item.Price);
    Console.WriteLine("Qty: {0}", item.Qty);
}

Console.WriteLine("\nSort product collection by product name comparer");

products.Sort(new ProductNameComparer());

Console.WriteLine("\nItems after sorting: ");

foreach (IProduct item in products)
{
    Console.WriteLine("\nName: {0}", item.Name);
    Console.WriteLine("Sku: {0}", item.Sku);
    Console.WriteLine("Name: {0}", item.Price);
    Console.WriteLine("Qty: {0}", item.Qty);
}

Console.WriteLine("\nSort product collection by product price comparer");

products.Sort(new ProductPriceComparer());

Console.WriteLine("Items after sorting: ");

foreach (IProduct item in products)
{
    Console.WriteLine("\nName: {0}", item.Name);
    Console.WriteLine("Sku: {0}", item.Sku);
    Console.WriteLine("Name: {0}", item.Price);
    Console.WriteLine("Qty: {0}", item.Qty);
}

Console.ReadLine();