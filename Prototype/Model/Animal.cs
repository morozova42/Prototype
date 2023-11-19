using Prototype.Interface;

namespace Prototype.Model
{
	/// <summary>
	/// Класс животного с именем и возрастом в годах
	/// </summary>
	public class Animal : IMyCloneable<Animal>, ICloneable
	{
		public int Age { get; set; }
		public string Name { get; set; }

		public Animal() { }
		public Animal(Animal prototype)
		{
			Age = prototype.Age;
			Name = prototype.Name;
		}

		public object Clone()
		{
			return MyClone();
		}

		public Animal MyClone()
		{
			return new Animal(this);
		}

		public override string ToString()
		{
			return $"This is the animal {Name}. It is {Age} years old.";
		}
	}
}
