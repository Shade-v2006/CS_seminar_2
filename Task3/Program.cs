/*
    Напишите программу, которая будет принимать на вход 
    два числа и выводить, является ли второе число 
    кратным первому. Если второе число не кратно первому
    то программа выводит остаток от деления.
    14, 5 => нет, 4
    16, 8 => да
    4,3 => нет, 1
*/

int firstNumber = 14;
int secondNumber = 5;
//int result = firstNumber % secondNumber;

if (firstNumber % secondNumber == 0)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine($"нет, {firstNumber % secondNumber}");
}

