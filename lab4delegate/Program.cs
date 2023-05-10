
Console.WriteLine("Введите первое число:");
int x=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int y=Convert.ToInt32(Console.ReadLine());
while(true){
    Console.WriteLine("1.Сложение");
    Console.WriteLine("2.Вычитание");
    Console.WriteLine("3.Умножение");
    Console.WriteLine("4.Деление");
    Console.WriteLine("5.Выход");
    Mathoper summ=IMath.sum;
    Mathoper subb=IMath.sub;
    Mathoper multt=IMath.mult;
    Mathoper divv=IMath.div;
    int n=Convert.ToInt32(Console.ReadLine());
    if (n==5) break;
    switch(n){
        case 1:
            Console.Clear();
            Console.WriteLine($"Результат сложение: {summ(x,y)}");
            Console.WriteLine("=======================================");
            break;
        case 2:
            Console.Clear();
            Console.WriteLine($"Результат вычитания: {subb(x,y)}");
            Console.WriteLine("=======================================");
            break;
        case 3:
            Console.Clear();
            Console.WriteLine($"Результат умножения: {multt(x,y)}");
            Console.WriteLine("=======================================");
            break;
        case 4:
            Console.Clear();
            Console.WriteLine($"Результат деления: {divv(x,y)}");
            Console.WriteLine("=======================================");
            break;
    }
}
interface IMath{

    static int x;
    static int y;
    static int sum(int x,int y){
        return x+y;
    }
    static int mult(int x,int y){
        return x*y;
    }
    static int div(int x,int y){
        return x/y;
    }
    static int sub(int x,int y){
        return x-y;
    }
}
public delegate int Mathoper(int x , int y);
