// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Введите координату X: ");
int  x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y: ");
int  y = Convert.ToInt32(Console.ReadLine());
if(x!=0 && y!=0){
    Console.WriteLine("Координаты заданы корректно!");
    if(x>0 && y>0)
    Console.WriteLine("Правая вверхняя часть");
    if(x>0 && y<0)
    Console.WriteLine("Правая нижняя часть");
    if(x<0 && y<0)
    Console.WriteLine("Левая нижняя часть");
    if(x<0 && y>0)
    Console.WriteLine("Левая верхняя часть");
}
else{
    Console.WriteLine("Координаты заданы не корректно!");
}