// Home work 1, task 3
//Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится на 2 без остатка)

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number%2 == 0) {
    Console.WriteLine("Число чётное");
} else {
    Console.WriteLine("Число не чётное");
}