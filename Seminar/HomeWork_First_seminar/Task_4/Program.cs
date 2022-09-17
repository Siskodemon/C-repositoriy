// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Последовательность чисел: ");
if(a%2==0)
    for(int i=2;i<=a;i=i+2)
    Console.Write(i+" ");
     else{
        for(int i=2;i<a;i=i+2)
        Console.Write(i+" ");
     }
