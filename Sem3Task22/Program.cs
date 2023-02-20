int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
string LineBuilder(int num, int pow)
{
    string res = String.Empty;
    for (int i = 1; i <= num; i++)
    {
        res = res + Math.Pow(i, pow) + "\t ";
    }
    return res;
}
int nOf = ReadData("Введите число до какого числа показать: ");
int pOf = ReadData("Введите в какую степень возввести числа: ");
Console.WriteLine(LineBuilder(nOf, 1));
Console.WriteLine(LineBuilder(nOf, pOf));