// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите делимое: ");
string a = Console.ReadLine();
Console.Write("Введите делитель: ");
string b = Console.ReadLine();
Console.Write("Результат деления равен - ");
Console.WriteLine(Convert.ToDouble(a)/Convert.ToDouble(b));
