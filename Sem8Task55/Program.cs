// Задача №55
// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае,
// если это невозможно, программа должна вывести
// сообщение для пользователя.

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
{
    // Корректировка входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    Random rnd = new Random();
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void Print2DArr(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0, 16)];
            Console.Write(arr[i, j] + "\t ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

bool TurnOverBool(int countRow, int countColumn)
{
    bool res = false;
    if (countColumn == countRow)
    {
        res = true;
        
    }

    return res;
}

void TurnOverArr(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i + 1; j < arr.GetLength(1); j++)
        {
            temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = arr[i, j];
        }
    }

}

int a = ReadData("Введите количество строк вашего массива: ");
int b = ReadData("Введите количество столбцов вашего массива: ");
int[,] arr = Gen2DArr(a, b, ReadData("Введите минмальное значение вашего массива: "),
                        ReadData("Введите максимальное значние вашего массива: "));

Print2DArr(arr);

if (TurnOverBool(a, b))
{
    TurnOverArr(arr);
    Console.WriteLine("");
    Print2DArr(arr);
}
else
{
    Console.WriteLine("Извините, у вас не квадратная матрица, попробуйте еще раз");
}
