Console.Clear();
Console.Write("Введите число : ");
int a = Convert.ToInt16(Console.ReadLine());
int resalt = 1;
for(int i=2;i<=a;i++)
resalt=resalt*i;
Console.WriteLine($"Факториал числа {a} - {resalt}");

