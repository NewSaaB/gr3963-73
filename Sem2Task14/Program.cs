// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно 7 и
// 23.
// Например:
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
bool oper = (num % 7 == 0 && num % 23 == 0);
if (oper)
{
    Console.WriteLine("Кратно 7 и 23 одновременно");

}
else
{
    Console.WriteLine("не кратно 7 и 23 одновременно");

}