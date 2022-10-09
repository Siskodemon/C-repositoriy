Console.Clear();
int InputMatrix(int[,] matrix)
{
    int sum=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write(matrix[i, j] + " \t");
            if(i==j)
            sum=sum+matrix[i, j];
        }
    Console.WriteLine();
    }
    return(sum);
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
int k = InputMatrix(matrix);
Console.Write($"Сумма элементов по главной диагонали: {k}");
