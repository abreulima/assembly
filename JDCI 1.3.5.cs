using System;

Console.WriteLine("Write a number.");
int num = Convert.ToInt32(Console.ReadLine());

int i = 0;
do
{
    int j = 0;
    do
    {
        Console.Write("*");
        j++;
    }
    while (j <= i);
    Console.WriteLine();
    i++;
}
while (i < num);
