// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int readNum(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void inArray(int lenght)
{
    int count = 0;
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = readNum("Введите число");
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine("Количество чисел больше 0: " + count);
}

int lenght = readNum("Введите количиство вводимых чисел");
inArray(lenght);