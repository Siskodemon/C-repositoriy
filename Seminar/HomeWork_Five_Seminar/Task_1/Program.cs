Console.Clear();
Console.Write("Введите количеством элементов массива: ");
int kol = Convert.ToInt32(Console.ReadLine());
int[] array = new int[kol];
int count = 0;
for(int i=0;i<kol;i++){
    array[i]=new Random().Next(100,1000);
    if(array[i]%2==0)
    count++;
}
Console.WriteLine($"Полученный массив - ["+string.Join(",",array)+"]");
Console.WriteLine($"Кол-во чётных чисел в массиве - {count}");

   