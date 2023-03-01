// Задача №37
// Найдите произведение пар чисел в одномерном
// массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат
// запишите в новом массиве.
// Например:
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

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

void ArrayPrint1D(int[] arrayPrint)
{
    Console.Write("[ ");
    for (int i = 0; i < arrayPrint.Length - 1; i++)
    {
        Console.Write(arrayPrint[i] + ", ");
    }
    Console.WriteLine(arrayPrint[arrayPrint.Length - 1] + " ]");

}

int[] ConvertArray(int[] arr)
{
    int len = arr.Length / 2;
    if (arr.Length % 2 == 1)
    {
        len++;
    }

    int[] arrNew = new int[len];

    for (int i = 0; i < len; i++)
    {
        arrNew[i] = arr[i] * arr[arr.Length - 1 - i];
    }

    return arrNew;
}

int[] arrayIn = ArrayGen1D(ReadData("Введите длину массива: "), ReadData("Введите минмальное число массива: "), ReadData("Введите максимальное число массива: "));
ArrayPrint1D(arrayIn);
int[] arrayOf = ConvertArray(arrayIn);
ArrayPrint1D(arrayOf);