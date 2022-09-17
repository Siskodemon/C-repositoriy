// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите с каким количеством чисел будем работать: ");
int kol = Convert.ToInt32(Console.ReadLine());
int[] array = new int[kol];
void Random_chisla(){
    int i=0;
    while(i<kol){
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
int Next_Max(int[] chisla){
    int index=0;
    int next_max=chisla[index+1];
    int max=chisla[index];
        while(index<kol){
        if(chisla[index]>max){
            next_max=max;
            max=chisla[index];
        }
        if(chisla[index]>next_max&&chisla[index]<max){
            next_max=chisla[index];
        }
        index++;
    }
    return(next_max);
}
Console.Write("Значиния вводятся вручную? (y/n)");
string answer = Console.ReadLine();
if(answer=="y"){
   while(i<kol){
    i=Insert(i);
   }
}else{
    Random_chisla();
}
Console.Write("Полученные числа: ");
i=0;
 while(i<kol){
    if(i==kol-1)
    Console.WriteLine(array[i]);
    else
     Console.Write(array[i]+",");
    i++;
   }
Console.Write("Второе максимальное число: "+ Next_Max(array));
