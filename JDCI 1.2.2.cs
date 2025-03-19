using System;

/* To remove the use of FOR */
double HighestDivision()
{

    Console.WriteLine("Write two numbers.");
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());

    double divResultAB = a / b;
    double divResultBA = b / a;

    if (divResultAB > divResultBA)
        return divResultAB;
    else
        return divResultBA;
}

Console.WriteLine("The hightest division is " + HighestDivision());
