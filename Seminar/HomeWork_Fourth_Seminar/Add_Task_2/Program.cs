Console.Clear();
Console.Write("Введите количество цифр: ");
int kol = Convert.ToInt32(Console.ReadLine());
int[] array = new int[kol];
     for(int i=0;i<kol;i++)
        array[i]=new Random().Next(1,10);
Console.WriteLine($"Получилась следующая последовательность цифр - ["+string.Join(",",array)+"]");
Console.Write("Введите число К: ");
int k = Convert.ToInt32(Console.ReadLine());
int j=0;
int buf=0;
if(k!=0 && k<0){
    Console.WriteLine($"Число отрицательное!");
    for(int index=1;index<Math.Sqrt(k*k)+1;index++){
        buf=array[0];
        j=0;
        while(j<kol-1){
            array[j]=array[j+1];
            j++;
        }
        array[kol-1]=buf;
        Console.WriteLine($"Шаг {index}-ый - ["+string.Join(",",array)+"]");
    }
}else
if(k!=0 && k>0){
      Console.WriteLine($"Число положительное");
 for(int index=1;index<k+1;index++){
        buf=array[kol-1];
        j=kol-1;
        while(j>0){
            array[j]=array[j-1];
            j--;
        }
        array[0]=buf;
        Console.WriteLine($"Шаг {index}-ый - ["+string.Join(",",array)+"]");
    }
}
Console.WriteLine("====================================================================");
Console.WriteLine($"Результат - ["+string.Join(",",array)+"]");
Console.WriteLine("====================================================================");