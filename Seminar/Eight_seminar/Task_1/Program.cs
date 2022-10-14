/***Задача 55:** Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

В итоге получается вот такой массив:

1 5 8 5

4 9 4 2

7 2 2 6

2 3 4 7
*/
Console.Clear();
void InputMatrix(int[,] matrix)
{
    Console.WriteLine("Изначальный массив: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-99,101);
            Console.Write(matrix[i, j] + " \t");
        }
    Console.WriteLine();
    }
}
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("===========================!");
if(n!=m)
Console.WriteLine("Заменав не возможна!!!Кол-во строк не равно кол-ву столбцов!");
else
{
    int[,] matrix = new int[n, m];
    InputMatrix(matrix);
    Console.WriteLine("===========================!");
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <= i; j++)
        {
            k=matrix[i, j];
            matrix[i,j]=matrix[j,i];
            matrix[j,i]=k;
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " \t");
        }
    Console.WriteLine();
    }
}