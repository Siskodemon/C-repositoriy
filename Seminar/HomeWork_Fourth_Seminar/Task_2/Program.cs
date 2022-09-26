// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите число : ");
int  a = Convert.ToInt32(Console.ReadLine());
int resalt=0;
while(a/10 !=0){
    resalt = resalt + a%10;
    a=a/10;
}
Console.Write($"Сумма чисел: {resalt+a}");