Console.Clear();
Console.Write("Введите количеством элементов массива: ");
int kol = Convert.ToInt32(Console.ReadLine());
int[] array = new int[kol];
Console.Write("Вводим массив самомстоятельно(y/n): ");
if(Console.ReadLine() == "y"){
    for(int i=0;i<kol;i++){
        Console.Write($"Введите {i}-ый элемент массива: ");
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
}else
     for(int i=0;i<kol;i++){
        array[i]=new Random().Next(1,1000);
     }
Console.Write($"Полученный массив - ["+string.Join(",",array)+"]");
   