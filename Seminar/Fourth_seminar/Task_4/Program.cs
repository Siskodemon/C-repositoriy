Console.Clear();
Console.Write("Введите число элементов массива: ");
int i = Convert.ToInt32(Console.ReadLine());
int [] array = new int[i];
for(i=0;i<array.Length;i++)
    array[i]= new Random().Next(0,2);
    i=0;
    Console.Write($"["+ string.Join(",",array) +"] ");
