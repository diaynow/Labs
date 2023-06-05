using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab12supplies
{
    public class Product
    {
        public int id;
        public string name;
        public Product(int id,string name){
            this.id=id;
            this.name=name;
        }
    }
    public class Manufacturer{
        public int id;
        public string name;
        public Manufacturer(int id,string name){
            this.id=id;
            this.name=name;
        }
    }
    public class Supply{
        public int idProduct;
        public int idMan;
        public string date;
        public Supply(int idProduct,int idMan,string date){
            this.idProduct=idProduct;
            this.idMan=idMan;
            this.date=date;
        }
    }
}