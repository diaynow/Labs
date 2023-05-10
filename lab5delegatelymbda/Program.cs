Operation sredarif =(x,y,z) => (x+y+z)/3;
Operation min =(x,y,z) => Math.Min(Math.Min(x,y),Math.Min(y,z));
Operation max =(x,y,z) => Math.Max(Math.Max(x,y),Math.Max(y,z));
Operation sum =(x,y,z) => x+y+z;
Operation mult =(x,y,z) => x*y*z;

Console.WriteLine("Введите первое число:");
double x=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
double y=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
double z=Convert.ToInt32(Console.ReadLine());
while(true){
    Console.WriteLine("1.Сложение");
    Console.WriteLine("2.Среднее арифметическое");
    Console.WriteLine("3.Умножение");
    Console.WriteLine("4.Минимальное");
    Console.WriteLine("5.Максимальное");
    Console.WriteLine("6.Выход");
    int n=Convert.ToInt32(Console.ReadLine());
    if (n==6) break;
    switch(n){
        case 1:
            Console.Clear();
            Console.WriteLine($"Результат сложение: {sum(x,y,z)}");
            Console.WriteLine("=======================================");
            break;
        case 2:
            Console.Clear();
            Console.WriteLine($"Среднее арифметическое: {sredarif(x,y,z)}");
            Console.WriteLine("=======================================");
            break;
        case 3:
            Console.Clear();
            Console.WriteLine($"Результат умножения: {mult(x,y,z)}");
            Console.WriteLine("=======================================");
            break;
        case 4:
            Console.Clear();
            Console.WriteLine($"Минимальное: {min(x,y,z)}");
            Console.WriteLine("=======================================");
            break;
        case 5:
            Console.Clear();
            Console.WriteLine($"Максимальное: {max(x,y,z)}");
            Console.WriteLine("=======================================");
            break;
    }
}
delegate double Operation(double x,double y,double z);