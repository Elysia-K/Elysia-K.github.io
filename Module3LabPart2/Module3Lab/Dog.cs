using System;
namespace Module3LabPart2
{
	public class Dog:Animal, IAnimal
	{
        public Dog()
        {
        }

        public Dog(string name, double height, string colour, int age)
		{
			this.Name = name;
			this.Height = height;
			this.Colour = colour;
			this.Age = age;

		}

        public override void Eat()
		{
			Console.WriteLine("Dogs eat meat.");
		}

        public override void Cry()
        {
			Console.WriteLine("Woof!");
        }
    }
}

