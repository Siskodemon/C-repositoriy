/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/
Console.Clear();
int Rec(int i,int j)
{
if(j!=0)
{
    return Rec(i,j-1)*i;
}else
return 1;
}
Console.Write("Введите число A: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(Rec(n,m));
