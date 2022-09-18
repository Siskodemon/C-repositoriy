// See https://aka.ms/new-console-template for more information
int n = new Random().Next(10,99);
    Console.WriteLine("Выбрано число "+n);
int n1 = n/10;
int n2 = n%10;
if(n1>n2)
    Console.WriteLine("Большее число "+n1);
else
    Console.WriteLine("Большее число "+n2);