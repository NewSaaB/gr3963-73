// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число для сравнения: ");
int numA =  Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число для сравнения: ");
int numB =  Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число для сравнения: ");
int numC =  Convert.ToInt32(Console.ReadLine());
if(numA > numB)
{
    if(numA > numC)
    {
        Console.Write("Максимальное число: " + numA);
    }
    else
    Console.Write("Максимальное число: " + numC);
}
else
{
    if(numB > numC)
    {
        Console.Write("Максимальное число: " + numB);
    }
    else
    Console.Write("Максимальное число: " + numC);
}