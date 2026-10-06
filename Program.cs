while (true)
{
    Console.Write("Zadaj prikaz na vyber mas (sum, odm, find, help, rect: ");
    string prikaz = Console.ReadLine();

    if (prikaz == "sum")
    {
        VykonajSum();
    }
    else if (prikaz == "odm")
    {
        VykonajOdm();
    }
    else if (prikaz == "find")
    {
        VykonajFind();
    }
    else if (prikaz == "help")
    {
        VykonajHelp();
    }
    else if (prikaz == "rect")
    {
        VykonajRect();
    }
    else if (prikaz == "exit")
    {
        break;
    }
    else
    {
        Console.WriteLine("Zadaj prosim spravny prikaz.");
    }
}

void VykonajSum()
{
    Console.WriteLine("Rozumiem robime scitanie");
    Console.Write("Zadaj prve cislo: ");
    double sum1 = double.Parse(Console.ReadLine());
    Console.Write("Zadaj druhe cislo: ");
    double sum2 = double.Parse(Console.ReadLine());
    double vysledok = sum1 + sum2;
    Console.WriteLine($"{sum1} + {sum2} = {vysledok}");
}

void VykonajOdm()
{
    Console.WriteLine("Rozumiem robime odmocniny");
    Console.Write("Zadaj číslo: ");
    double odm1 = double.Parse(Console.ReadLine());
    double vysledok = Math.Sqrt(odm1);
    Console.WriteLine($"odm({odm1}) = {vysledok}");
}

void VykonajFind()
{
    Console.WriteLine("Rozumiem robime find");
    Console.Write("Zadaj vetu: ");
    string veta = Console.ReadLine();
    Console.Write("Zadaj co chces hladat: ");
    string hladane = Console.ReadLine();

    if (veta.Contains(hladane))
    {
        Console.WriteLine("Text ktory hladas sa nachadza vo vete.");
    }
    else
    {
        Console.WriteLine("Text ktory hladas sa nenachadza vo vete.");
    }
}

void VykonajHelp()
{
    Console.WriteLine("sum - scitanie dvoch cisel");
    Console.WriteLine("odm - odmocnina zo zadaneho cisla");
    Console.WriteLine("find - najde podretazec vo vete");
    Console.WriteLine("help - vypise vsetky podporovane prikazy");
    Console.WriteLine("rect - zapne mod merania obdlznikov");
    Console.WriteLine("exit - ukonci cely program");
    Console.WriteLine("array - pracu s polom cisel");
}

void VykonajRect()
{
    Console.WriteLine("Lets measure a rectangle.");
    Console.Write("Enter the length of the first side: ");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Enter the length of the second side: ");
    double b = double.Parse(Console.ReadLine());
    
    if (a <= 0 || b <= 0)
    {
        Console.WriteLine("Chyba: Strany obdlznika musia byt vacsie ako 0");
        return;
    }

    Console.WriteLine($"We have a rectangle of size {a}x{b}, what do you need to measure? (area, perimeter, diagonal) ");

    while (true)
    {
        string rectPrikaz = Console.ReadLine();

        if (rectPrikaz == "area")
        {
            double vysledok = Area(a, b);
            Console.WriteLine($"Area of a {a}x{b} rectangle is {vysledok}");
        }
        else if (rectPrikaz == "perimeter")
        {
            double vysledok = Perimeter(a, b);
            Console.WriteLine($"Perimeter of a {a}x{b} rectangle is {vysledok}");
        }
        else if (rectPrikaz == "diagonal")
        {
            double vysledok = Diagonal(a, b);
            Console.WriteLine($"Diagonal of a {a}x{b} rectangle is {vysledok}");
        }
        else if (rectPrikaz == "exit")
        {
            break;
        }
        else
        {
            Console.WriteLine("Zadaj prosim spravny prikaz pre obdlznik (area, perimeter, diagonal, exit).");
        }
    }
}
double Area(double a, double b)
{
    return a * b;
}

double Perimeter(double a, double b)
{
    return 2 * (a + b);
}

double Diagonal(double a, double b)
{
    return Math.Sqrt(a * a + b * b);
}