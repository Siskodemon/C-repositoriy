/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.Clear();
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write(matrix[i, j] + " \t");
        }
    Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("================================");
int[,] matrix1 = new int[n, m];
InputMatrix(matrix1);
Console.WriteLine("================================");
Console.Write("Введите кол-во строк: ");
n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("================================");
int[,] matrix2 = new int[n, m];
InputMatrix(matrix2);
Console.WriteLine("================================");
if(matrix1.GetLength(1)!=matrix2.GetLength(0))
Console.WriteLine("Произведение двух матриц возможно только если число столбцов 1-ой матрицы совпадает с числом строк 2-ой матрицы.");
else
{
    int[,] matrix3 = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
    int sum=0;
    for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (n = 0; n < matrix2.GetLength(1); n++)
            {
                for (m = 0; m < matrix1.GetLength(1); m++)
                {
                    sum=sum+matrix1[i,m]*matrix2[m,n];
                }
                matrix3[i,n]=sum;
                sum=0;
            }
        }
Console.WriteLine("Произведение 2-х матриц: ");
Console.WriteLine("================================");  
        for (n = 0; n < matrix3.GetLength(0); n++)
    {
        for (m = 0; m < matrix3.GetLength(1); m++)
        {
            Console.Write(matrix3[n, m] + " \t");
        }
        Console.WriteLine();
    }
}

