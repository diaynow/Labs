using System.Collections;

var hsh = new HashSet<string>();
Console.WriteLine("Введите элементы:");
while (true)
{
    string? n =Console.ReadLine();
    if (n=="") break;
    hsh.Add(n);
}
Console.Clear();
while(true){
    menu();
    int n=Convert.ToInt32(Console.ReadLine());
    if (n==7)
        break;
    if (n>0 && n<8){
        switch(n){
        case 1:
            Console.Clear();
            Console.WriteLine("Массив до:");
            foreach(var f in hsh){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            hsh.Reverse();
            Console.WriteLine("Массив после:");
            foreach(var f in hsh){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Массив до:");
            foreach(var f in hsh){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            hsh.Clear();
            Console.WriteLine("Массив после:");
            foreach(var f in hsh){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Введите элемент:");
            string? value=Console.ReadLine();
            Console.WriteLine("Массив до:");
            foreach(var f in hsh){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            hsh.Add(value);
            Console.WriteLine("Массив после:");
            foreach(var f in hsh){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("Введите элемент, который нужно удалить из списка (первое вхождение)");
            var k=Console.ReadLine();
            Console.WriteLine("Массив до:");
            foreach(var f in hsh){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            hsh.Remove(k);
            Console.WriteLine("Массив после:");
            foreach(var f in hsh){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 5:
            Console.Clear();
            Console.WriteLine("Количество элементов:");
            Console.WriteLine(hsh.Count);
            Console.WriteLine("=======================================================");
            break;
        case 6:
            Console.Clear();
            foreach(var f in hsh){
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
    Console.WriteLine("1.Reverse");
    Console.WriteLine("2.Clear");
    Console.WriteLine("3.Add");
    Console.WriteLine("4.Remove");
    Console.WriteLine("5.Count");
    Console.WriteLine("6.Вывод Массива");
    Console.WriteLine("7.Выход");
}
