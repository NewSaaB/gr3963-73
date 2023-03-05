// Напишите программу, которая будет создавать
// копию заданного одномерного массива с помощью
// поэлементного копирования.

// Принимает на вход значение, преообразует его в int

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
    

// Создает массив из num элементов со случайным наполненим от min до max

int[] ArrayGen1D(int num, int min, int max)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i]  = new Random().Next(min, max+1);
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

int[] ArrCopy( int[] arr)
{
    int[] arrNew = new int[arr.Length];
    arr.CopyTo(arrNew,0);
    return arrNew;
}

int[] arr = ArrayGen1D(ReadData("Введите длину массива: "), ReadData("Введите минмальное число массива: "), ReadData("Введите максимальное число массива: "));
ArrayPrint1D(arr);
int[] arrCopy = ArrCopy(arr);
ArrayPrint1D(arrCopy);