// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

            double lineResult = 0;
            double sumLine = SumString(numArray, 0);
            for (int i = 1; i < numArray.GetLength(0); i++)
            {
                double tmpSumLine = SumString(numArray, i);
                if (sumLine > tmpSumLine)
                {
                    sumLine = tmpSumLine;
                    lineResult = i;
                }
            }

            Console.WriteLine($"\n{lineResult + 1} строкa с наименьшей суммой элементов: {sumLine}");

            double SumString(double[,] array, int i)
            {
                double sumLine = array[i, 0];
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    sumLine += array[i, j];
                }
                return sumLine;
            }

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

