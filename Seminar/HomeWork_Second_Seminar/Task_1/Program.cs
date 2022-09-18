// See https://aka.ms/new-console-template for more information
Console.Clear();
string a = Convert.ToString(new Random().Next(100,1000));
Console.Write("Число выбрано - "+a+",а результат - ");
Console.WriteLine(a[1]);