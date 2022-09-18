// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второое число: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a*a==b || b*b==a)
 Console.WriteLine("Да являются");
 else
 Console.WriteLine("Нет не являются");