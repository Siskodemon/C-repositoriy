Console.Clear();

Console.Write("Введите вес ириски: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вес мандарина: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вес пряника: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вес подарка: ");
int z = Convert.ToInt32(Console.ReadLine());
int kol = 0;
if(z%a==0)
kol++;
if(z%b==0)
kol++;
if(z%c==0)
kol++;
if((z-a)%b==0)
kol++;
if((z-a)%c==0)
kol++;
if((z-b)%a==0)
kol++;
if((z-b)%c==0)
kol++;
if((z-c)%a==0)
kol++;
if((z-c)%b==0)
kol++;
Console.Write($"Кол-во вариантов: {kol}");

/*Console.Clear();

int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
int w = Convert.ToInt32(Console.ReadLine());
int count = 0;
for(int i = 0; i <= w; i+=x )
{
    for(int j = 0; j <= w; j+=y )
    {
        for(int k = 0; k <= w; k+=z )
        {
            if(i + j + k == w)
            {
                Console.WriteLine($"{i} {j} {k}");
                count++;
            }
        }
    }
}
Console.WriteLine(count);
*/