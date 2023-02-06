//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.Clear();
void RandomNums()
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

RandomNums();