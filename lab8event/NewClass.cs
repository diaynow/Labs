using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab8event
{
    public delegate void MathOperation(int x,int y);
    public class Calc
    {
        public event MathOperation Add;
        public event MathOperation Sub;
        public event MathOperation Mult;
        public event MathOperation Div;
        public void Invokeadd(int a,int b){
            Add.Invoke( a , b);
        }
        public void Invokesub(int a,int b){
            Sub.Invoke( a , b);
        }
        public void Invokemult(int a,int b){
            Mult.Invoke( a , b);
        }
        public void Invokediv(int a , int b){
            Div.Invoke( a , b);
        }
        public void MathAdd(int a,int b){
            Console.WriteLine($"{a} + {b} = {a+b}");
        }
        public void MathSub(int a,int b){
            Console.WriteLine($"{a} - {b} = {a-b}");
        }
        public void MathMult(int a,int b){
            Console.WriteLine($"{a} * {b} = {a*b}");
        }
        public void MathDiv(int a,int b){
            if (b==0){
                Console.WriteLine("На ноль делить нельзя!");
            }
            else{
                Console.WriteLine($"{a} / {b} = {a/b}");
            }
        }
    }
}