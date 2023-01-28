// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите положительное число: ");
do
{
    try
    {
        int number = Convert.ToInt32(Console.ReadLine());
        int[] numberArray = number.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
        int result = 0;

        for (int i = 0; i < numberArray.Length; i++)
        {

            result = result + numberArray[i];

        }
        Console.WriteLine($"Результат равен: {result}");
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Неверный формат ввода. Введите действительное положительное число");
    }
}
while (true);