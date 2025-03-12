void Operations()
{ 
    Console.WriteLine("Type two numbers and a operator.");
    Console.WriteLine("The operators can be SUM, SUB, MLT, DIV");

    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    string op = Console.ReadLine();

    switch (op)
    {
        case "SUM":
            Console.WriteLine(a + b);
            break;

        case "SUB":
            Console.WriteLine(a - b);
            break;

        case "MLT":
            Console.WriteLine(a * b);
            break;

        case "DIV":
            Console.WriteLine(a / b);
            break;

        default:
            break;
    }
}   