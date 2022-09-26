Console.Clear();
Console.Write("Введите количеством учеников: ");
int kol = Convert.ToInt32(Console.ReadLine());
int[] array = new int[kol];
int rost = 200;
     for(int i=0;i<kol;i++){
        array[i]=new Random().Next(rost-10,rost+1);
        rost = array[i];
     }
Console.Write($"Получилась шеренга из учеников следующего роста - ["+string.Join(",",array)+"]");
Console.WriteLine();
Console.Write("Введите рост нового ученика: ");
rost = Convert.ToInt32(Console.ReadLine());
      for(int i=0;i<kol;i++){
     if(array[i]<rost){
        Console.Write($"Номер нового ученика в шеренге: {i}");
        break;
        }
        if(i==kol-1){
        Console.Write($"Нового ученика поставят в конец шеренги");
        break;
        }
     }