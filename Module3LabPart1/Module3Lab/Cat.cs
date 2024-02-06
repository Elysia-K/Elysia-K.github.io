using System;
namespace Module3LabPart1
{
	public class Cat:Animal
	{
		public Cat()
		{
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

