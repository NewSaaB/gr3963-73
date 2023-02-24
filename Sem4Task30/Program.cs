// Задача №30
// Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в
// случайном порядке.
// Например:
// [1,0,1,1,0,1,0,0]

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
int[] ArrayGen1D(int num, int min, int max)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i]  = new Random().Next(min, max+1);
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
int[] arrayP =  ArrayGen1D(ReadData("Введите размер массива: "), 
                ReadData("Введите минимальное число в массиве: "), 
                ReadData("Введите максимальное число в массиве: "));
ArrayPrint1D(arrayP);
