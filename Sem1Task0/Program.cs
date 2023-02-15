 Console.WriteLine("Добрый день, пользователь! введи свое число");
string? inputNum = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(inputNum != null)
{
    // //Парсим строку в число
    // int number = int.Parse(inputNum);
    // //Делаем квадрат
    // //int outNum = number*number;
    // //Квадрат при помощи встроенного метода
    // int outNum = (int)Math.Pow(number, 2);

    // //выводим число
    // Console.WriteLine("Ваше число: " + outNum);

    Console.WriteLine("Ваше число: " + Math.Pow(int.Parse(inputNum),2));
}