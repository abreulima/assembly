using System;

Console.WriteLine("Write a number.");
int num = Convert.ToInt32(Console.ReadLine());

int i = 0;
while (i < num)
{
    int j = 0;
    while (j <= i)
    {
        Console.Write("*");
        j++;
    }
    Console.WriteLine();
    i++;
}
