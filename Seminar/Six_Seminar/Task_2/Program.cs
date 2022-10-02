Console.Clear();
Console.Write("Введите размер 1-ой стороны: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер 2-ой стороны: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер 3-ей стороны: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a+b>c && a+c>b && b+c>a)
Console.WriteLine($"Треугольник со размером сторон {a}, {b} и {c} можно сделать");
else
Console.WriteLine($"Треугольник со размером сторон {a}, {b} и {c} сделать не возможно");
