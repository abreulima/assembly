using System;

Console.WriteLine("Write a number.");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    for (int k = num; k - i > 1; k--)
    {
        Console.Write(" ");
    }

    for (int j = 0; j < (2*i + 1); j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
