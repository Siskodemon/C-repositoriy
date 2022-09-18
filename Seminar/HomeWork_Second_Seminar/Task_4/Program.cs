Console.Clear();
Console.Write("Введите количеством кустов, но не меньше 3-х: ");
int kol = Convert.ToInt32(Console.ReadLine());
int[] array = new int[kol];
void Random_chisla(){
    int i=0;
    while(i<kol){
        array[i]=new Random().Next(1,1000);
        i++;
    }
}
int i =0;
int Insert (int i){
    if(i==0){
        Console.Write("Введите количество ягод на первом кусте: ");
        array[i]=Convert.ToInt32(Console.ReadLine());
        i++;
        return(i);
    }else{
        Console.Write("Введите количество ягод на следующем кусте: ");
        array[i]=Convert.ToInt32(Console.ReadLine());
        i++;
        return(i);
    }
}
Console.Write("Количество ягод на каждом кусте вводим в ручную(y/n)");
if(Console.ReadLine()=="y"){
    while(i<kol)
    i = Insert(i);
}else
Random_chisla();
Console.WriteLine("Получилась грядка со следующим кол-вом ягод на кустах");
Console.Write("[" + string.Join(",",array) + "]");
Console.WriteLine();
int max=array[0]+array[1]+array[2];
i=1;
while(i<array.Length-2){
 if(max<(array[i]+array[i+1]+array[i+2]))
 max=array[i]+array[i+1]+array[i+2];
 i++;
}
Console.WriteLine("Максимально кол-во ягод, которое может собрать автомат с 3-х кустов - "+ max);