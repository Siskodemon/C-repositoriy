Console.Clear();
void InputMatrix(int[,] matrix)
{
      for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-100,101);
            Console.Write(matrix[i, j] + " \t");
        }
    Console.WriteLine();
    }
}
void InputIndex(int [,] matrix) 
{
    Console.WriteLine("========================================");
    Console.Write("Введите номер строк: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if(n>matrix.GetLength(0))
    {
        Console.WriteLine("Строки под таким номером в массиве нет... Попробуй снова...");
        InputIndex(matrix);
    }
    else
    {
        Console.Write("Введите номер столбцов: ");
        int m = Convert.ToInt32(Console.ReadLine());
        if(m>matrix.GetLength(1))
        {
            Console.WriteLine("Столбца под таким номером в массиве нет...");
            InputIndex(matrix);
        }
        else
        Console.WriteLine("========================================");
        Console.WriteLine($"Значение массива в {n}-ой строке {m}-го столбца : {matrix[n-1,m-1]}");
        Console.WriteLine("========================================");
    }
}
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("========================================");
int k=0;
int[,] matrix = new int[n, m];
InputMatrix(matrix);
InputIndex(matrix);