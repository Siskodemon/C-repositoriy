Console.Clear();
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11);
}
void Proizvedenie(int[] array)
{
    Console.Write("Результат: ");
        for (int i = 0; i < array.Length/2+array.Length%2; i++)
        Console.Write(array[i]*array[array.Length-(1+i)]+" ");
}

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("");
Proizvedenie(array);