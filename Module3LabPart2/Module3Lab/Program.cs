namespace Module3LabPart2;

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        Cat cat = new Cat();

        List<IAnimal> animals = new List<IAnimal>();
        Cat cat1 = new Cat("Star", 30, "BrownTabby", 10);

        Console.WriteLine("Do you have a Dog or Cat? :");

        string userInput = Console.ReadLine();

        if (userInput == "Dog" || userInput == "dog")
        {
            dog.AskInfo();
            dog.Eat();
            dog.Cry();
            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.Height);
            Console.WriteLine(dog.Colour);
            Console.WriteLine(dog.Age);
            animals.Add(dog);
           
        }
        else if (userInput == "Cat" || userInput == "cat")
        {
            cat.AskInfo();
            cat.Eat();
            cat.Cry();
            Console.WriteLine(cat.Name);
            Console.WriteLine(cat.Height);
            Console.WriteLine(cat.Colour);
            Console.WriteLine(cat.Age);
            animals.Add(cat);
        }

        else
            Console.WriteLine($"Please Enter Dog or Cat.");
  
        animals.Add(cat1);

        Console.WriteLine("List of Animals Name: ");
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Name);
        }

    }


}