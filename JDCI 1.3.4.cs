using System;

Console.WriteLine("Write a number.");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    for (int k = num; k - i > 0; k--)
    {
        Console.Write(" ");
    }

    for (int j = 0; j < 2*i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
