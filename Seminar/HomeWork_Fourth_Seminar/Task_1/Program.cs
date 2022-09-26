// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите число A: ");
int  a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int  b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {a} в степени {b} - {Math.Pow(a,b)}");
