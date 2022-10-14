// See https://aka.ms/new-console-template for more information
Console.Clear();
void InputMatrix(int[,,] matrix)
{
    int[] spisok = new int[matrix.GetLength(0)*matrix.GetLength(1)*matrix.GetLength(2)];
    int poisk=1;
    int index=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                while(poisk>0)
                {
                    poisk=0;
                    matrix[i,j,k] = new Random().Next(10, 100);
                    for(int n=0;n<=index;n++)
                    {
                        if(spisok[n]==matrix[i,j,k])
                        {
                            poisk++;
                        }
                    }
                }
                spisok[index]=matrix[i,j,k];
                index++;
                poisk=1;
            }
            
        }
    }
}

Console.Write("Введите кол-во строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во массивов: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("======================================");
if(x*y*z>90)
Console.WriteLine("Кол-во возможных неодинаковых вариантов чисел в массиве меньше кол-ва ячеек массива!!!");
else
{
int[,,] matrix = new int[x,y,z];
InputMatrix(matrix);
    for (x = 0; x < matrix.GetLength(0); x++)
    {
        for (y = 0; y < matrix.GetLength(1); y++)
        {
            for (z = 0; z < matrix.GetLength(2); z++)
            {
                Console.Write($"{matrix[x,y,z]}({x},{y},{z})\t");
            }
                Console.WriteLine();
        }
    Console.WriteLine("---------------------------------------------");
    }
}

