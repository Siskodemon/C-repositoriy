// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a%7==0 && a%23==0)
 Console.WriteLine("Число "+ a + " кратно 7 и 23");
 else
 Console.WriteLine("Число "+ a + " не кратно числу 7 и 23");