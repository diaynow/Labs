using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab7delegateclass
{
    public class Car
    {
        public string mark;
        public string model;
        public string status="Не мыта";

        public Car(string mark,string model){
            this.model=model;
            this.mark=mark;
        }
    }
    public class Garage{
        public List<Car> garage=new List<Car>();
        public void AddCar(Car car){
            garage.Add(car);
        }
        public void DeleteCar(Car car){
            garage.Remove(car);
        }
        public void GetCars(){
            foreach(Car car in garage){
                Console.WriteLine(car.mark+" "+car.model+" "+ car.status);
            }
        }
    }
    public class Washing{
        public static void Wash(Car car){
            car.status="Помыта";
        }
    }
}