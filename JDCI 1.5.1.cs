/* Let's try to remember Bubble Sort :) */
double[] SorteDaBolha(double[] numbers, int size)
{
    double[] tempArr = new double[5];
    tempArr = numbers;

    for (int i = 0; i < size; i++)
    {
        for (int k = 0; k < size; k++)
        {
            if (tempArr[i] < tempArr[k])
            {
                /* swap */
                double temp;
                temp = tempArr[i];
                tempArr[i] = tempArr[k];
                tempArr[k] = temp;
            }
        }
    }
    return tempArr;
}

double[] numbers = new double[5];

Console.WriteLine("Type 5 numbers");
for (int i = 0; i < 5; i++)
{
    double temp = Convert.ToDouble(Console.ReadLine());
    numbers[i] = temp;
}

double[] newArr = new double[5];
newArr = SorteDaBolha(numbers, 5);

for (int i = 0; i < 5; i++)
{
    if (i != 4)
    {
        Console.Write("{0} ", newArr[i]);
    }
    else
    {
        Console.WriteLine("{0}.", newArr[i]);
    }
}


