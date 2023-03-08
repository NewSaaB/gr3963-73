// Задача №49
// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти
// элементы на их квадраты.
// Например:
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,] Gen2DArrMod(int countRow, int countColumn)
{

    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = i + j;
        }
    }
    return arr;
}

void Print2DArrColor(int[,] arr)
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

int[,] Gen2DarrModUpgrade(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i += 2)
    {
        for (int j = 0; j < arr.GetLength(1); j += 2)
        {
            arr[i, j] = arr[i, j]*arr[i, j];
        }
    }
    return arr;
}

int[,] arr = Gen2DArrMod(ReadData("Введите количество строк: "), ReadData("Введите количество столбцов: "));
Print2DArrColor(arr);
Console.WriteLine("--------------------------");
int[,] arr2 = Gen2DarrModUpgrade(arr);
Print2DArrColor(arr2);