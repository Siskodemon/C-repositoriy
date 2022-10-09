Console.Clear();
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-9, 10);
            Console.Write(matrix[i, j] + " \t");
        }
    Console.WriteLine();
    }
}
void Trans(int[,] matrix)
{
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0)/2; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            k=matrix[i,j];
            matrix[i,j]=matrix[(matrix.GetLength(0)-1)-i,j];
            matrix[(matrix.GetLength(0)-1)-i,j]=k;
        }
    }
}
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("=========================");
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Trans(matrix);
Console.WriteLine("=========================");
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " \t");
        }
    Console.WriteLine();
    }
Console.WriteLine("=========================");