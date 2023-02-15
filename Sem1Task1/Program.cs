Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Проверяем, является ли первое число квадратом второго...");
if(num1 != 0 && num2 != 0)
{
    if(num2*num2 == num1)
    {
        Console.WriteLine("Да, Является!!!");
    }
    else
    {
        Console.WriteLine("Не в этот раз");
    }
}