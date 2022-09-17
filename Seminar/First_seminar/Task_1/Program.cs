// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if(b*b==a){
    Console.WriteLine(a+" являеться квадратом числа "+b);
}else{
    Console.WriteLine(a+" не являеться квадратом числа "+b);
}
