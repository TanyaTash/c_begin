// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
//  1  2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Gray;
Console.Clear();
void SpiralArray()
{
    do
    {
        try
        {
            Console.WriteLine("Укажите размер матрицы ниже для их произведения: ");
            int lineLenght = InputValues("Введите количество строк: ");
            int columnLenght = InputValues("Введите количество столбцов: ");

            int InputValues(string label)
            {
                Console.Write($"{label}");
                return Convert.ToInt32(Console.ReadLine());
            }

            var numArray = ArrayFill(lineLenght, columnLenght);
            var arraySpiral = GetArray(lineLenght, columnLenght, numArray.number, numArray.arrayNumber);

            int[,] spiral = CreateSpiral(lineLenght, columnLenght, arraySpiral.num, arraySpiral.arrayNum);
            Console.WriteLine("\nСпиральная матрица: ");
            PrintArray(spiral);


            (int[,] arrayNumber, int number) ArrayFill(int m, int n)
            {
                int[,] array = new int[m, n];
                int number = 1;

                for (int i = 0; i < n; i++)
                {
                    array[0, i] = number;
                    number++;
                }
                for (int j = 1; j < m; j++)
                {
                    array[j, m - 1] = number;
                    number++;
                }
                for (int i = n - 2; i >= 0; i--)
                {
                    array[m - 1, i] = number;
                    number++;
                }
                for (int j = m - 2; j > 0; j--)
                {
                    array[j, 0] = number;
                    number++;
                }

                return (array, number);
            }

            (int[,] arrayNum, int num) GetArray(int m, int n, int number, int[,] array)
            {
                int i = 1;
                int j = 1;
                while (number < m * n)
                {
                    while (array[i, j + 1] == 0)
                    {
                        array[i, j] = number;
                        number++;
                        j++;
                    }
                    while (array[i + 1, j] == 0)
                    {
                        array[i, j] = number;
                        number++;
                        i++;
                    }
                    while (array[i, j - 1] == 0)
                    {
                        array[i, j] = number;
                        number++;
                        j--;
                    }
                    while (array[i - 1, j] == 0)
                    {
                        array[i, j] = number;
                        number++;
                        i--;
                    }
                }
                return (array, number);
            }

            int[,] CreateSpiral(int m, int n, int number, int[,] array)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (array[i, j] == 0)
                        {
                            array[i, j] = number;
                        }
                    }
                }
                return array;
            }

            void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] < 10)
                        {
                            Console.Write($"{array[i, j]}  ");
                        }
                        else
                        {
                            Console.Write($"{array[i, j]} ");
                        }
                    }
                    Console.WriteLine();
                }
            }

            break;
        }
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("Неверный формат ввода. Введите действительное положительное число");
            resetConsole();

            void resetConsole()
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
    while (true);
}

SpiralArray();

