
using System;

Console.WriteLine("Write a number.");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{num} X {i} = {num * i}");
}