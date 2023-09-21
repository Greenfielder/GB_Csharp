// Home work 1, task 2
//Напишите программу, которая на вход принимает три числа и выдает максимальное их этих чисел

Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c) {
    Console.WriteLine("Число A больше");
} else if (b > a && b > c){
    Console.WriteLine("Число B больше");
} else if (c > a && c > b){
    Console.WriteLine("Число C больше");
} else {
    Console.WriteLine("Что-то пошло не так");
}

