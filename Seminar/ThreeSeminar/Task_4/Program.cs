// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Введите число: ");
int  x = Convert.ToInt32(Console.ReadLine());
string s="";
int n =1;
if(x>0)
while(n<x+1){
     s=s+Convert.ToString(n*n)+" ";
     n++;
}else
Console.WriteLine("Число меньше или равно 0. Выберите другое число..." + s);
Console.WriteLine("Квадраты чисел: " + s);
