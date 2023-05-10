using System.Collections;

var lst = new List<string>();
Console.WriteLine("Введите элементы:");
while (true)
{
    string? n =Console.ReadLine();
    if (n=="") break;
    lst.Add(n);
}
Console.Clear();
while(true){
    menu();
    int n=Convert.ToInt32(Console.ReadLine());
    if (n==11)
        break;
    if (n>0 && n<12){
        switch(n){
        case 1:
            Console.Clear();
            Console.WriteLine("Массив до:");
            foreach(var f in lst){
                Console.Write(f+" ");
            }
            lst.Sort();
            Console.WriteLine("");
            Console.WriteLine("Массив после");
            foreach(var f in lst){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Введите элемент, индекс которого нужно найти (первое вхождение):");
            var c=Console.ReadLine();
            Console.WriteLine("Индекс:" +lst.IndexOf(c));
            Console.WriteLine("=======================================================");
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Введите элемент, индекс которого нужно найти (последнее вхождение):");
            var g=Console.ReadLine();
            Console.WriteLine("Индекс:" +lst.LastIndexOf(g));
            Console.WriteLine("=======================================================");
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("Массив до:");
            foreach(var f in lst){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            lst.Reverse();
            Console.WriteLine("Массив после:");
            foreach(var f in lst){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 5:
            Console.Clear();
            Console.WriteLine("Массив до:");
            foreach(var f in lst){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            lst.Clear();
            Console.WriteLine("Массив после:");
            foreach(var f in lst){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 6:
            Console.Clear();
            Console.WriteLine($"Введите индекс (до {lst.Count}):");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите объект, на который нужно заменить:");
            var p =Console.ReadLine();
            Console.WriteLine("Массив до:");
            foreach(var f in lst){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            lst.Insert(q,p);
            Console.WriteLine("Массив после:");
            foreach(var f in lst){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 7:
            Console.Clear();
            Console.WriteLine("Введите элемент, который нужно удалить из списка (первое вхождение)");
            var k=Console.ReadLine();
            Console.WriteLine("Массив до:");
            foreach(var f in lst){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            lst.Remove(k);
            Console.WriteLine("Массив после:");
            foreach(var f in lst){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 8:
            Console.Clear();
            Console.WriteLine("Количество элементов:");
            Console.WriteLine(lst.Count);
            Console.WriteLine("=======================================================");
            break;
        case 9:
            Console.Clear();
            Console.WriteLine("Введите индекс:");
            int l=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Массив до:");
            foreach(var f in lst){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            lst.RemoveAt(l);
            Console.WriteLine("Массив после:");
            foreach(var f in lst){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 10:
            Console.Clear();
            foreach(var f in lst){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            Console.WriteLine("");
        break;
    }
    }
    else{
        Console.WriteLine("Ошибка!");
    }
}
static void menu(){
    Console.WriteLine("1.Sort");
    Console.WriteLine("2.IndexOf");
    Console.WriteLine("3.LastIndexOf");
    Console.WriteLine("4.Reverse");
    Console.WriteLine("5.Clear");
    Console.WriteLine("6.Insert");
    Console.WriteLine("7.Remove");
    Console.WriteLine("8.Count");
    Console.WriteLine("9.RemoveAt");
    Console.WriteLine("10.Вывод Массива");
    Console.WriteLine("11.Выход");
}
