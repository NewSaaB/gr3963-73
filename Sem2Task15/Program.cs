﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// * Сделать вариант с использованием конструкции Dictionary


// // первый вариант решения
// Console.Write("Введите день недели: ");
// int day = Convert.ToInt32(Console.ReadLine());
// if(day == 6 || day == 7)
// {
//     Console.Write("Ваш день является выходным ");
// }
// else
// {
//     Console.Write("Ваш день не является выходным ");
// }


//Вариант решения со звездочки  
Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
var dayKey = new Dictionary<int, string>()
{
    { 1, "Нет, это рабочий день"},
    { 2, "Нет, это рабочий день"},
    { 3, "Нет, это рабочий день"},
    { 4, "Нет, это рабочий день"},
    { 5, "Нет, это рабочий день"},
    { 6, "Да, это выходной!!!"},
    { 7, "Да, это выходной!!!"}
};
Console.WriteLine(dayKey[day]);