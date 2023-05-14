using lab7delegateclass;

var car1=new Car("Lamborgini","Urus");
var car2=new Car("UAZ","Patriot");
Garage garage= new Garage();
garage.AddCar(car1);
garage.AddCar(car2);
Washcar washcar=Washing.Wash; 
washcar(car2);
garage.GetCars();


delegate void Washcar (Car car);