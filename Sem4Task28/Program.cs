// Задача №28
// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
// Например:
// 4 -> 24
// 5 -> 120
using System.Numerics;
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg)
{
    Console.WriteLine(msg);
}
BigInteger FactorCalc(int numA)
{
    BigInteger sum = 1;
    for (int i=2; i<numA; i++)
    sum = sum*i;
    return sum;
}

BigInteger num = FactorCalc(ReadData("Введите число для подсчета факторила: "));
PrintData("Фактариал числа равен: " + num);