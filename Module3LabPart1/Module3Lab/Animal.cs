using System;
namespace Module3LabPart1
{
	public abstract class Animal
	{
		public string Name { get; set; }
		public string Colour { get; set; }
        public int Age { get; set; }

		public abstract void Eat();
		public abstract void Cry();

        public void AskInfo()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();

            Console.Write("Colour: ");
            Colour = Console.ReadLine();

            Console.Write("Age: ");
			Age = int.TryParse(Console.ReadLine(), out int age) ? age: 0;
        }

        public Animal()
		{
		
		}
	}
}

