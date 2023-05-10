using System.Collections;

var que = new Queue<string>();
Console.WriteLine("Введите элементы:");
while (true)
{
    string? n =Console.ReadLine();
    if (n=="") break;
    que.Enqueue(n);
}
Console.Clear();
while(true){
    menu();
    int n=Convert.ToInt32(Console.ReadLine());
    if (n==8)
        break;
    if (n>0 && n<9){
        switch(n){
        case 1://Enqueue1
            Console.Clear();
            Console.WriteLine("Введите элемент, который нужно добавить:");
            string ff=Console.ReadLine();
            Console.WriteLine("Массив до:");
            foreach(var f in que){
                Console.Write(f+" ");
            }
            que.Enqueue(ff);
            Console.WriteLine("");
            Console.WriteLine("Массив после:");
            foreach(var f in que){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 2://Dequeue1
            Console.Clear();
            Console.WriteLine("Введите элемент, который нужно удалить:");
            string ff1=Console.ReadLine();
            Console.WriteLine("Массив до:");
            foreach(var f in que){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("Элемент:");
            Console.WriteLine(que.Dequeue());
            Console.WriteLine("Массив после:");
            foreach(var f in que){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 3://Peek1
            Console.Clear();
            Console.WriteLine("Массив до:");
            foreach(var f in que){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("Элемент:");
            Console.WriteLine(que.Peek());
            Console.WriteLine("Массив после:");
            foreach(var f in que){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 4://Contains1
            Console.Clear();
            Console.WriteLine("Введите элемент:");
            Console.WriteLine(que.Contains(Console.ReadLine()));
            Console.WriteLine("=======================================================");
            break;
        case 5://Clear1
            Console.Clear();
            Console.WriteLine("Массив до:");
            foreach(var f in que){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            que.Clear();
            Console.WriteLine("Массив после:");
            foreach(var f in que){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 6:
            Console.Clear();
            Console.WriteLine("Количество элементов:");
            Console.WriteLine(que.Count);
            Console.WriteLine("=======================================================");
            break;
        case 7:
            Console.Clear();
            Console.WriteLine("Элементы:");
            foreach(var f in que){
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
    Console.WriteLine("1.Enqueue");
    Console.WriteLine("2.Dequeue");
    Console.WriteLine("3.Peek");
    Console.WriteLine("4.Contains");
    Console.WriteLine("5.Clear");
    Console.WriteLine("6.Count");
    Console.WriteLine("7.Вывод Массива");
    Console.WriteLine("8.Выход");
}
