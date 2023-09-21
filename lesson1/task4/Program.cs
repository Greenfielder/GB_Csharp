// Home work 1, task 4
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N 

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= number) {

if (count%2 == 0) {
    Console.Write(count + ", ");
}
    count++;
}

