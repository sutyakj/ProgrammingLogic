using System;

namespace Lab4
{
    // Define the Car class
    class Car
    {
        public string model;
        public string color;
        public int year;

        // Method to display car details
        public void Display()
        {
            Console.WriteLine("Car Details:");
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Year: " + year);
        }
        // Problem 1: Add Start method
        public void Start()
        {
            Console.WriteLine("The car is starting.");
        }

        // Problem 2: Drive method with a parameter
        public void Drive(int miles)
        {
            Console.WriteLine($"The car drove {miles} miles.");
        }

        // Problem 3: Method with return value
        public string GetDescription()
        {
            return $"{year} {color} {model}";
        }
        
        // Problem 4: Repaint method
        public void Repaint(string newColor)
        {
            color = newColor;
            Console.WriteLine($"The car has been repainted to {newColor}.");
        }        
    }

    // Main Program class

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Creating a Car object and assigning values to its properties
            Car myCar = new Car();
            myCar.model = "Civic";
            myCar.color = "Black";
            myCar.year = 2020;

            myCar.Display(); // Calling the Display method
            myCar.Start(); // Call the start method
            myCar.Drive(50); //Call the Drive method with 50 miles

            //Problem 3: Get and Print Description
            string description = myCar.GetDescription();
            Console.WriteLine("Description:" + description);

            //Problem 4: Repaint the car
            myCar.Repaint("Red");

            //Confirm color update
            Console.WriteLine("Updated Description: " + myCar.GetDescription());
        }
    }
}
