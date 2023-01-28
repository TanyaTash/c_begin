// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

do
{
    try
    {
        Console.WriteLine("Введите пятизначное число");
        int number  = Convert.ToInt32(Console.ReadLine());
        string numberString = Convert.ToString(number);

        if (numberString.Length == 5) {

            if (numberString[0] == numberString[4] && numberString[1] == numberString[3]) {
                    Console.WriteLine("Число является палиндромом");
            } else Console.WriteLine("Число не является палиндромом");

        } else Console.WriteLine("Число должно быть пятизначным, повторите попытку");
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Неверный формат ввода. Введите число действительного типа");
    }
}
while (true);