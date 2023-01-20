// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

do
{
    try
    {
        Console.WriteLine("Введите число от 1 до 7 для определения дня недели");
        int number  = Convert.ToInt32(Console.ReadLine());

        String[] weekdayArray = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
        if (number < 6) {
            Console.WriteLine($"О нет! {weekdayArray[number-1]} - Это будний день :(");
        } else if (number > 5 && number <8) {
            Console.WriteLine($"Ура, {weekdayArray[number-1]}! Это выходной :)");
        } else Console.WriteLine("Вы указали неверное число");
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Неверный формат ввода. Введите число действительного типа");
    }
}
while (true);