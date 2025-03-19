/* Let's try to remember Bubble Sort :) */
void InPlaceSorteDaBolha(double[] numbers, int size)
{
    for (int i = 0; i < size; i++)
    {
        for (int k = 0; k < size; k++)
        {
            if (numbers[i] < numbers[k])
            {
                /* swap */
                double temp;
                temp = numbers[i];
                numbers[i] = numbers[k];
                numbers[k] = temp;
            }
        }
    }
}


double[] numbers = new double[5];

Console.WriteLine("Type 5 numbers");
for (int i = 0; i < 5; i++)
{
    double temp = Convert.ToDouble(Console.ReadLine());
    numbers[i] = temp;
}

InPlaceSorteDaBolha(numbers, 5);

for (int i = 0; i < 5; i++)
{
    if (i != 4)
    {
        Console.Write("{0} ", numbers[i]);
    }
    else
    {
        Console.WriteLine("{0}.", numbers[i]);
    }
}


