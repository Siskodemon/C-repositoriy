Console.Clear();
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 100);
}
void Poisk(int[] array)
{
    Console.Write("Введите число для поиска: ");
    int buf = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.Length; i++)
    {
       if(array[i]==buf)
       {
        Console.Write($"Число присутствует в массиве на {i+1}-ом месте");
        break;
       }
       else
       if(i==array.Length-1)
       Console.Write($"Число отсутствует");
    }
}

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Poisk(array);