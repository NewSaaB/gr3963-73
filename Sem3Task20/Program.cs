int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg, double val)
{
    Console.WriteLine(msg + val);
}
double CalkLen(int x1, int x2, int y1, int y2)
{
    return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
}
int xU1 = ReadData("Введите x1 точки А: ");
int yU1 = ReadData("Введите y1 точки А: ");
int xU2 = ReadData("Введите x2 точки Б: ");
int yU2 = ReadData("Введите y2 точки Б: ");
double res = CalkLen(xU1, xU2, yU1, yU2);
PrintData("Расстояние между точками А и Б: ", res);
