namespace Lab5;

class Program
{
    static void Main(string[] args) 
    
    {
    //Step 3: Calling Derived Classes (I put this above the others because it made more sense to me.)

    Animal myAnimal = new Animal();
    Animal myCat = new Cat();
    Animal myDog = new Dog();

    myAnimal.animalSound(); //Output: The animal makes a sound
    myCat.animalSound(); //Output: The Cat Says: Meow
    myDog.animalSound(); //Output: The Dog Says: Bow Wow
    }
    

    //Step 1: Creating Base Class
    public class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    // Step 2: Creating Derived Cat Class
    public class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The Cat Says: Meow");
        }
    }

    // Step 2: Creating Derived Dog Class
    public class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The Dog Says: Bow Wow");
        }
        
    }
}
