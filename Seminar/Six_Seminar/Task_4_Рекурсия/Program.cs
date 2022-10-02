Console.Clear();
string f(int n)
{
    if (n == 0)
        return "";
    return f(n / 2) + Convert.ToString(n % 2);
}


Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));
