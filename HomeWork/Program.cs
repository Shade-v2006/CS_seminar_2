/*  ***********************************************************Задача 1:
    Напишите программу, которая принемает на вход число и 
    проверяет, кратно ли оно одновременно 7 и 23
    а = 50 => нет
    a = 7 => нет
    a = 322 => да
*/
System.Console.WriteLine("Задача-1:");

int a = 7; // Пользовательская переменная для изменения

if ((a % 7 == 0) & (a % 23 == 0))
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}

/*  ***********************************************************Задача 2:
    Напишите программу, которая принимает на вход координаты 
    точки (Х и Y), причем (Х != 0) и (Y !=0) и выдает номер
    координатной четверти плоскости, в которой находится эта
    точка.
    2, 3   => 1
    -5, 3  => 2
    -3, -2 => 3
    4, -2  => 4 
*/
System.Console.WriteLine("Задача-2:");

int x = -3; // Пользовательская переменная для изменения
int y = -2; // Пользовательская переменная для изменения

if (x == 0 | y == 0)
{
    System.Console.WriteLine("Sistem ERROR");
}
else if (x > 0 & y > 0)
{
    System.Console.WriteLine($"{x}, {y} => 1");
}
else if (x < 0 & y > 0)
{
    System.Console.WriteLine($"{x}, {y} => 2");
}
else if (x < 0 & y < 0)
{
    System.Console.WriteLine($"{x}, {y} => 3");
}
else if (x > 0 & y < 0)
{
    System.Console.WriteLine($"{x}, {y} => 4");
}

/*  ***********************************************************Задача 3:
    Напишите программу, которая принимает на вход целое число
    из отрезка [10,99] и показывает наибольшую цифру числа
    40 => 4
    96 => 9
    72 => 7
*/
System.Console.WriteLine("Задача-3:");

int n = 96; // Пользовательская переменная для изменения

if (n < 10 | n > 99)
{
    System.Console.WriteLine("Sistem ERROR");
}
else
{
    System.Console.WriteLine(n / 10);
}

/*  ***********************************************************Задача 4:
    Напишите программу, которая на вход принимает натуральное 
    число N, а на выходе показывает его цифры через запятую.
    568  => 5, 6, 8
    8    => 8
    9542 => 9, 5, 4, 2
*/
System.Console.WriteLine("Задача-4:");

int namN = 568; // Пользовательская переменная для изменения

if (namN / 10000 > 0 | namN == 0 | namN < 0)
{
    System.Console.WriteLine("Sistem ERROR");
}
else if (namN / 1000 > 0)
{
    Console.Write($"{namN / 1000}, ");
    namN = namN % 1000;
    Console.Write($"{namN / 100}, ");
    namN = namN % 100;
    Console.Write($"{namN / 10}, ");
    namN = namN % 10;
    Console.Write($"{namN % 10}");
}
else if (namN / 100 > 0)
{
    Console.Write($"{namN / 100}, ");
    namN = namN % 100;
    Console.Write($"{namN / 10}, ");
    namN = namN % 10;
    Console.Write($"{namN % 10}");
}
else if (namN / 10 > 0)
{
    Console.Write($"{namN / 10}, ");
    namN = namN % 10;
    Console.Write($"{namN % 10}");
}
else if (namN % 10 > 0)
{
    Console.Write($"{namN % 10}");
}

