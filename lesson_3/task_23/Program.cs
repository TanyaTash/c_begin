// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число для получения таблицы кубов от 1 до N: ");
do
{
    try
    {
      int number = Convert.ToInt32(Console.ReadLine());

      void Cube (int number) {
        Console.Write($"Таблица кубов от 1 до {number}: ");
        for (int i =1; i<=number; i++) {
          if (i < number) {
            Console.Write(Math.Pow(i, 3) + ", ");
          } else Console.Write(Math.Pow(i, 3));
        }
      }

      Cube(number);
      break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Неверный формат ввода. Введите массив действительного типа");
    }
}
while (true);