// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
do
{
    try
    {
        Console.Write("Введите число для возведения в степень: ");
        int numberFirst = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите натуральное число для степени: ");
        int numberSecond = Convert.ToInt32(Console.ReadLine());

        if (numberSecond > 0)
        {
            int result = numberFirst;

            for (int i = 1; i < numberSecond; i++)
            {
                result = result * numberFirst;
            }

            Console.WriteLine($"Результат циклом: {result}");
            Console.WriteLine($"Результат функцией Math.Pow: {Math.Pow(numberFirst, numberSecond)}");
        } else Console.WriteLine("Вы ввели неверное число");

        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Неверный формат ввода. Введите натуральное число");
    }
}
while (true);