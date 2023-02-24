int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg)
{
    Console.WriteLine(msg);
}
int SumSimple(int numA)
{
    int sum = numA;
    for (int i=0; i<numA; i++)
    sum+=i;
    return sum;
}
int SumGausse(int numA)
{
        return  ((1 + numA)*numA)/2;
}

int numOf = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
int res1 = SumSimple(numOf);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = SumGausse(numOf);
Console.WriteLine(DateTime.Now - d2);

PrintData("Ваш результат: " + res1);
PrintData("Ваш результатпо методу Гаусса: " + res2);