//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите целое число: ");
int N = int.Parse(Console.ReadLine() ?? "");

int i = 2;

if (N < 2) Console.WriteLine("Введите значение больше 1!");
else
{
    Console.Write($"{N} -> ");
    while (i <= N)
    {
        if (i % 2 == 0) Console.Write($"{i} ");
        i++;
    }
}
