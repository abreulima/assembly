
double[] numbers = new double[5];
double avg = 0;

Console.WriteLine("Type 5 numbers");
for (int i = 0; i < 5; i++)
{
    double temp = Convert.ToDouble(Console.ReadLine());
    numbers[i] = temp;
    avg += numbers[i];
}

Console.WriteLine("The avg. is {0} ", avg/5.0);

