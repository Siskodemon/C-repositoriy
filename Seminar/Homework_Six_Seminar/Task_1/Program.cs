Console.Clear();
int index=0;
string str= string.Empty;
string f(string n)
{
 if (n=="")
  return "";
  else
  {
   if(Convert.ToInt32(n)>0)
    index++;
    Console.Clear();
    str=str+n+", ";
    Console.WriteLine($"Введёные значения: {str}  ");
    Console.WriteLine($"Для окончания ввода ничего не вводите, либо для продолжения введите следующее число: ");
    n = Console.ReadLine();
    return f(n);
  }
 
}
Console.Write("Введите число: ");
f(Console.ReadLine());
Console.WriteLine($"Число значения больше 0 - {index}  ");