int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

string DecToBin(int num)
{
    string res = "";
    while (num > 0)
    {
        res = num % 2 + res;
        num /= 2;
    }
    return res;
}

Console.WriteLine($"Ваше число в двоичной системе: {DecToBin(ReadData("Введите число: "))}");
