﻿int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");

}

void PrintAnswer(int num)
{
    if(num > 0 && num < 5)
    {
    if (num == 1) Console.WriteLine("x > 0, y > 0");
    if (num == 2) Console.WriteLine("x > 0, y < 0");
    if (num == 3) Console.WriteLine("x < 0, y > 0");
    if (num == 4) Console.WriteLine("x < 0, y < 0");
    }
    else Console.WriteLine("Вы ввели не номер четверти");
}

int numOf = ReadData("Введите номер четверти");
PrintAnswer(numOf);

