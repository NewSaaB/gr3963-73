﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите ваше число для проверки четности: ");
int numA =  Convert.ToInt32(Console.ReadLine());
if(numA != 0)
{
    int numB = numA % 2;
    if(numB == 0)
    {
        Console.Write("Да, четное");
    }
    else
    Console.Write("Нет, не четное");
}
else
Console.Write("Не натуральное число!");