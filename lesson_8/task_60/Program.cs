// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Gray;
Console.Clear();
void MainArray()
{
    do
    {
        try
        {
            Console.WriteLine("Укажите размер матрицы ниже для их произведения: ");
            int coorX = InputValues("Введите длину X: ");
            int coorY = InputValues("Введите длину Y: ");
            int coorZ = InputValues("Введите длину Z: ");

            int InputValues(string label)
            {
                Console.Write($"{label}");
                return Convert.ToInt32(Console.ReadLine());
            }

            int[,,] randomArray = new int[coorX, coorY, coorZ];
            if ((coorX * coorY * coorZ) > 90)
            {
                Console.WriteLine("\nМассив слишком большой");
                return;
            }
            FillArray(randomArray, coorX, coorY, coorZ);
            Console.WriteLine("\nСгенерированный массив с индексами:");
            PrintArray(randomArray);

            int[,,] FillArray(int[,,] array, int coorX, int coorY, int coorZ)
            {
                int arrRow = 9;
                int arrCol = 10;
                int step = 10;
                int[,] referenceArray = new int[arrRow, arrCol];

                for (int i = 0; i < referenceArray.GetLength(0); i++)
                {
                    for (int j = 0; j < referenceArray.GetLength(1); j++)
                    {
                        referenceArray[i, j] = step;
                        step++;
                    }
                }

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int n = 0; n < array.GetLength(2); n++)
                        {
                        Repeat:
                            int arrRowIndx = new Random().Next(0, 9);
                            int arrColIndx = new Random().Next(0, 10);
                            if (referenceArray[arrRowIndx, arrColIndx] != 0)
                            {
                                array[i, j, n] = referenceArray[arrRowIndx, arrColIndx];
                                referenceArray[arrRowIndx, arrColIndx] = 0;
                            }
                            else
                            {
                                goto Repeat;
                            }
                        }
                    }
                }
                return array;
            }

            void PrintArray(int[,,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int n = 0; n < array.GetLength(2); n++)
                        {
                            Console.Write($"{array[i, j, n]}[{i},{j},{n}] ");
                        }
                        Console.Write("\n");
                    }
                    Console.Write("\n");
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

MainArray();
