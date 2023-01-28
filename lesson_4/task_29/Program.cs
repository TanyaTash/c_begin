// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] randomArray = new int[10];
Random random = new Random();
for (int i = 0; i < randomArray.Length; i++)
{
    if (i + 1 != randomArray.Length)
    {
        randomArray[i] = random.Next(0, 10);
        Console.Write(randomArray[i] + ", ");
    }
    else
    {
        randomArray[i] = random.Next(0, 10);
        Console.Write(randomArray[i] + "");
    }

}