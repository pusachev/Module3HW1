// See https://aka.ms/new-console-template for more information

using Module3HW1.Collection;

GenericList<int> list2 = new GenericList<int>(2);

list2.Add(0);
list2.Add(1);
list2.Add(2);
list2.Add(0);
list2.Add(10);
list2.Add(15);

foreach (var item in list2)
{
    Console.WriteLine($"item is {item}");
}

Console.ReadLine();