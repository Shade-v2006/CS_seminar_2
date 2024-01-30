/* 
    Программа котора принимает на вход трех значное число и возводит
    вторую цифру этого числа в степень, равную третьей цифре.
*/
int count = 487;
int digit1 = (count % 100) / 10;
int digit2 = count % 10;
int product = 1;

for (int i = digit2; i >= 1; i--)
{
    product = product * digit1;
}
Console.WriteLine(product);

// с помощью while

count = 254;
digit1 = (count % 100) / 10;
digit2 = count % 10;
product = digit1;

while (digit2 > 1)
{
    digit2--;
    product = product * digit1;
}
Console.WriteLine(product);

// third example - третий пример

count = 617;
digit1 = (count % 100) / 10;
digit2 = count % 10;
product = digit1;

while (digit2 > 1)
{
    digit2--;
    product = product * digit1;
}
Console.WriteLine(product);

// Четвертый пример - fourth example

count = 487;
double product2 = Math.Pow(count % 100 / 10, count % 10); // Math.Pow воспроизведение в степень
Console.WriteLine(product2);
