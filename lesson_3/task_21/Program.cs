// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты двух точек в трехмерном пространстве через запятую: (например, 3,6,8)");
Console.Write("Введите координаты точки A: ");
string ?CoordinatesA = Console.ReadLine();
Console.Write("Введите координаты точки B: ");
string ?CoordinatesB = Console.ReadLine();

string[] CoordinateArrayA = CoordinatesA.Replace(" ","").Split(',');
string[] CoordinateArrayB = CoordinatesB.Replace(" ","").Split(',');

do
{
    try
    {
        int a1 = Convert.ToInt32(CoordinateArrayA[0]);
        int a2 = Convert.ToInt32(CoordinateArrayA[1]);
        int a3 = Convert.ToInt32(CoordinateArrayA[2]);
        int b1 = Convert.ToInt32(CoordinateArrayB[0]);
        int b2 = Convert.ToInt32(CoordinateArrayB[1]);
        int b3 = Convert.ToInt32(CoordinateArrayB[2]);

        double upset =  Math.Round (Math.Sqrt(Math.Pow((b1-a1), 2) + Math.Pow((b2-a2), 2) + Math.Pow((b3-a3), 2)), 2 );
        Console.WriteLine($"Расстрояние в 3D между точками равно: {upset}");

        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Неверный формат ввода. Введите массив действительного типа");
        break;
    }
}
while (true);