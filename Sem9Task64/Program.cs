// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.
// N = 5 -> "1, 2, 3, 3, 4"
// N = 8 -> "1, 2, 3, 4, 5, 6, 7, 8"

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

// Функция рекурсии
string LineGenRec(int N, int numer)
{
    string res = String.Empty;

    if (numer <= N)
    {
        res += numer + " " + LineGenRec(N, numer + 1);
        return res;
    }
    else
    {

        return res;
    }
}

// ======================
// Основной код программы
// ======================

int number = ReadData("Введите число N: ");
string resultLine = LineGenRec(number, 1);
PrintResult(resultLine);