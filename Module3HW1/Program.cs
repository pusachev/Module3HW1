// See https://aka.ms/new-console-template for more information

using Module3HW1.Collection;

GenericList<int> list = new GenericList<int>(2);

for (int i = 0; i < 10; i++)
{
    list.Add(i);
}

list.Delete(3);

Console.ReadLine();