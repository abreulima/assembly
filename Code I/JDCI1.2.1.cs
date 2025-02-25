int HighestOfFour()
{
    int max = int.MinValue;
    int currentNumber;

    Console.WriteLine("Type 4 numbers!");
    for (int i = 0; i < 4; i++)
    {
        currentNumber = int.Parse(Console.ReadLine());
        if (currentNumber > max)
            max = currentNumber;
    }
}

Console.WriteLine("The biggest number is " + HighestOfFour + ".");
