// Задача №32
// Напишите программу замена элементов массива:
// положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// Пример:
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


// Создает массив из num элементов со случайным наполненим от min до max

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

void InversArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}

int[] array = ArrayGen1D(ReadData("Введите длинну массива: "), ReadData("Введите минмальное число массива: "), ReadData("Введите максимальное число массива: "));
ArrayPrint1D(array);
InversArray(array);
ArrayPrint1D(array);