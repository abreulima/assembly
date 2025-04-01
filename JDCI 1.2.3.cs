using System;

void FourDivisions()
{
    Console.WriteLine("Write four numbers.");
    double num1 = double.Parse(Console.ReadLine());
    double num2 = double.Parse(Console.ReadLine());
    double num3 = double.Parse(Console.ReadLine());
    double num4 = double.Parse(Console.ReadLine());

    double num1Div = num1 / (num2 + num3 + num4);
    double num2Div = num2 / (num1 + num3 + num4);
    double num3Div = num3 / (num1 + num2 + num4);
    double num4Div = num4 / (num1 + num2 + num3);

    if (num1Div < num2Div &&
        num1Div < num3Div &&
        num1Div < num4Div)
    {
        Console.WriteLine("The lowest division is " + num1Div);
    }
    else if (num2Div < num1Div &&
             num2Div < num3Div &&
             num2Div < num4Div)
    {
        Console.WriteLine("The lowest division is " + num2Div);
    }
    else if (num3Div < num1Div &&
             num3Div < num2Div &&
             num3Div < num4Div)
    {
        Console.WriteLine("The lowest division is " + num3Div);
    }
    else if (num4Div < num1Div &&
             num4Div < num2Div &&
             num4Div < num3Div)
    {
        Console.WriteLine("The lowest division is " + num4Div);
    }
}

FourDivisions();
