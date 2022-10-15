/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
Console.Clear();
int Rec(int chislo)
{
if(chislo/10==0)
{
    return(chislo);
}else
return Rec(chislo/10)+chislo%10;
}
Console.Write("Введите число от: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(Rec(n));
