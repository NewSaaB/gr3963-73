Console.Write("Введите ваше число: ");
var day = Convert.ToInt32(Console.ReadLine());
var negDay = -day;
for (; negDay <= day; negDay++)
{
    Console.WriteLine(negDay + "\t");
}