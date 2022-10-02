Console.Clear();
Console.Write("Введите количеством элементов массива: ");
int kol = Convert.ToInt32(Console.ReadLine());
double[] array = new double[kol];
double max = 0;
array[0] = Math.Round(new Random().NextDouble()*100,2);
double min = array[0];
for(int i=1;i<kol;i++){
    array[i]=Math.Round(new Random().NextDouble()*100,2);
    if(array[i]>max)
    max=array[i];
    if(array[i]<min)
    min=array[i];
}
Console.WriteLine($"Полученный массив - ["+string.Join(" ; ",array)+"]");
Console.WriteLine($"Разница максимального числа массива {max} и минимального числа {min} - {max-min}");
   