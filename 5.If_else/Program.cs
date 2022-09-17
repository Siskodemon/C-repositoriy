// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите имя пользователя: ");
string name = Console.ReadLine();
if(name == "Маша"){
    Console.WriteLine("Приветствуем несравненную Машу");
}
else{
    Console.Write("Привет, ");
    Console.WriteLine(name);
}
