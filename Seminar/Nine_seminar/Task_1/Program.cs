/*Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/
Console.Clear();
string Rec(int chislo1, int chislo2)
{
if(chislo1!=chislo2)
{
    return($"{chislo1}, {Rec(chislo1+1,chislo2)}");
}else
return $"{chislo2}";
}
Console.Write("Введите число от: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число до: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"{Rec(n,m)}");
