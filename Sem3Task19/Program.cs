// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов




// //Решение для 5ти значного числа
// //Метод для возвращения числа от пользователя
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }
// //метод для проверки палиндром или нет
// bool PalinTest(int numTest)
// {
//     bool res = false;
//     if (numTest / 10000 == numTest % 10 && (numTest / 1000) % 10 == (numTest / 10) % 10)
//     {
//         res = true;
//     }
//     return res;
// }
// //решение
// int num = ReadData("введите 5-ти значне число: ");
// if (PalinTest(num))
// {
//     Console.WriteLine("Ваше число - палиндром");
// }
// else
// {
//     Console.WriteLine("Ваше число - не палиндром");
// }


//Решение для задачи со звездочкой
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//метод который принимает 5и значное число и возвращает 4х значное
int FourNum(int fiveNum)
{
    int fourNum = (fiveNum / 10000) * 1000 + ((fiveNum / 1000) % 10) * 100 + ((fiveNum / 10) % 10) * 10 + fiveNum % 10;
    return fourNum;
}
//словарь со всеми 90 числами
var polAll = new Dictionary<int, bool>()
{
    { 1111, true},  { 2222, true},  { 3333, true},  { 4444, true}, { 5555, true},  { 6666, true},  { 7777, true},  { 8888, true}, { 9999, true}, { 9009, true},
    { 1221, true},  { 2112, true},  { 3223, true},  { 4114, true}, { 5115, true},  { 6116, true},  { 7117, true},  { 8118, true}, { 9119, true}, { 8008, true},
    { 1331, true},  { 2332, true},  { 3113, true},  { 4224, true}, { 5225, true},  { 6226, true},  { 7227, true},  { 8228, true}, { 9229, true}, { 7007, true},
    { 1441, true},  { 2442, true},  { 3443, true},  { 4334, true}, { 5335, true},  { 6336, true},  { 7337, true},  { 8338, true}, { 9339, true}, { 6006, true},
    { 1551, true},  { 2552, true},  { 3553, true},  { 4554, true}, { 5445, true},  { 6446, true},  { 7447, true},  { 8448, true}, { 9449, true}, { 5005, true},
    { 1661, true},  { 2662, true},  { 3663, true},  { 4664, true}, { 5665, true},  { 6556, true},  { 7557, true},  { 8558, true}, { 9559, true}, { 4004, true},
    { 1771, true},  { 2772, true},  { 3773, true},  { 4774, true}, { 5775, true},  { 6776, true},  { 7667, true},  { 8668, true}, { 9669, true}, { 3003, true},
    { 1881, true},  { 2882, true},  { 3883, true},  { 4884, true}, { 5885, true},  { 6886, true},  { 7887, true},  { 8778, true}, { 9779, true}, { 2002, true},
    { 1991, true},  { 2992, true},  { 3993, true},  { 4994, true}, { 5995, true},  { 6996, true},  { 7997, true},  { 8998, true}, { 9889, true}, { 1001, true}
};

//решение
int num = FourNum(ReadData("введите пятизначное число: "));
if(polAll[num])
{
    Console.WriteLine("Да, это полиндром");
}
else
{
    Console.WriteLine("Нет, это не полиндром");
}