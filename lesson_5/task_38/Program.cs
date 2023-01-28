//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] randomArray = new int[6];
Random random = new Random();

Console.Write($"Массив чисел: ");

for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = random.Next(1, 99);
    Console.Write($"{randomArray[i]} ");
}

int min = randomArray[0];
int max = randomArray[0];

for (int i = 0; i < randomArray.Length; i++) {
    if (randomArray[i] < min) {
        min = randomArray[i];
    }

    if (randomArray[i] > max) {
        max = randomArray[i];
    }
}

int result = max - min;

Console.WriteLine($"\nНаименьшее число в массиве {min} \nНаибольшее число в массиве: {max} \nРазница между максимальным и минимальным: {result}");