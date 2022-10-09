int IsPrime(int N)
{
 if(N%2!=0 && N%3!=0 && N%5!=0 && N%7!=0 || N==2 || N==3 || N==5 || N==7)
 {
    return(N);
 }
 else
 return(0);
}
Console.Clear();
Console.Write("Введите количеством элементов массива: ");
int kol = Convert.ToInt32(Console.ReadLine());
int[] array = new int[kol];
Console.Write("Вводим числа в массив сами(y/n): ");
kol=0;
if (Console.ReadLine()=="y")
for(int i=0;i<array.Length;i++)
{
    Console.Write($"Введите {i+1}-ое число: ");
    array[i]=Convert.ToInt32(Console.ReadLine());
    if(array[i]==IsPrime(array[i]) && array[i]!=1 && array[i]!=0)
    kol=kol+array[i];
}
else
for(int i=0;i<array.Length;i++)
{
    array[i]=new Random().Next(2,100);
    if(array[i]==IsPrime(array[i]) && array[i]!=1 && array[i]!=0)
    kol=kol+array[i];
}

Console.WriteLine("=====================================================");
Console.WriteLine($"Получился массив - [{string.Join(", ",array)}]");
Console.WriteLine($"Сумма простых чисел в массиве: {kol}");
Console.WriteLine("=====================================================");

   