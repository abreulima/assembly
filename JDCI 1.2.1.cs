using System;

/* 
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
*/

int HighestOfFour()
{ 
    Console.WriteLine("Type 4 numbers!");

    int numA = int.Parse(Console.ReadLine());
    int numB = int.Parse(Console.ReadLine());
    int numC = int.Parse(Console.ReadLine());
    int numD = int.Parse(Console.ReadLine());

    int max = numA;

    if (numB > max)
    {
        max = numB;
    }
    else if (numC > max)
    {
        max = numC;
    }
    else
    {
        max = numD
    }
    return max
}

Console.WriteLine("The biggest number is " + max + ".");
