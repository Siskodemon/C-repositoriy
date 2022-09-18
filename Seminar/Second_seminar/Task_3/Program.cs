// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a%b==0)
 Console.WriteLine("Число "+ b + " кратно числу "+ a);
 else
 Console.WriteLine("Число "+ b + " не кратно числу "+ a + ". Остаток равен "+ a%b);