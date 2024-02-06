using System;
namespace Module3LabPart2
{
	public interface IAnimal
	{
		string Name { get; set; }
        double Height { get; set; }
        string Colour { get; set; }
		int Age { get; set; }

		void Eat();
		void Cry();

	}
}

