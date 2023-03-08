// Задача №48
// Задайте двумерный массив размера m на n, каждый
// элемент в массиве находится по формуле: Aₘₙ =
// m+n. Выведите полученный массив на экран.
// Пример:
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


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
            arr[i, j] = i+j;
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

int[,] arr = Gen2DArrMod(ReadData("Введите количество строк: "), ReadData("Введите количество столбцов: "));
Print2DArrColor(arr);


