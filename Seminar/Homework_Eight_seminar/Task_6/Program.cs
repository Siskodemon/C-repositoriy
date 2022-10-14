Console.Clear();
void InputMatrix(int[,] matrix)
{
    matrix[0,matrix.GetLength(1)/2]=1;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        matrix[i,(matrix.GetLength(1)/2)-i]=1;
        matrix[i,(matrix.GetLength(1)/2)+i]=1;
        for (int j = 1; j < matrix.GetLength(1)-1; j++)
        {
            if(matrix[i-1,j-1]!=0 && matrix[i-1,j+1]!=0)
            matrix[i,j]=matrix[i-1,j-1]+matrix[i-1,j+1];
        }
    }
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n+1,n+n+1];
Console.WriteLine("============================");
InputMatrix(matrix);
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
         if(matrix[i,j]==0)
            Console.Write(" " + " \t");
            else
            Console.Write(matrix[i,j] + " \t");
        }
    Console.WriteLine();
    }