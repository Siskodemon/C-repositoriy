// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите персое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = a-b;
switch (c){
    case (>0): Console.WriteLine(a+" больше чем "+b);
    break;
    case (<0): Console.WriteLine(b+" больше чем "+a);
    break;
    case (0): Console.WriteLine("Числа равны друг другу");
    break;
}