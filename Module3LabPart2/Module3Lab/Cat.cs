using System;
namespace Module3LabPart2
{
	public class Cat:Animal, IAnimal
	{
        public Cat()
        {
        }

        public Cat(string name, double height, string colour, int age)
		{
            this.Name = name;
            this.Height = height;
            this.Colour = colour;
            this.Age = age;
        }

        public override void Eat()
        {
            Console.WriteLine("Cats eat Mice.");
        }

        public override void Cry()
        {
            Console.WriteLine("Meow!");
        }
    }
}

