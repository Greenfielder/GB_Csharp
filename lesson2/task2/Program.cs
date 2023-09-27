// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1-7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 5 && number > 0 ) 
{
    Console.WriteLine("Рабочий день");
} 
else if (number == 6 || number == 7)
{
    Console.WriteLine("Выходной день");
} 
else 
{
    Console.WriteLine("Такого дня нет");    
}
