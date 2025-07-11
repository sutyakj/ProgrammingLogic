namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Welcome to IT-1050!");

        //step 1- Multiline code

        /*
        Jeffrey Sutyak
        [IT-1050- Lab 1]
        */

        //step 2
        Console.WriteLine("Jeffrey Sutyak [IT-1050-Lab1]");

        //step 3- declare int

        int number = 47;
        Console.WriteLine(number);

        //declare string
        string programingLanguage = "C# :)";
        Console.WriteLine(programingLanguage);

        //declare double
        double numberOfPrograms = 1;
        Console.WriteLine(numberOfPrograms);

        //declare bool
        bool programingExperience = false;
        Console.WriteLine(programingExperience);

        //step 4
        //declare string
        const string SchoolName = "Tri-C";
        Console.WriteLine(SchoolName);

        //step 5
        //declare my double
        double myDouble = 9.78;
        Console.WriteLine(myDouble);

        //Convert my double variable to an int
        int myInt = (int)myDouble;
        Console.WriteLine("int: " + myInt);

        //Convert my Int to string
        string myString = myInt.ToString();
        Console.WriteLine("string: " + myString);

        //Convert my bool to string
        string boolToString = programingExperience.ToString();
        Console.WriteLine("string: " + boolToString);

        //Step 6

        //ask for name
        Console.WriteLine("please enter your name:");
        string name = Console.ReadLine()!;

        //ask for age
        Console.WriteLine("Enter your Age:");
        int age = Convert.ToInt32(Console.ReadLine());

        //Greating display

        Console.WriteLine($"Hello, {name}! You are {age} years old.");

        //Step 7

        //create two int variables

        int num1 = 15;
        int num2 = 5;

        // Addition - add 10
        int sum = num1 + 10;
        Console.WriteLine($"Addition (num1 + 10): {sum}");

        // Subtraction - subtract 2
        int difference = num2 - 2;
        Console.WriteLine($"Subtraction (num2 - 2): {difference}");

        // Multiplication - times 3
        int product = num1 * 3;
        Console.WriteLine($"Multiplication (num1 * 3): {product}");

        // Division - divide by 2
        int quotient = num2 / 2;
        Console.WriteLine($"Division (num2 / 2): {quotient}");

        // Modulus - modulus 2
        int remainder = num1 % 2;
        Console.WriteLine($"Modulus (num1 % 2): {remainder}");

        //Step 8

        // create float and double

        float floatValue = 1.123456789f;

        double doubleValue = 1.123456789;

        Console.WriteLine("Float value: " + floatValue);
        Console.WriteLine("Double value: " + doubleValue);

        // Step 9

        // Declare int value and assign as 10
        int counter = 10;

        counter++;
        Console.WriteLine("After increment: " + counter);

        counter--;
        Console.WriteLine("After decrement: " + counter);

        }
}
