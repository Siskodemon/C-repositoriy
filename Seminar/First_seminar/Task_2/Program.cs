// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите номер дня недели: ");
int nomer = Convert.ToInt32(Console.ReadLine());
if(nomer<1 || nomer>7)
 Console.WriteLine("Такого номера неделя нет! Попробуй снова...");
else
 switch(nomer){
 case 1: Console.WriteLine("Это Понедельник!");
    break; 
 case 2: Console.WriteLine("Это Вторник!");
    break;
 case 3: Console.WriteLine("Это Среда!");
    break;
 case 4: Console.WriteLine("Это Четвер!");
    break;
 case 5: Console.WriteLine("Это Пятница!");
    break;
 case 6: Console.WriteLine("Это Суббота!");
    break;
 case 7: Console.WriteLine("Это Воскресение!");
    break;
}
