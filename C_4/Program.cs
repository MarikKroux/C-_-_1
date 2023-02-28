//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите 1 целое число: ");
int a = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите 2 целое число: ");
int b = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите 3 целое число: ");
int c = int.Parse(Console.ReadLine() ?? "");

int max = a;

if (b>max) max = b;
if (c>max) max = c;

Console.WriteLine($"{a}, {b}, {c} -> {max}");