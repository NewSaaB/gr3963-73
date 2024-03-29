﻿// Задача №61
// Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного
// треугольника

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

long Factorial(int n)
{
    long res = 1;
    for (int i = 1; i <= n; i++)
    {
        res = res * i;
    }
    return res;
}

void PrintPascalTriamgle(int nRow)
{
    for (int i = 0; i < nRow; i++)
    {   
        for(int k=0; k<nRow-i; k++)
        {
            Console.Write(" ");
        }
        for(int j=0; j<=i; j++)
        {
        Console.Write(" ");
        Console.Write(Factorial(i)/(Factorial(j)*Factorial(i-j)));
        }
        Console.WriteLine();
    }
}

int countRow = ReadData("Введите количество строк треугольника Паскаля: ");
PrintPascalTriamgle(countRow);