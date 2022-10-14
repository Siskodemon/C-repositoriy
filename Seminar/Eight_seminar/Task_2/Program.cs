/**Задача 57:** Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

{ 1, 9, 9, 0, 2, 8, 0, 9 }

0 встречается 2 раза

1 встречается 1 раз

2 встречается 1 раз

8 встречается 1 раз

9 встречается 3 раза

1, 2, 3

4, 6, 1

2, 1, 6

1 встречается 3 раза

2 встречается 2 раз

3 встречается 1 раз

4 встречается 1 раз

6 встречается 2 раза
*/
Console.Clear();
string InputMatrix(int[,] matrix)
{
    string sprav=string.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            int index=0;
            if(i==0 && j==0)
            {
                sprav=sprav + matrix[i,j];
                Console.WriteLine($"Convert.ToInt32(sprav[index]) = {sprav[index]}");
                Console.WriteLine($"index =  {index}, sprav[index] = {sprav[index]}");
                Console.WriteLine($"sprav = {sprav}, Длина = {sprav.Length}");
                Console.WriteLine($"matrix[{i},{j}] = { matrix[i, j]}");
                Console.WriteLine($"===================================");
            }else
            while(index<sprav.Length)
            {
            char s=sprav[index];
            if(Convert.ToInt32(s)==matrix[i,j])
            {
              Console.WriteLine($"Chf,jnfkj");
              break;
            }
            else
            if(index==sprav.Length-1)
            {
                sprav=sprav + Convert.ToString(matrix[i,j]);
                break;
            }
            Console.WriteLine($"Convert.ToInt32(sprav[index]) = {sprav[index]},s={s}, matrix[i,j] = {matrix[i,j]}");
            Console.WriteLine($"index =  {index}, sprav[index] = {sprav[index]}");
            Console.WriteLine($"sprav = {sprav}, Длина = {sprav.Length}");
            Console.WriteLine($"matrix[{i},{j}] = { matrix[i, j]}");
            Console.WriteLine($"===================================");
            index++;
            }
            //Console.Write(matrix[i, j] + " \t");
        }
    Console.WriteLine();
    }
    return(sprav);
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"===================================");
int[,] matrix = new int[n, m];
string sprav=InputMatrix(matrix);

Console.WriteLine($"Справочник: {Convert.ToInt32(sprav)}");


string prim="1234";
Console.WriteLine($"prim: {Convert.ToInt32(prim)},prim[0] = {prim[0]}, Convert.ToInt32(prim[0]) = {Convert.ToInt32(prim[0])}");

