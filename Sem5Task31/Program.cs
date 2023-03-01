// Задача №31
// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных
// элементов массива.
// Например:
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// сумма положительных чисел равна 29, сумма
// отрицательных равна -20

// Принимает на вход значение, преообразует его в int
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Создает массив из num элементов со случайным наполненим от min до max
int[] ArrayGen1D(int num, int min, int max)
{
    if (min > max)
    {
        (min, max) = (max, min);
    }

    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

// Печатает все элементы массива
void ArrayPrint1D(int[] arrayPrint)
{
    Console.Write("[ ");
    for (int i = 0; i < arrayPrint.Length - 1; i++)
    {
        Console.Write(arrayPrint[i] + ", ");
    }
    Console.WriteLine(arrayPrint[arrayPrint.Length - 1] + " ]");

}

void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

(int posit, int negot) SumCalk(int[] array)
{
        int positSum = 0;
    int negatSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            positSum += array[i];
        }
        else
        {
            negatSum += array[i];
        }
    }

    return (positSum, negatSum);
}


int[] testArr = ArrayGen1D(ReadData("Введите длинну массива: "), ReadData("Введите минимальное значение массива: "), ReadData("Введите максимальную длину массива: "));
ArrayPrint1D(testArr);
(int posit, int negot) resultes = SumCalk(testArr);
PrintData("Сумма положительных чисел: ", resultes.posit );
PrintData("Сумма отрицательных чисел: ", resultes.negot );