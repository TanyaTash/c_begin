// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] randomArray = new int[4];
Random random = new Random();
int sum = 0;

Console.Write($"Массив чисел: ");

for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = random.Next(-99, 99);
    Console.Write($"{randomArray[i]} ");

    if (Array.IndexOf(randomArray, randomArray[i]) % 2 != 0) {
        sum = sum + randomArray[i];
    }

}
Console.WriteLine($"\nСумма элементов на нечетных позициях: {sum}");