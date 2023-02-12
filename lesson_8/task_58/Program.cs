// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Gray;
Console.Clear();
void MainMatrix()
{
    do
    {
        try
        {

            Console.WriteLine("Укажите размер матрицы ниже для их произведения: ");
            int lineLenght = InputValues("Введите количество строк: ");
            int columnLenght = InputValues("Введите количество столбцов: ");

            int[,] firstArray = CreateMatrix(lineLenght, columnLenght);
            int[,] secondArray = CreateMatrix(lineLenght, columnLenght);
            int[,] resultArray = new int[lineLenght, columnLenght];


            Console.WriteLine("\nПервая матрица:");
            PrintMatrix(firstArray);

            Console.WriteLine("\nВторая матрица:");
            PrintMatrix(secondArray);
            MatrixMultiplication(firstArray, secondArray, resultArray);

            Console.WriteLine($"\nПроизведение двух матриц:");
            PrintMatrix(resultArray);

            int InputValues(string label)
            {
                Console.Write($"{label}");
                return Convert.ToInt32(Console.ReadLine());
            }

            int[,] CreateMatrix(int m, int n)
            {
                int[,] matrix = new int[m, n];
                Random rnd = new Random();
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = rnd.Next(2, 5);
                    }
                }
                return matrix;
            }

            void PrintMatrix(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (j == 0) Console.Write("[");
                        if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3},");
                        else Console.Write($"{array[i, j],3} ]");
                    }
                    Console.WriteLine();
                }
            }
            void MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
            {
                for (int i = 0; i < resultMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < resultMatrix.GetLength(1); j++)
                    {
                        int sum = 0;
                        for (int k = 0; k < firstMatrix.GetLength(1); k++)
                        {
                            sum += firstMatrix[i, k] * secondMatrix[k, j];
                        }
                        resultMatrix[i, j] = sum;
                    }
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

MainMatrix();
