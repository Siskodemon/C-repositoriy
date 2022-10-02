Console.Clear();
Console.Write("Введите число для перевода: ");
int a = Convert.ToInt32(Console.ReadLine());
int c=0;
int i=1;
string b="";
while(c<=a)
{
    b=b+" "+Convert.ToString(c)+Convert.ToString(i);
    c++;
    i++;
}
Console.WriteLine($"Получилось: {b}");
