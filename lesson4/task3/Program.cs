// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int lenght = 8;

int[] ArrayGenerator()
{
    int min = 1;
    int max = 99;
    int[] array = new int[lenght];
    Random rnd = new Random();

    for (int i = 0; i < lenght; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void formatedArrayPrint(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < lenght - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[lenght - 1]);
    Console.Write("]");
}

int[] mainArray = ArrayGenerator();
formatedArrayPrint(mainArray);