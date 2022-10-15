/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Clear();
int Rec(int i,int j)
{
    if(i>0 && j>0)
        return Rec(i-1,Rec(i,j-1));
    else
    if(i>0 && j==0)
        return Rec(i - 1, 1);
    else
    if(i==0)
    return j+1;
    else
    return 0;

}
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Результат выполнения функции Аккермана с параметрами {m} и {n} - ");
Console.Write(Rec(m,n));
