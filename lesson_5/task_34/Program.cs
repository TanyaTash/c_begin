// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] randomArray = new int[5];
Random random = new Random();

int counter = 0;
Console.Write($"Массив чисел: ");

for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = random.Next(100, 999);
    Console.Write($"{randomArray[i]} ");
    if (randomArray[i] % 2 == 0) {
        counter++;
    }

}
Console.WriteLine($"\nЧетных чисел в массиве: {counter}");