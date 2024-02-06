using System;
namespace Module3LabPart1
{
	public class Dog:Animal
	{

        public Dog()
		{
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

