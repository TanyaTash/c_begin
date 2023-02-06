// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
void ArithmeticMean()
{
    do
    {
        try
        {
            Console.WriteLine("Для заполнения массива случайными числами заполните параметры ниже.");
            int lineLenght = InputValues("Введите количество строк: ");
            int columnLenght = InputValues("Введите количество столбцов: ");

            double[,] numArray = new double[lineLenght, columnLenght];
            double[] middleArray = new double[columnLenght];

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
                        array[i, j] = Convert.ToDouble(new Random().Next(-128, 128));
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

            Console.WriteLine($"Среднее арифметическое столбцов:");
            for (int i = 0; i < numArray.GetLength(1); i++)
            {
                double sum = 0;
                for (int j = 0; j < numArray.GetLength(0); j++)
                {
                    sum = sum + numArray[j, i];
                }
                middleArray[i] = Math.Round(sum / numArray.GetLength(0), 0); ;
                Console.WriteLine($"{i}: {middleArray[i]};");
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

ArithmeticMean();