namespace лаб2;
class Program
{
    static void Main(string[] args)
    {
        var uprs = Menu.Zapupr();
        var mainsostavs = Menu.Zapmainsostav();
        var supports = Menu.Zapsupport();
        while (true)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 6) break;
            Menu.mainmenu();
            switch (n)
            {
                case 1:
                    Console.Clear();
                    Menu.allStag(uprs, mainsostavs, supports);
                    Console.WriteLine("===============================");
                    break;
                case 2:
                    Console.Clear();
                    Menu.lastStag(uprs, mainsostavs, supports);
                    Console.WriteLine("===============================");
                    break;
                case 3:
                    Console.Clear();
                    Menu.countEkz(mainsostavs);
                    Console.WriteLine("===============================");
                    break;
                case 4:
                    Console.Clear();
                    Menu.completeWork(supports);
                    Console.WriteLine("===============================");
                    break;
                case 5:
                    Console.Clear();
                    Menu.Orders(uprs);
                    Console.WriteLine("===============================");
                    break;
            }
        }
    }
}
class Menu
{
    public static void mainmenu()
    {
        Console.WriteLine("1.Общий стаж");
        Console.WriteLine("2.Стаж работы на последнем месте");
        Console.WriteLine("3.Кол-во экземпляров отпечатанных в день");
        Console.WriteLine("4.Выполненные работы вспомогательного состава");
        Console.WriteLine("5.Приказы");
        Console.WriteLine("6.Выход");
    }
    public static List<Upr> Zapupr()
    {
        List<Upr> uprs = new List<Upr>();
        Console.WriteLine("Заполнение данных управляющего состава");
        while (true)
        {
            Console.WriteLine("Введите ФИО (оставьте пустую строку, если сотрудники закончились:");
            string Fio = Console.ReadLine();
            if (Fio == "") break;
            Upr upr = new Upr();
            upr.fio = Fio;
            Console.WriteLine("Введите должность:");
            upr.dolgnost = Console.ReadLine();
            List < Trudbook > trudbooks= new List<Trudbook>();
            while (true)
            {
                Console.WriteLine("Введите бывшую работу (оставьте пустую строку, если работ больше не было):");
                string work = Console.ReadLine();
                if (work=="") break;
                Trudbook book = new Trudbook();
                book.work = work;
                Console.WriteLine("Введите стаж на этой работе в днях:");
                book.sostag = Convert.ToInt32(Console.ReadLine());
                trudbooks.Add(book);
            }
            upr.trudbook = trudbooks;
            List<Prikaz> prikazs=new List<Prikaz>();
            while (true)
            {
                Console.WriteLine("Введите номер приказа и содержание через пробел (чтобы прекратить ввод оставьте строку пустой):");
                string numberpr = Console.ReadLine();
                if (numberpr == "") break;
                var prikaz = new Prikaz();
                Console.WriteLine("Введите дату приказа (день/месяц/год):");
                string datepr = Console.ReadLine();
                prikaz.numberncontent = numberpr;
                prikaz.date = datepr;
                prikazs.Add(prikaz);
            }
            upr.prikaz = prikazs;
            uprs.Add(upr);
        }
        Console.Clear();
        return uprs;
    }
    public static List<Mainsostav> Zapmainsostav()
    {
        Console.WriteLine("Заполнение данных главного состава");
        List<Mainsostav> mainsostavs = new List<Mainsostav>();
        while (true)
        {
            Console.WriteLine("Введите ФИО (оставьте пустую строку, если сотрудники закончились:");
            string Fio = Console.ReadLine();
            if (Fio == "") break;
            Mainsostav ms = new Mainsostav();
            ms.fio = Fio;
            Console.WriteLine("Введите должность:");
            ms.dolgnost = Console.ReadLine();
            List<Trudbook> trudbooks = new List<Trudbook>();
            while (true)
            {
                Console.WriteLine("Введите бывшую работу (оставьте пустую строку, если работ больше не было):");
                string work = Console.ReadLine();
                if (work == "") break;
                Trudbook book = new Trudbook();
                book.work = work;
                Console.WriteLine("Введите стаж на этой работе в днях:");
                book.sostag = Convert.ToInt32(Console.ReadLine());
                trudbooks.Add(book);
            }
            ms.trudbook = trudbooks;
            var dC = new Dictionary<string, int>();
            while (true)
            {
                Console.WriteLine("Дата(день/месяц/год):");
                string date = Console.ReadLine();
                if (date == "") break;
                Console.WriteLine("Введите кол-во экземпляров");
                int count = Convert.ToInt32(Console.ReadLine());
                dC.Add(date, count);
            }
            ms.dateCount = dC;
            mainsostavs.Add(ms);
        }
        Console.Clear();
        return mainsostavs;
    }
    public static List<Support> Zapsupport()
    {
        Console.WriteLine("Заполнение данных вспомогательного состава");
        List<Support> supports = new List<Support>();
        while (true)
        {
            Console.WriteLine("Введите ФИО (оставьте пустую строку, если сотрудники закончились:");
            string Fio = Console.ReadLine();
            if (Fio == "") break;
            Support support = new Support();
            support.fio = Fio;
            Console.WriteLine("Введите должность:");
            support.dolgnost = Console.ReadLine();
            List<Trudbook> trudbooks = new List<Trudbook>();
            while (true)
            {
                Console.WriteLine("Введите бывшую работу (оставьте пустую строку, если работ больше не было):");
                string work = Console.ReadLine();
                if (work == "") break;
                Trudbook book = new Trudbook();
                book.work = work;
                Console.WriteLine("Введите стаж на этой работе в днях:");
                book.sostag = Convert.ToInt32(Console.ReadLine());
                trudbooks.Add(book);
            }
            support.trudbook = trudbooks;
            var dC = new Dictionary<string, string>();
            while (true)
            {
                Console.WriteLine("Дата(день/месяц/год):");
                string date = Console.ReadLine();
                if (date == "") break;
                Console.WriteLine("Введите выполненную в этот день работу");
                string work = Console.ReadLine();
                dC.Add(date, work);
            }
            support.dateComplete = dC;
            supports.Add(support);
        }
        Console.Clear();
        return supports;
    }
    public static void allStag(List<Upr> x,List<Mainsostav> y, List<Support> z)
    {
        Console.WriteLine("В каком составе состоит данный работник(yправляющий, главный, вспомогательный):");
        string sostav = Console.ReadLine();
        Console.WriteLine("Введите ФИО:");
        string fio = Console.ReadLine();
        int allstag = 0;
        bool check = false;
        if (sostav == "управляющий")
        {
            foreach(Upr c in x)
            {
                if (c.fio == fio)
                {
                    check = true;
                    foreach(Trudbook f in c.trudbook)
                    {
                        allstag += f.sostag;
                    }
                }
                break;
            }
        }
        if (sostav == "главный")
        {
            foreach (Mainsostav c in y)
            {
                if (c.fio == fio)
                {

                    check = true;
                    foreach (Trudbook f in c.trudbook)
                    {
                        allstag += f.sostag;
                    }
                }
                break;
            }
        }
        if (sostav == "вспомогательный")
        {
            foreach (Support c in z)
            {
                if (c.fio == fio)
                {
                    check = true;
                    foreach (Trudbook f in c.trudbook)
                    {
                        allstag += f.sostag;
                    }
                }
                break;
            }
        }
        Console.Clear();
        if (check==false)
        {
            Console.WriteLine("Такого работника нет!");
        }
        if (check == true)
        {
            Console.WriteLine(allstag + " дней");
        }
    }
    public static void lastStag(List<Upr> x, List<Mainsostav> y, List<Support> z)
    {
        Console.WriteLine("В каком составе состоит данный работник(yправляющий, главный, вспомогательный):");
        string sostav = Console.ReadLine();
        Console.WriteLine("Введите ФИО:");
        string fio = Console.ReadLine();
        int allstag = 0;
        bool check = false;
        if (sostav == "управляющий")
        {
            foreach (Upr c in x)
            {
                if (c.fio == fio)
                {
                    allstag = c.trudbook[c.trudbook.Count - 1].sostag;
                }
                break;
            }
        }
        if (sostav == "главный")
        {
            foreach (Mainsostav c in y)
            {
                if (c.fio == fio)
                {
                    allstag = c.trudbook[c.trudbook.Count - 1].sostag;
                }
                break;
            }
        }
        if (sostav == "вспомогательный")
        {
            foreach (Support c in z)
            {
                if (c.fio == fio)
                {
                    allstag = c.trudbook[c.trudbook.Count - 1].sostag;
                }
                break;
            }
        }
        Console.Clear();
        if (check == false)
        {
            Console.WriteLine("Такого работника нет!");
        }
        if (check == true)
        {
            Console.WriteLine(allstag + " дней");
        }
    }
    public static void countEkz(List<Mainsostav> mainsostavs)
    {
        Console.WriteLine("Введите от какой даты:");
        DateTime ot = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Введите до какой даты:");
        DateTime doo = DateTime.Parse(Console.ReadLine());
        int k = 0;
        foreach(var mainsostav in mainsostavs)
        {
            foreach(var dC in mainsostav.dateCount)
            {
                var date = DateTime.Parse(dC.Key);
                if (ot<=date || date <= doo)
                {
                    k++;
                }
            }
        }
        Console.WriteLine($"Кол-во экзмпляров за данный диапозон дат: {k}");

    }
    public static void completeWork(List<Support> supports)
    {
        foreach(var support in supports)
        {
            Console.WriteLine(support.fio);
            foreach (var wC in support.dateComplete)
            {
                Console.WriteLine(wC.Key + " " + wC.Value);
            }
        }
    }
    public static void Orders(List<Upr> uprs)
    {
        Console.WriteLine("Введите ФИО:");
        string fio = Console.ReadLine();
        foreach(var upr in uprs)
        {
            if (upr.fio == fio)
            {
                Console.WriteLine($"Приказы от {fio}:");
                foreach (var order in upr.prikaz)
                {
                    Console.WriteLine(order.numberncontent+ " от " + order.date);
                }
            }
        }
    }

}
class Trudbook
{
    public string work;
    public int sostag;
}
class Prikaz
{
    public string numberncontent;
    public string date;
}
class People
{
    public string fio;
    public string dolgnost;
    public List<Trudbook> trudbook;
}
class Upr : People
{
    public List<Prikaz> prikaz;
}
class Mainsostav: People
{
    public Dictionary<string, int> dateCount;
}
class Support : People
{
    public Dictionary<string,string> dateComplete;
}