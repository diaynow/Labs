Console.WriteLine("Введите длину массива");
int k = Int32.Parse(Console.ReadLine());
Array mas = Array.CreateInstance(typeof(string), k);
Console.WriteLine("Введите значения:");
for (int i = 0; i < mas.Length; i++)
{
    mas.SetValue(Console.ReadLine(), i );
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
            foreach(var f in mas){
                Console.Write(f+" ");
            }
            Array.Sort(mas);
            Console.WriteLine("");
            Console.WriteLine("Массив после");
            foreach(var f in mas){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Введите элемент, индекс которого нужно найти (первое вхождение):");
            var c=Console.ReadLine();
            Console.WriteLine("Индекс:" +Array.IndexOf(mas, c));
            Console.WriteLine("=======================================================");
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Введите элемент, индекс которого нужно найти (последнее вхождение):");
            var g=Console.ReadLine();
            Console.WriteLine("Индекс:" +Array.LastIndexOf(mas, g));
            Console.WriteLine("=======================================================");
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("Массив до:");
            foreach(var f in mas){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Array.Reverse(mas);
            Console.WriteLine("Массив после:");
            foreach(var f in mas){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 5:
            Console.Clear();
            Console.WriteLine("Массив до:");
            foreach(var f in mas){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Array.Clear(mas);
            Console.WriteLine("Массив после:");
            foreach(var f in mas){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 6:
            Console.Clear();
            Console.WriteLine($"Введите индекс (до {k}):");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Элемент:"+mas.GetValue(q));
            Console.WriteLine("=======================================================");
            break;
        case 7:
            Console.Clear();
            Array mas1 = Array.CreateInstance(typeof(string), k);
            Console.WriteLine("Диапазон (до какого элемента):");
            int doo=Convert.ToInt32(Console.ReadLine());
            Array.Copy(mas,mas1,doo);
            Console.WriteLine("mas:");
            foreach(var f in mas){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("mas1:");
            foreach(var f in mas1){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================================================");
            break;
        case 8:
            Console.Clear();
            Console.WriteLine("Длина массива:");
            Console.WriteLine(mas.Length);
            Console.WriteLine("=======================================================");
            break;
        case 9:
            Console.Clear();
            Console.WriteLine("Тип Array:");
            Console.WriteLine(mas.GetType());
            Console.WriteLine("=======================================================");
            break;
        case 10:
            Console.Clear();
            foreach(var f in mas){
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
    Console.WriteLine("6.GetValue");
    Console.WriteLine("7.Copy");
    Console.WriteLine("8.Length");
    Console.WriteLine("9.Type");
    Console.WriteLine("10.Вывод Массива");
    Console.WriteLine("11.Выход");
}
