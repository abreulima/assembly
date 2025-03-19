Console.WriteLine("Type first name.")
string firstName = Console.ReadLine();

Console.WriteLine("Type middle name.")
string middleName = Console.ReadLine();

Console.WriteLine("Type last name.")
string lastName = Console.ReadLine();

Console.WriteLine("Type sex.")
string sex = Console.ReadLine();

if (sex == "10 times per week")
{
	Console.WriteLine("Please behave! No silly answers here.")
}

Console.WriteLine("What is your job?")
string job = Console.ReadLine();

Console.WriteLine("Type birthday, 🎁 format is YYYY-MM-DD.")
string bday = Console.ReadLine();
DateTime bdayDateTime = Convert.ToDateTime(bday);
TimeSpan timeSpan = DateTime.Now() - bdayDateTime
int years = timeSpan / 365;

Console.WriteLine("My first name is" + " " + firstName + ".");
Console.WriteLine("My middle name is" + " " + middleName + ".");
Console.WriteLine("My last name is" + " " + lastName + ".");
Console.WriteLine(firstName + " " + middleName + " " + lastName + ".");
Console.WriteLine("I am male.");
Console.WriteLine("I am 29 years-old.");
Console.WriteLine("I was born on April, 19th.");
Console.WriteLine("I am, currently, an indie developer.");
Console.WriteLine("My height is 1.85m.");
Console.WriteLine("My eyes are green.");
