// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Gray;
Console.Clear();
void SumNum()
    {
    do
    {
        try
        {
            int numM = InputValues("Введите значение M: ");
            int numN = InputValues("Введите значение N: ");

            int InputValues(string label)
            {
                Console.Write($"{label}");
                return Convert.ToInt32(Console.ReadLine());
            }

            countSum(numM, numN, 0);

            void countSum(int numM, int numN, int summ)
            {
                summ = summ + numN;
                if (numN <= numM)
                {
                    Console.Write($"Сумма натуральных элементов в промежутке равна: {summ} ");
                    return;
                }
                countSum(numM, numN - 1, summ);
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

SumNum();

