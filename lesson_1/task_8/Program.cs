// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine($"Четные числа от 1 до {number}: ");
    for (int i = 1; i <= number; i++)
    {
        if ((i % 2 == 0)) Console.WriteLine(i);
    };
} else if (number < 0)
{
    Console.WriteLine($"Четные числа от -1 до {number}: ");
    for (int i = -1; i >= number; i--)
    {
        if ((i % 2 == 0)) Console.WriteLine(i);
    };

} else if (number == 0)
{
    Console.WriteLine("Вы ввели 0, нечего считать :)");
}