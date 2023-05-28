var car1=new Car();
car1.id=1;
car1.mark="BMW";
car1.color="purple";
var car2=new Car();
car1.id=2;
car2.mark="Mercedes";
car2.color="black";

var cars=new List<Car>{car1,car2};

var owner1=new Owner();
owner1.idCar=2;
owner1.surname="Надеин";
var owner2=new Owner();
owner2.idCar=1;
owner2.surname="Федоров";
var owner3=new Owner();
owner3.idCar=1;
owner3.surname="Федоренко";

var owners=new List<Owner>{owner1,owner2,owner3};

var generalOwners=from x in owners group x by x.idCar;

foreach(var group in generalOwners){
    Console.WriteLine(group.Key+":");
    foreach(var owner in group){
        Console.WriteLine(owner.surname);
    }
    Console.WriteLine();
}
Console.WriteLine("===========================================");


var generalLetterOwners=from x in owners group x by x.surname[0];
foreach(var group in generalOwners){
    foreach(var owner in group){
        Console.WriteLine(owner.surname);
    }
    Console.WriteLine();
}
class Car{
    public int id;
    public string color;
    public string mark;
}
class Owner{
    public int idCar;
    public string surname;
}
