
using System;

Console.WriteLine("Write a number.");
int num = Convert.ToInt32(Console.ReadLine());

int k = 0;

for (int i = 1; i <= num; i++)
{
    for (; num - k > 0; k++)
    {
        Console.Write(" ");
    }

    for (int j = 0; j < 2*i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
