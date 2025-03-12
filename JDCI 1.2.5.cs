void FizzBuzz()
{ 
    Console.WriteLine("Type two numbers");

    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());

    if ((a * b) % 2 == 0)
        Console.WriteLine("Fizz");
    else
        Console.WriteLine("Buzz");
}