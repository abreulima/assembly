using System;

double SquareRoot(double number)
{
    return Math.Sqrt(number);
}


double NumberModule(double number)
{
    return Math.Abs(number);
}

int input = 0;
double inputA = 0;
double inputB = 0;
double inputC = 0;

Console.WriteLine("Type a number to be root squared.");
inputA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("{0:0.00}", SquareRoot(inputA));

Console.WriteLine("Type a number to return its module.");
inputA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("{0}", NumberModule(inputA));

double QuadraticEquationPos(double a, double b, double c)
{
    return (-b + SquareRoot(b*b - 4*a*c)) / (2*a);
}

double QuadraticEquationNeg(double a, double b, double c)
{
    return (-b - SquareRoot(b*b - 4*a*c)) / (2*a);
}

int Factorial(int factorial)
{
    int total = 1;
    if (factorial == 0)
    {
        return 1;
    }
    else if (factorial == 1)
    {
        return 1;
    }
    else
    {
        for(int i = 1; i <= factorial; i++)
        {
            total *= i;
        }
        return total;
    }

}


Console.WriteLine("In the equation ax^2 + bx + c = 0, type a, b and c");
Console.WriteLine("The positive solution of the equation will be returned.");
Console.WriteLine("Type a");
inputA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Type b");
inputB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Type c");
inputC = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("{0}", QuadraticEquationPos(inputA, inputB, inputC));


Console.WriteLine("In the equation ax^2 + bx + c = 0, type a, b and c");
Console.WriteLine("The negative solution of the equation will be returned.");
Console.WriteLine("Type a");
inputA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Type b");
inputB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Type c");
inputC = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("{0}", QuadraticEquationNeg(inputA, inputB, inputC));


Console.WriteLine("Type a number to calculate its factorial.");
input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("{0}", Factorial(input));