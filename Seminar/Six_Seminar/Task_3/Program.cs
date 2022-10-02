Console.Clear();
Console.Write("Введите число для перевода: ");
int a = Convert.ToInt32(Console.ReadLine());
string b="";
while(a>0)
{
    b=Convert.ToString(a%2)+b;
    a=a/2;
}
Console.WriteLine($"Получилось в двоичном коде: {b}");
