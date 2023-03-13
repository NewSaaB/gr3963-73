// Задача №53
// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю
// строку массива.
// ==============================================================================

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

int[,] Gen2DArrRevers(int[,] arr, int a, int b)
{
    if (a < 1 || b < 1)
    {
        Console.WriteLine($"Одно из ваших чисел {a} или {b} меньше 1, такой строчки нет.");
    }
    else if (a > arr.GetLength(0) || b > arr.GetLength(0))
    {
        Console.WriteLine($"Одно из ваших чисел {a} или {b} вышло за пределы массива.");
    }

    int[,] arrRevers = arr.Clone() as int[,];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        arrRevers[b - 1, i] = arrRevers[a - 1, i];
        arrRevers[a - 1, i] = arr[b - 1, i];

    }
    return arrRevers;
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int min = ReadData("Введите минимальное значение в матрице: ");
int max = ReadData("Введите максимальное значение в матрице: ");
int[,] arr = Gen2DArr(row, column, min, max);
Print2DArr(arr);
int swiatchA = ReadData("Введите номер строки который вы хотите поменять: ");
int swiatchB = ReadData("Введите номер строки на которую вы хотите поменять: ");
int[,] arr2 = Gen2DArrRevers(arr, swiatchA, swiatchB);
Console.WriteLine($"Готово, мы поменяли строку {swiatchA} с {swiatchB}.");
Print2DArr(arr2);