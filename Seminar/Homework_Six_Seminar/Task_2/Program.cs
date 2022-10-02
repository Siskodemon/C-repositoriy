Console.Clear();
Console.Write("Введите значение k1 стороны: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2 стороны: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b1 стороны: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2 стороны: ");
double b2 = Convert.ToDouble(Console.ReadLine());
if (k1-k2!=0)
Console.WriteLine($"Координаты точки пересечения 2-х прямых - [{(b2-b1)/(k1-k2)};{(b2-b1)/(k1-k2)}]");
else
Console.WriteLine($"Координаты заданы неверно! Попробуй снова...");
