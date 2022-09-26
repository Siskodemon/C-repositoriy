// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Введите четверти: ");
int  x = Convert.ToInt32(Console.ReadLine());
if(x>0 && x<5){
    Console.WriteLine("Четверть задана корректно!");
    if(x==1)
    Console.WriteLine("x возможен от 0 до + бесконечности, y равен от 0 до + бесконечности");
    if(x==2)
    Console.WriteLine("x возможен от 0 до - бесконечности, y равен от 0 до + бесконечности");
    if(x==3)
    Console.WriteLine("x возможен от 0 до - бесконечности, y равен от 0 до - бесконечности");
    if(x==4)
    Console.WriteLine("x возможен от 0 до + бесконечности, y равен от 0 до - бесконечности");
}
else{
    Console.WriteLine("Координаты заданы не корректно!");
}