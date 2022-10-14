/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
Console.Clear();
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
            Console.Write(matrix[i, j] + " \t");
        }
    Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"===================================");
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.WriteLine($"===================================");
int max = 0;
for (n = 0; n< matrix.GetLength(0); n++)
    {
        int k = 0;
        int m1=0;
        while(k<matrix.GetLength(1))
        {
          max=matrix[n,k];
          m1=k;
          for (m = k; m < matrix.GetLength(1); m++)
              if(matrix[n,m]>max)
              {
                max=matrix[n,m];
                m1=m;
              }
           matrix[n,m1]=matrix[n,k];
           matrix[n,k]=max;
           k++;
        }
    }
     for (n = 0; n < matrix.GetLength(0); n++)
    {
        for (m = 0; m < matrix.GetLength(1); m++)
        {
            Console.Write(matrix[n, m] + " \t");
        }
    Console.WriteLine();
    }
    Console.WriteLine($"===================================");