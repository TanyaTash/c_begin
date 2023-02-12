// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
void MainArray()
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
            Console.WriteLine("Исходный массив: ");
            ArrayOutput(numArray);
            SortArray();
            Console.WriteLine("\nОтсортированный массив по убыванию: ");
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

            void SortArray()
            {
                double tmp = 0;
                for (int i = 0; i < numArray.GetLength(0); i++)
                {
                    for (int j = 1; j < numArray.GetLength(1); j++)
                    {
                        for (int n = 1; n < numArray.GetLength(1); n++)
                        {
                            if (numArray[i, n] > numArray[i, n - 1])
                            {
                                tmp = numArray[i, n - 1];
                                numArray[i, n - 1] = numArray[i, n];
                                numArray[i, n] = tmp;
                            }
                        }
                    }
                }
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

MainArray();

