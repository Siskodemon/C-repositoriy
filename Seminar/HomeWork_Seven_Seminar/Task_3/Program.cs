Console.Clear();
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write(matrix[i, j] + " \t");
        }
    Console.WriteLine();
    }
}
void average(int[,] matrix)
{
    Console.WriteLine("====================================");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum=0;
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
           sum=sum+matrix[i, j];
           if(i==matrix.GetLength(0)-1)
           {
            Console.WriteLine($"Среднее арифметическое {j+1}-го столбца: {sum/matrix.GetLength(0)}");
            Console.WriteLine("====================================");
           }
        }
    }
}
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("====================================");
int[,] matrix = new int[n, m];
InputMatrix(matrix);
average(matrix);
