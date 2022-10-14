/*Задача 59: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.*/
Console.Clear();
int a = 0;
int b = 0;
int InputMatrix(int[,] matrix)
{
    int min=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 100);
            if(i==0 && j==0)
            min = matrix[0,0];
            if(matrix[i,j]<min)
            {
                min=matrix[i,j];
                a=i;
                b=j;
            }
            
            Console.Write(matrix[i, j] + " \t");
        }
    Console.WriteLine();
    }
    Console.WriteLine($"Минимальное значение : {min}");
    Console.WriteLine($"Минимальное значение находится в {a+1}-ой строке {b+1}-го столбца");
    return(min);
}
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
int min = InputMatrix(matrix);
int[,] matrix2 = new int[n-1, m-1];
m=0;
n=0;
for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        if(n==a)
        n++;
        for (int j = 0; j < matrix2.GetLength(1); j++)
        { 
            if(m==b)
            m++;
            matrix2[i,j]=matrix[n,m];
            Console.Write(matrix2[i, j] + " \t");  
            m++; 
        }
        Console.WriteLine();
        n++;
        m=0;
    }