// Задача №39
// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)
// Например:
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
// Комментарий: эту задачу можно решить 2 способами: 1)
// менять числа местами в исходном массиве; 2) создать
// новый массив и в него записать перевёрнутый исходный
// массив по элементам.

// Создает массив из num элементов со случайным наполненим от min до max
int[] ArrayGen1D(int num, int min, int max)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

// Печатает 1д массив
void ArrayPrint1D(int[] arrayPrint)
{
    Console.Write("[ ");
    for (int i = 0; i < arrayPrint.Length - 1; i++)
    {
        Console.Write(arrayPrint[i] + ", ");
    }
    Console.WriteLine(arrayPrint[arrayPrint.Length - 1] + " ]");

}

// Принимает на вход значение, преообразует его в int
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Принимает на вход массив, переварачивает его и возвращает в новом массиве
int[] ArrayRevers(int[] arr)
{
    int[] arrRevers = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arrRevers[i] = arr[arr.Length - 1 - i];
    }
    return arrRevers;
}

int[] arr = ArrayGen1D(ReadData("Введите длину массива: "), ReadData("Введите минмальное число массива: "), ReadData("Введите максимальное число массива: "));
ArrayPrint1D(arr);
int[] arrRevers = ArrayRevers(arr);
ArrayPrint1D(arrRevers);
