
bool doAgain = true;

while (doAgain)
{
    Console.WriteLine("Type a numbers");
    int arraySize = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Now you will have to type {0} numbers...", arraySize);


    /* Where is my Malloc? */
    double[] numbers = new double[arraySize];

    for (int i = 0; i < arraySize; i++)
    {

        double temp = Convert.ToDouble(Console.ReadLine());
        numbers[i] = temp;
    }

    for (int i = 0; i < arraySize; i++)
    {
        if (i != arraySize - 1)
        {
            Console.Write("{0} ", numbers[i]);
        }
        else
        {
            Console.WriteLine("{0}.", numbers[i]);
        }
    }

    Console.WriteLine("Wanna do it again? YES or NO.");
    string answer = Console.ReadLine();
    if (answer == "NO")
    {
        doAgain = false;
    }
}