Console.Write("Введите ваше число: ");
var num = Convert.ToInt32(Console.ReadLine());
var res = num  % 10;
Console.WriteLine("Последняя цифра: " + res);