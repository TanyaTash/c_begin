// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите числа через запятую:");
string[] numbers = Console.ReadLine().Split(',');
int firstNumber = int.Parse(numbers[0]);

foreach (var number in numbers)
{
    int ecahNumber = int.Parse(number);
    if (ecahNumber > firstNumber)
    {
        firstNumber = ecahNumber;
    };
};
System.Console.WriteLine($"Самое большое число: {firstNumber}");