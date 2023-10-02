// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Введите степень: ");
int extent = int.Parse(Console.ReadLine());

int Degree(int number, int extent)
{
    int degree = 1;
    for (int i = 0; i < extent; i++)
    {
        degree = degree * number;
    }
    return degree;
}

Console.WriteLine(Degree(number, extent));