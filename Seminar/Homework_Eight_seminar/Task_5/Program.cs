/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

Console.Clear();
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " \t");
        }
    Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("========================================");
int[,] matrix = new int[n, m];
int chislo=1;
int k=1;
int i=0;
int j=0;

for(j = 0;j<matrix.GetLength(1);j++)
{
    matrix[0,j]= chislo++;
}
for(i = 1;i<matrix.GetLength(0);i++)
{
    matrix[i,m-1]= chislo++;
}
for(j = m-2;j>=0;j--)
{
    matrix[n-1,j]= chislo++;
}

i=n-1;
j=0;
while(k>0)
{
    if(matrix[i-1,j]==0)
    {
        i--;
        while(matrix[i,j]==0)
        {
            matrix[i,j]=chislo++;
            i--;
        }
        i++;
    }
    else
    k=0;
    if(matrix[i,j+1]==0)
    {
        j++;
        while(matrix[i,j]==0)
        {
            matrix[i,j]=chislo++;
            j++;
        }
        j--;
    }
    else
    k=0;
    if(matrix[i+1,j]==0)
    {
        i++;
        while(matrix[i,j]==0)
        {
            matrix[i,j]=chislo++;
            i++;
        }
        i--;
    }
    else
    k=0;
    if(matrix[i,j-1]==0)
    {
        j--;
        while(matrix[i,j]==0)
        {
            matrix[i,j]=chislo++;
            j--;
        }
        j++;
    }
    else
    k=0;
}
InputMatrix(matrix);
Console.WriteLine("========================================");