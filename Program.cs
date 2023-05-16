bool IsGustimationCorrect = false;
Random random = new Random();
int randomNum = random.Next(1,101);
Console.WriteLine(" Guess a number");
while(!IsGustimationCorrect&&(Console.ReadKey(true).Key != ConsoleKey.X))
{
    Console.WriteLine("");
    int guessedNum = Convert.ToInt32(Console.ReadLine());
    if (guessedNum < randomNum)
    {
        Console.WriteLine("It is too small!");
    }
    else if (guessedNum > randomNum)
    {
        Console.WriteLine("It is too big!");
    }
    else 
    {
        Console.WriteLine("True! You won");
    }
}
