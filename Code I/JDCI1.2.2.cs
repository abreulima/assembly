int

Console.WriteLine("Write two numbers.");
int a = int.Parse(Console.ReadLine());
inb b = int.Parse(Console.ReadLine());

int HighestDivision(int a, int b)
{
    if (a / b > b / a)
        return a / b;
    else
        return b / a;
}

Console.WriteLine("The hightest division is " + HighestDivision(a, b));
