Console.Clear();
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 100);
}
int Poisk(int[] array)
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
       if(array[i]>=10 && array[i]<=99)
       count++;
    }
    return count;
}

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("");
Console.Write($"Кол-во элементов массива от 10 до 99: {Poisk(array)}");