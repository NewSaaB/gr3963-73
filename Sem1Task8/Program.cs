// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите ваше число: ");
var numA = Convert.ToInt32(Console.ReadLine());
int numB = 2;
for (; numB <= numA; numB = numB + 2)
{
    Console.WriteLine(numB + "\t");
}