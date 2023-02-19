

int firstNum = Convert.ToInt32(Console.ReadLine());
int secondNum = Convert.ToInt32(Console.ReadLine());
if(firstNum % secondNum == 0)
{
    Console.WriteLine("Кратно");
    
}
else
{
    Console.WriteLine("не кратно, " + firstNum%secondNum);        

}