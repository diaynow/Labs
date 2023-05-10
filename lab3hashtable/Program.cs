using System.Collections;

Hashtable tabl = new Hashtable();
Console.WriteLine("Введите ключ и элементы (через пробел):");
while (true)
{
    string? str =Console.ReadLine();
    if (str=="") break;
    string[] n=str.Split(" ");
    tabl.Add(n[0],n[1]);
}
Console.Clear();
while(true){
    menu();
    int n=Convert.ToInt32(Console.ReadLine());
    if (n==9)
        break;
    if (n>0 && n<10){
        switch(n){
        case 1:/*ContainsValue1*/
            Console.Clear();
            Console.WriteLine("Введите элемент:");
            Console.WriteLine(tabl.ContainsValue(Console.ReadLine()));
            Console.WriteLine("=======================================================");
            break;
        case 2:/*ContainsKey1*/
            Console.Clear();
            Console.WriteLine("Введите ключ:");
            Console.WriteLine(tabl.ContainsKey(Console.ReadLine()));
            Console.WriteLine("=======================================================");
            break;
        case 3:/*Equals1*/
            Console.Clear();
            Console.WriteLine("Введите ключ:");
            string c=Console.ReadLine();
            Console.WriteLine("Введите значение:");
            Console.WriteLine(tabl[c].Equals(Console.ReadLine()));
            Console.WriteLine("=======================================================");
            break;

        case 4:/*Clear1*/
            Console.Clear();
            Console.WriteLine("Массив до:");
            foreach(var f in tabl){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            tabl.Clear();
            Console.WriteLine("Массив после:");
            foreach(var f in tabl){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 5:/*Remove1*/
            Console.Clear();
            Console.WriteLine("Введите ключ:");
            var k=Console.ReadLine();
            Console.WriteLine("Массив до:");
            foreach(var f in tabl){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            tabl.Remove(k);
            Console.WriteLine("Массив после:");
            foreach(var f in tabl){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 6:/*Count1*/
            Console.Clear();
            Console.WriteLine("Количество элементов:");
            Console.WriteLine(tabl.Count);
            Console.WriteLine("=======================================================");
            break;
        case 7:/*Add1*/
            Console.Clear();
            Console.WriteLine("Введите ключ:");
            string? key=Console.ReadLine();
            Console.WriteLine("Введите элемент, соответствующий ключу:");
            string? value=Console.ReadLine();
            Console.WriteLine("Массив до:");
            foreach(var f in tabl){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            tabl.Add(key,value);
            Console.WriteLine("Массив после:");
            foreach(var f in tabl){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 8:/*Вывод массива*/
            Console.Clear();
            foreach(var f in tabl){
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
    Console.WriteLine("1.ContainsValue");
    Console.WriteLine("2.ContainsKey");
    Console.WriteLine("3.Equals");
    Console.WriteLine("4.Clear");
    Console.WriteLine("5.Remove");
    Console.WriteLine("6.Count");
    Console.WriteLine("7.Add");
    Console.WriteLine("8.Вывод Массива");
    Console.WriteLine("9.Выход");
}
