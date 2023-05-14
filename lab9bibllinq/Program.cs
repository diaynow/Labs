var list=new List<int>{1,2,-1,5,6,3,-20,0};
var txt=string.Join(" ",list);
int k=1;
foreach(int x in (from i in list where i!=0 select i)) k*=x;
Console.WriteLine($"Элементы списка:{txt}");
Console.WriteLine($"Кол-во положительных элементов списка:{list.Count(x=>x>0)}");
Console.WriteLine($"Кол-во отрицательных элементов списка:{list.Count(x=>x<0)}");
Console.WriteLine($"Сумма четных элементов списка:{(from i in list where i%2==0 select i).Sum()}");
Console.WriteLine($"Произведение ненулевых списка:{k}");
