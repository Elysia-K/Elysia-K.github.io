using System;
namespace Module3LabPart2
{
	public abstract class Animal
	{
		public string Name { get; set; }
        public double Height { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }

		public abstract void Eat();
		public abstract void Cry();

        public void AskInfo()
        {
            Console.Write("Enter pet's Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter pet's Height: ");
            Height = double.TryParse(Console.ReadLine(), out double height) ? height : 0;

            Console.Write("Enter pet's Colour: ");
            Colour = Console.ReadLine();

            Console.Write("Enter pet's Age: ");
			Age = int.TryParse(Console.ReadLine(), out int age) ? age: 0;
        }

        public Animal()
		{
		
		}
	}
}

