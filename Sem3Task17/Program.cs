int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");

}
void PrintQuterTest(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("Точка в 1ой четверти");
    if (x < 0 && y > 0) Console.WriteLine("Точка в 4ой четверти");
    if (x > 0 && y < 0) Console.WriteLine("Точка в 2ой четверти");
    if (x < 0 && y < 0) Console.WriteLine("Точка в 3ой четверти");
}

int coordX = ReadData("введите координату X: ");
int coordY = ReadData("введите координату Y: ");
PrintQuterTest(coordX,coordY);

