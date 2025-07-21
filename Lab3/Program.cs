namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //Problem 1: Simple for Loop
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // Problem 2: Even Numbers from 1 to 20
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }

        }

        //Problem 3: While Loop Countdown
        int count = 5;
        while (count >= 1)
        {
            Console.WriteLine(count);
            count--;
        }

        //Problem 4: While Loop- Multiples of 10 from 10 to 1000
        int number = 10;
        while (number <= 1000)
        {
            Console.WriteLine(number);
            number += 10;
        }

        // Problem 5: Seasons of the Year

        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
        foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }

        //Problem 6: Days of the Week (1-7)

        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };


        Console.Write("Enter a number (1 to 7):");
        if (int.TryParse(Console.ReadLine(), out int dayNumber) && dayNumber >= 1 && dayNumber <= 7)
        {
            Console.WriteLine("Day:" + days[dayNumber - 1]);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number from 1 to 7");

        }

        // Problem 7: Favorite Books and Authors


        string[] books = { "Great Expectations", "Crime and Punishment", "The Magic Mountain" };
        string[] authors = { "Charles Dickens5", "Fyodor Dostoevsky", "Thomas Mann" };

        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"{books[i]} by {authors[i]}");
        }

        //Problem 8: Temperature Tracker

        int[] temps = { 102, 65, 98, 75, 84 };

        Array.Sort(temps);

        Console.WriteLine("Temperatures in ascending order:");
        foreach (int temp in temps)
        {
            Console.WriteLine(temp);
        }

        Console.WriteLine("Lowest Temperature: " + temps[0]);
        Console.WriteLine("Highest Temperature: " + temps[temps.Length - 1]);

        //Problem 9: Reverse Countdown

        int[] countdown = { 5, 4, 3, 2, 1 };


        Array.Reverse(countdown);

        for (int i = 0; i < countdown.Length; i++)
        {
            Console.WriteLine(countdown[i]);
        }

    }

    
}
