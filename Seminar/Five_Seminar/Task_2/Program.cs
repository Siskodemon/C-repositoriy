Console.Clear();
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}
void Poisk(int[] array)
{
    int buf = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            for (int j = i; j < array.Length; j++)
                if (array[j] > 0)
                        { 
                           buf=array[i];
                           array[i]=array[j];
                           array[j]=buf;
                           break;
                        }  
        
    }
}

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Poisk(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");

