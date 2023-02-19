Random numSintezator = new Random();
int rndNumber = numSintezator.Next(10, 100);
Console.WriteLine(rndNumber);
int firstNum = rndNumber/10;
int seconfNum = rndNumber % 10;

if(firstNum>seconfNum)
{
    Console.WriteLine(firstNum);
}
else
{
    Console.WriteLine(seconfNum);
}
