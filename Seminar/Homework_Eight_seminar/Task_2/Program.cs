/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
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

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("===================================");
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.WriteLine("===================================");
int sum=0;
int min=1000;
int n_min=0;
for (n = 0; n < matrix.GetLength(0); n++)
    {
        for (m = 0; m < matrix.GetLength(1); m++)
        {
            sum=sum+matrix[n,m];
        }
        if(sum<min)
            {
                min=sum;
                n_min=n;
            }
        Console.WriteLine($"Cумма в {n+1}-ой строке - {sum}");
        sum=0;
    }
    Console.WriteLine("===================================");
    Console.WriteLine($"Минимальная сумма в {n_min+1}-ой строке.");