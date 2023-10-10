// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

string[] input()
{
    Console.WriteLine("Введите значения b1, k1, b2 и k2 через пробел:");
    string[] coordinates = Console.ReadLine().Split(' ');
    return coordinates;
}

void validator(string[] coordinates)
{
    double b1 = double.Parse(coordinates[0]);
    double k1 = double.Parse(coordinates[1]);
    double b2 = double.Parse(coordinates[2]);
    double k2 = double.Parse(coordinates[3]);
    if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны, нет точки пересечения.");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения прямых: ({x}, {y})");
    }
}

string[] coordinates = input();
validator(coordinates);