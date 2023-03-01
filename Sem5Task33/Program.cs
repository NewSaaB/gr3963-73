// Задача №33
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// Например:
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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

int SearchNumInArray(int[] array, int num)
{
    int res = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            res = i;
            break;
        }

        
    }
    return res;
}

int[] array = ArrayGen1D(ReadData("Введите длину массива: "), ReadData("Введите минмальное число массива: "), ReadData("Введите максимальное число массива: "));
int num = ReadData("Какое число вы хотите найти? Введите: ");
ArrayPrint1D(array);
int search = SearchNumInArray(array, num);
if (search >= 0)
{
    Console.WriteLine($"Ваше число {num} находится в позиции {search + 1}");
}
else
{
    Console.WriteLine($"Вашего числа {num} нигде нет в массиве :( ");
}

