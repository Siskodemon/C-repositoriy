// See https://aka.ms/new-console-template for more information
void Poisk(int chislo){
   if(chislo>99){
        if(chislo>=1000)
        while(chislo>=1000)
            chislo=chislo/10;
        Console.WriteLine("Третья цифра : "+ chislo%10);        
    }else
    Console.WriteLine("В числе нет 3-ей цифры!!!"); 
}
Console.Clear();
Console.Write("Введёте число сами?(y/n)");
//string answer = Console.ReadLine();
if(Console.ReadLine()=="y"){
    Console.Write("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Работаем с числом : "+ a);
    Poisk(a);
}else{
    int a = new Random().Next(1,1000000);
    Console.WriteLine("Работаем с числом : "+ a);
    Poisk(a);
}
