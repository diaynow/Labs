var list=new List<int>{21,10,4,-1,8,-20,-14,100};//На вход массив или список, реализовать запрос по поиску минимального элемента массива для начального массива, и после преобразования, преобразование - удалить все четные
Console.WriteLine($"Минимальный элемент до преобразования: {(list.OrderBy(x=>x)).First()}");
Console.WriteLine($"Минимальный элемент после преобразования: {(list.Where(x=>x%2!=0).OrderBy(x=>x)).First()}");
Console.WriteLine("=======================================================================================");
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
Console.WriteLine("Массив до:");
foreach(var c in list){//Массив, сорт элементы первой половины по возраст второй по убыванию
    Console.Write(Convert.ToString(c)+" ");
}
Console.WriteLine("");
var newlist=(list.Take(list.Count()/2).OrderBy(x=>x)).Union<int>(list.Skip(list.Count()/2).OrderByDescending(x=>x));
Console.WriteLine("Массив после:");
foreach(var c in newlist){//Массив, сорт элементы первой половины по возраст второй по убыванию
    Console.Write(Convert.ToString(c)+" ");
}