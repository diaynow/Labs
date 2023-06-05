using lab12supplies;

var product1=new Product(1,"Молоко");
var product2=new Product(2,"Кефир");
var product3=new Product(3,"Гречка");
var product4=new Product(4,"Яйца");

var products=new List<Product>{product1,product2,product3,product4};

var manuf1=new Manufacturer(1,"Любинский молоконсервный комбинат");
var manuf2=new Manufacturer(2,"Мултон");
var manuf3=new Manufacturer(3,"Птицефабрика Тульская");

var manufs=new List<Manufacturer>{manuf1,manuf2,manuf3};

var sup1=new Supply(product1.id,manuf1.id,"12.01.2020");
var sup2=new Supply(product2.id,manuf1.id,"12.01.2020");
var sup3=new Supply(product3.id,manuf3.id,"14.01.2020");
var sup4=new Supply(product4.id,manuf2.id,"15.01.2020");

var sups=new List<Supply>{sup1,sup2,sup3,sup4};

//группировка по дате доставки

var dateSupply=from sup in sups group sup by sup.date;

foreach(var i in dateSupply){
    Console.WriteLine(i.Key+":");
    foreach(var x in i){
        Console.WriteLine($"id товара: {x.idProduct}");
        Console.WriteLine($"id производителя: {x.idProduct}");
        Console.WriteLine("-----------------------------------");
    }
    Console.WriteLine();
}

//группировка по товару

Console.WriteLine("=====================================");

var prods=from prod in sups group prod by prod.idProduct;

foreach(var i in prods){
    Console.WriteLine(i.Key+":");
    foreach(var x in i){
        Console.WriteLine($"Дата поставки: {x.date}");
        Console.WriteLine($"id производителя: {x.idProduct}");
        Console.WriteLine("-----------------------------------");
    }
    Console.WriteLine();
}

//группировка по поставщику

Console.WriteLine("=====================================");

var mans=from man in sups group man by man.idMan;

foreach(var i in mans){
    Console.WriteLine(i.Key+":");
    foreach(var x in i){
        Console.WriteLine($"Дата поставки: {x.date}");
        Console.WriteLine($"id товара: {x.idMan}");
        Console.WriteLine("-----------------------------------");
    }
    Console.WriteLine();
}