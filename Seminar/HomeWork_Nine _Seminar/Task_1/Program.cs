/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Clear();
int Rec(int i,int j)
{
if(i!=j)
{
    return Rec(i+1,j)+i;
}else
return 0;
}
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма элементов от {m} до {n} - ");
Console.Write(Rec(Math.Min(m,n),Math.Max(m,n)));
