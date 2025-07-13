Console.WriteLine("Hello, World!");

//Part 1- Operator Practice

int a = 10; int b = 5; int c = 15;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

// comparison

bool isAGreaterThanB = a > b;
bool isALessThanC = a < c;
bool isAGreaterThanBandC = (a > b) && (a > c);

bool isAGreaterThanBorC = (a > b) || (a > c);

Console.WriteLine("a >b:" + isAGreaterThanB);
Console.WriteLine("a < c:" + isALessThanC);
Console.WriteLine("a > b && a > c:" + isAGreaterThanBandC);
Console.WriteLine("a > b || a > c:" + isAGreaterThanBorC);

//Part 2 Boolean Logic
bool isRaining = true;
bool haveUmbrella = false;

if (isRaining && !haveUmbrella)
{
    Console.WriteLine("Take an umbrella!");
}
else
{
    Console.WriteLine("You're good to go!");
}

//Part 3: Conditional Logic-Movie Ticket Pricing

// ask for age
Console.Write("Enter your age:");
int age = int.Parse(Console.ReadLine());

// assign price category
if (age < 5)
{
    Console.WriteLine("Ticket is free!");
}
else if (age >= 5 && age <= 12)
{
    Console.WriteLine("Child ticket; $5");
}
else if (age >= 13 && age <= 64)
{
    Console.WriteLine("Standard ticket: $10");
}
else if (age >= 65)
{
    Console.WriteLine("Senior ticket: $6");
}

// Part 4: Using a switch Statement

// Ask the user to input the number that denotes the day of the week
{
    Console.Write("Enter a day of the week (1-7)");
    int day = int.Parse(Console.ReadLine());

    switch (day)
    {

        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            break;
        case 7:
            Console.WriteLine("Sunday");
            break;
        default:
            Console.WriteLine("Invalid day!");
            break;
    }
}



