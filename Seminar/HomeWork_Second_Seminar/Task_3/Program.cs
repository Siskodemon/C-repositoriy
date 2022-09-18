// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите номер дня недели: ");
int nomer = Convert.ToInt32(Console.ReadLine());
if(nomer<1 || nomer>7)
 Console.WriteLine("Такого номера неделя нет! Попробуй снова...");
else
 switch(nomer){
 case 1: Console.WriteLine("Это Понедельник... До выходжных далеко...");
    break; 
 case 2: Console.WriteLine("Это Вторник... Всё ещё рабочая неделя...");
    break;
 case 3: Console.WriteLine("Среда уже ближе... но всё ещё не выходные...");
    break;
 case 4: Console.WriteLine("Четверг тоже не выходной... к сожалению...");
    break;
 case 5: Console.WriteLine("Ура Пятница!!! Но тоже не выходной... но уже почти...");
    break;
 case 6: Console.WriteLine("УРА Суббота!!!! Наконец-то выходной");
    break;
 case 7: Console.WriteLine("Воскресение тоже выходной!!!");
    break;
}
