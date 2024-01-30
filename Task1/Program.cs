// Программа которая принимает на вход трехзначное число и удаляет вторую цифру

int a = 256;

int digitSecond = (a / 100 * 10) + (a % 10);
Console.WriteLine(digitSecond);

a = 891;
digitSecond = (a / 100 * 10) + (a % 10);
Console.WriteLine(digitSecond);

