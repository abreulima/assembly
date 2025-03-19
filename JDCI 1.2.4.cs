using System;

void Division()
{
    Console.WriteLine("Type two numbers");

    float a = float.Parse(Console.ReadLine());
    float b = float.Parse(Console.ReadLine());

    Console.WriteLine((a / b).ToString("F2"));

}

Division();