// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = -a;
while(b<a){
    Console.Write(b+",");
    b++;
}
Console.Write(b);
