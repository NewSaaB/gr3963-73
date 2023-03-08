// №47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

double[,] Gen2DArrDouble(int countRow, int countColumn, int min, int max)
{
    // Корректировка входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    
    double[,] arr = new double[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = new Random().Next(min, max) + Math.Round(new Random().NextDouble(),2);;
        }
    }
    return arr;
}

void Print2DArrColor(double[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Blue,ConsoleColor.Red,ConsoleColor.White};

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0,3)];
            Console.Write(arr[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

double[,] arr = Gen2DArrDouble(ReadData("Введите количество строк: "), ReadData("Введите количество столбцов: "), ReadData("Введите минимальное значение: "), ReadData("Введите максимальное число: "));
Print2DArrColor(arr);