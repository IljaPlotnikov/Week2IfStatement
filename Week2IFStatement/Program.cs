Console.WriteLine("Enter your first name");
string LastName = Console.ReadLine();

Console.WriteLine("Enter your gender (f/m/n:");
char userGender = Char.Parse(Console.ReadLine());

string greeting;

if (userGender == 'f')
{
    greeting = "Ms.";
}
else if (userGender == 'm')
{
    greeting = "Mr.";
}
else
{
    greeting = "";
}

Console.WriteLine($"Hello, {greeting} {LastName}!");

Console.WriteLine("Enter your year of birth:");

int usersYB = Int32.Parse(Console.ReadLine());

int currentYear = DateTime.Now.Year;

int userAge = currentYear - usersYB;

//Console.WriteLine"Current year: {currentYear}");

//int userAge= Int32.Parse(Console.ReadLine());

if (userAge >= 13)
{
    Console.WriteLine("You are old enough to have an account");
}
else if (userAge < 13)
{
    Console.WriteLine("You are too young to have an account");
}