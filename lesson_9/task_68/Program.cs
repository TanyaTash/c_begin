// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Gray;
Console.Clear();
void AkkerRec()
{
    do
    {
        try
        {
            Console.WriteLine("Укажите размер матрицы ниже для их произведения: ");
            int numM = InputValues("Введите значение M: ");
            int numN = InputValues("Введите значение N: ");

            int InputValues(string label)
            {
                Console.Write($"{label}");
                return Convert.ToInt32(Console.ReadLine());
            }

            int akkerman = Calculation(numM, numN);

            Console.Write($"Результат вычисления функции Аккермана: {akkerman}");

            int Calculation(int numM, int numN)
            {
                if (numM == 0) return numN + 1;
                else if (numN == 0) return Calculation(numM - 1, 1);
                else return Calculation(numM - 1, Calculation(numM, numN - 1));
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

AkkerRec();