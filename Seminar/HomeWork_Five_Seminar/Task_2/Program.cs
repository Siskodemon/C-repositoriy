Console.Clear();
Console.Write("Введите количеством элементов массива: ");
int kol = Convert.ToInt32(Console.ReadLine());
int[] array = new int[kol];
int count = 0;
for(int i=0;i<kol;i++){
    array[i]=new Random().Next(-99,100);
    if(i%2!=0)
    count=count+array[i];
}
Console.WriteLine($"Полученный массив - ["+string.Join(",",array)+"]");
Console.WriteLine($"сумма чисел на нечётных позициях - {count}");

   