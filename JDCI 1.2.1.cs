using System;

/* To remove the use of FOR */
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
    return max;

}

int max = HighestOfFour();
Console.WriteLine("The biggest number is " + max + ".");
