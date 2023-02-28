//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите 1 целое число: ");
int a = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите 2 целое число: ");
int b = int.Parse(Console.ReadLine() ?? "");

if (a > b)
    Console.WriteLine($"a={a}, b={b} -> max={a}");
else if (a < b)
    Console.WriteLine($"a={a}, b={b} -> max={b}");
else
    Console.WriteLine($"a={a}, b={b} -> Числа равны");