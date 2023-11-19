using Prototype.Interface;

namespace Prototype.Model
{
	/// <summary>
	/// Класс птиц рахных видов, летающих и нет
	/// </summary>
	public class Bird : Animal, IMyCloneable<Bird>, ICloneable
	{
		public bool CanFly { get; set; }
		public string Breed { get; set; }

		public Bird() {}
		public Bird(Bird prototype)
		: base(prototype)
		{
			CanFly = prototype.CanFly;
			Breed = prototype.Breed;
		}

		public new object Clone()
		{
			return MyClone();
		}

		public new Bird MyClone()
		{
			return new Bird(this);
		}
		public override string ToString()
		{
			return base.ToString() + $"{Environment.NewLine}It's a bird {Breed}. " +
			$"It ca{(CanFly == true ? "n" : "n't")} fly.";
		}
	}
}
