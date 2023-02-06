// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
using System.Text.RegularExpressions;

Console.WriteLine("Введите массив чисел через запятую: (например 0, 7, 8, -2, -2): ");
string[] numArray = Console.ReadLine().Replace(" ", "").Split(',');
string pattern = @"[0-9]";

int counter = 0;
int checker = 0;

void Compare(string[] numArray)
{
    for (int i = 0; i < numArray.Length; i++)
    {
        if (Regex.IsMatch(numArray[i], pattern, RegexOptions.IgnoreCase))
        {
            if (Convert.ToInt32(numArray[i]) > 0)
            {
                counter++;
            }
        }
        else checker++;
    }

    Console.WriteLine($"Чисел больше 0 введено: {counter}");

    if (checker > 0)
    {
        Console.WriteLine($"В массиве так же были указаны другие символы, они не были учтены");
    }
}
 
Compare(numArray);