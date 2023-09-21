// Home work 1, task 1
//Напишите программу, которая на вход принимает два числа и выдает, какое число большее а какое меньшее

Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) {
Console.WriteLine("Число A больше");
Console.WriteLine("Число B меньше");
} else {
Console.WriteLine("Число B больше");
Console.WriteLine("Число B меньше");
}