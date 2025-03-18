using System;

Console.WriteLine("Write a number.");
int num = Convert.ToInt32(Console.ReadLine());

int i = 1;
do
{
    int k = num;
    do
    {
        Console.Write(" ");
        k--;
    } while (k - i > 0);

    int j = 0;
    do
    {
        Console.Write("*");
        j++;
    } while (j < 2*i);

    Console.WriteLine();
    i++;
} while (i <= num);
