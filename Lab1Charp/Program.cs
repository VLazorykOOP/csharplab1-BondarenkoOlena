// See https://aka.ms/new-console-template for more information

static void task1()
{
    //Написати програму, яка обчислює:
    //1.1.площу квадрата, периметр якого дорівнює а.
    Console.WriteLine("Task1 !");
    Console.Write("P = ");
    string? str = Console.ReadLine();
    float p = 0; 
    if (str != null) p = float.Parse(str);

    double s = Math.Pow(p / 4, 2);
    Console.WriteLine("S = " + s);
}

static void task2()
{
    //Написати програму, яка визначає:
    //2.1.максимальне значення для двох різних дійсних чисел;
    Console.WriteLine("Task2 !");
    Console.Write("x = ");
    string? str = Console.ReadLine();
    float x = 0;
    if (str != null) x = float.Parse(str);

    Console.Write("y = ");
    str = Console.ReadLine();
    float y = 0;
    if (str != null) y = float.Parse(str);

    float max = Math.Max(x, y);
    Console.WriteLine("max = " + max);
}

static void task3()
{
    /*
     Дана точка на площині з координатами (х, у). Скласти
програму, яка видає одне з повідомлень "Так", "Ні", "На межі" залежно від того,
чи лежить точка всередині заштрихованої області, поза заштрихованої області або
на її межі. Області задаються наступним чином: (v1)
    */
    Console.WriteLine("Task3 !");
    Console.Write("x = ");
    float x = float.Parse(Console.ReadLine());

    Console.Write("y = ");
    float y = float.Parse(Console.ReadLine());
    
    if (x * x + y * y < 144 && x > y)
        Console.WriteLine("Так");
    else if (x * x + y * y > 144 && x < y)
        Console.WriteLine("Ні");
    else Console.WriteLine("На межі");
}

static void task4()
{
    //Написати програму.
    //4.1.Дано порядковий номер місяця, вивести на екран кількість місяців які залишилися до кінця року. 
    Console.WriteLine("Task4 !");
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    if(n > 12) n %= 12;
    n = 12 - n;
    Console.WriteLine("До кінця року лишилось місяців: " + n);
}

static int Sum(int a, int b)
{
    return a + b;
}
static void task5()
{
    //Створити функцію.
    //5.1.Реалізувати функцію обчислення суми двох цілих чисел. 
    Console.WriteLine("Task5 !");
    Console.Write("x = ");
    int x = int.Parse(Console.ReadLine());

    Console.Write("y = ");
    int y = int.Parse(Console.ReadLine());

    Console.WriteLine(x + " + " + y + " = " + Sum(x, y));
}

static void task6()
{
    //За введеними з клавіатури значеннями обчислити та вивести на екран значення виразу:
    //6.1. (var 1) a, b - дійсні;
    Console.WriteLine("Task6 !");
    Console.Write("a = ");
    string? str = Console.ReadLine();
    float a = 0;
    if (str != null) a = float.Parse(str); 
    
    Console.Write("b = ");
    str = Console.ReadLine();
    float b = 0;
    if (str != null) b = float.Parse(str);

    float result = a + (a + b - 1) / (a * a + 1) - a * b;
    Console.WriteLine("a + (a + b - 1) / (a * a + 1) - a * b = " + result);
}
Console.WriteLine("Lab 1 !");
task1();
task2();
task3();
task4();
task5();
task6();