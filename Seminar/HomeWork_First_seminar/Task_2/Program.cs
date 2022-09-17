// See https://aka.ms/new-console-template for more information
int[] array = new int[3];
void Random_chisla(){
    int i=0;
    while(i<3){
        array[i]=new Random().Next(1,100);
        i++;
    }
}
int i =0;
int Insert (int i){
    if(i==0){
        Console.Write("Введите первое число: ");
        array[i]=Convert.ToInt32(Console.ReadLine());
        i++;
        return(i);
    }else{
        Console.Write("Введите следующее число: ");
        array[i]=Convert.ToInt32(Console.ReadLine());
        i++;
        return(i);
    }
}
int Max(int[] chisla){
    int index=0;
    int max=chisla[index];
        while(index<3){
        if(chisla[index]>max)
        max=chisla[index];
        index++;
    }
    return(max);
}
Console.Clear();
Console.Write("Значиния вводятся вручную? (y/n)");
string answer = Console.ReadLine();
if(answer=="y"){
   while(i<3){
    i=Insert(i);
   }
}else{
    Random_chisla();
}
Console.Write("Полученные числа: ");
i=0;
 while(i<3){
    if(i==2)
    Console.WriteLine(array[i]);
    else
     Console.Write(array[i]+",");
    i++;
   }
Console.Write("Максимальное число: "+ Max(array));
