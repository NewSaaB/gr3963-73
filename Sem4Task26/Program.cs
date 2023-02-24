// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.
// Пример:
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg)
{
    Console.WriteLine(msg);
}
int DigitSum(int num)
{
    return (int)Math.Log10(num) + 1;
}


int len = DigitSum(ReadData("Введите ваше число: "));
PrintData("Количество цифр в числе: " + len);