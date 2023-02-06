// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
void CheckArray()
{
    do
    {
        try
        {
            Console.WriteLine("Для заполнения массива случайными числами заполните параметры ниже.");
            int lineLenght = InputValues("Введите количество строк: ");
            int columnLenght = InputValues("Введите количество столбцов: ");

            double[,] numArray = new double[lineLenght, columnLenght];

            int InputValues(string label)
            {
                Console.Write($"{label}");
                return Convert.ToInt32(Console.ReadLine());
            }

            RandomNumbers(numArray);
            ArrayOutput(numArray);

            void RandomNumbers(double[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = Convert.ToDouble(new Random().Next(-128, 128)) / 10;
                    }
                }
            }

            void ArrayOutput(double[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.Write("[ ");
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.Write("]");
                    Console.WriteLine("");
                }
            }

            int row = InputValues("Введите индекс строки: ");
            int col = InputValues("Введите индекс столбца: ");

            if (row < 0 || col < 0 || row > numArray.GetLength(0) || col > numArray.GetLength(1))
            {
                Console.WriteLine("По заданному индексу не было найдено ни одного значения");
            }
            else
            {
                Console.WriteLine(numArray[row, col]);
            }
            break;
        }
        catch (FormatException)
        {
            Console.Clear();
            Console.WriteLine("Неверный формат ввода. Введите действительное положительное число");
        }
    }
    while (true);
}

CheckArray();