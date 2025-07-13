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

