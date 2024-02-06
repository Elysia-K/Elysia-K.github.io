namespace Module3LabPart1;

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        Cat cat = new Cat();

        Console.WriteLine("Do you have a Dog or Cat? :");

        string userInput = Console.ReadLine();

        if (userInput == "Dog" || userInput == "dog")
        {
            dog.AskInfo();
            dog.Eat();
            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.Colour);
            Console.WriteLine(dog.Age);
        }
        else if (userInput == "Cat" || userInput == "cat")
        {
            cat.AskInfo();
            cat.Eat();
            Console.WriteLine(cat.Name);
            Console.WriteLine(cat.Colour);
            Console.WriteLine(cat.Age);
        }

        else
            Console.WriteLine($"Please Enter Dog or Cat.");

    }


}