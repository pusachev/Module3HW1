// See https://aka.ms/new-console-template for more information

using Module3HW1.Collection;
using Module3HW1.Comparer;

GenericList<int> list = new GenericList<int>(2);

list.Add(33);
list.Add(22);
list.Add(2);
list.Add(0);
list.Add(10);
list.Add(15);

foreach (var item in list)
{
    Console.WriteLine($"item is {item}");
}

list.AddRange(new int[3] { 129, 45, 8 });

list.Sort();

Console.WriteLine("\n\n\n");

foreach (var item in list)
{
    Console.WriteLine($"item is {item}");
}

Console.WriteLine("\n\n\n");

list.Sort(new ReverseIntComparer());

foreach (var item in list)
{
    Console.WriteLine($"item is {item}");
}

Console.ReadLine();