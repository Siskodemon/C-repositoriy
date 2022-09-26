// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите координату X первой точки: ");
int  x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int  y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X второй точки: ");
int  x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
int  y2 = Convert.ToInt32(Console.ReadLine());
if(x1==x2 && y1==y2){
      Console.WriteLine("Координаты заданы не корректно!");
}
else{
    Console.WriteLine("Координаты заданы корректно!");
    double rast = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
    Console.WriteLine("Расстояние равно - "+ rast);
    
}