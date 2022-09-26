Console.Clear();
Console.Write("Введите число: ");
string i = Console.ReadLine();
int l = i.Length;
int chislo = Convert.ToInt32(i);
  Console.WriteLine($"Число знаков - {l}.");
     while(l>=1)
if(chislo%10 == chislo/Convert.ToInt32(Math.Pow(10,l-1))){
    Console.WriteLine($"===================================================");
    Console.WriteLine($"Первый символ - {(chislo/Convert.ToInt32(Math.Pow(10,l-1)))}.");
    Console.WriteLine($"Последний символ - {chislo%10}.");
    chislo=(chislo-chislo/Convert.ToInt32(Math.Pow(10,l-1))*Convert.ToInt32(Math.Pow(10,l-1)))/10;
    Console.WriteLine($"Получилось число {chislo}, колчичество знаков {l-2}");
    if(l==3){
        Console.WriteLine($"===================================================");
        Console.WriteLine($"Число {i} является полиндромом.");
        break;
    }else
    l=l-2;
}
else{
    Console.WriteLine($"===================================================");
    Console.WriteLine($"Первый символ - {(chislo/Convert.ToInt32(Math.Pow(10,l-1)))}.");
    Console.WriteLine($"Последний символ - {chislo%10}.");
    Console.Write($"Число {i} не является полиндромом.");
    break;
}
