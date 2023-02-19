Random numSintezator = new Random();
int rndNumber = numSintezator.Next(100, 1000);
Console.WriteLine(rndNumber);
int lastNum = rndNumber % 10;
int firstNum = rndNumber / 100;
Console.WriteLine(lastNum);
Console.WriteLine(firstNum);
Console.WriteLine((firstNum * 10) + lastNum);

