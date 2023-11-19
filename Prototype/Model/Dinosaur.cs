using Prototype.Interface;

namespace Prototype.Model
{
	/// <summary>
	/// Класс динозавров разных видов, могли сниматься в Парке Юрского Периода
	/// </summary>
	public class Dinosaur : Animal, IMyCloneable<Dinosaur>, ICloneable
	{
		public bool WasInJurassicParkMovie { get; set; }
		public string Breed { get; set; }

		public Dinosaur() { }
		public Dinosaur(Dinosaur prototype)
		: base(prototype)
		{
			WasInJurassicParkMovie = prototype.WasInJurassicParkMovie;
			Breed = prototype.Breed;
		}

		public new object Clone()
		{
			return MyClone();
		}

		public new Dinosaur MyClone()
		{
			return new Dinosaur(this);
		}

		public override string ToString()
		{
			return base.ToString() + $"{Environment.NewLine}It's a dinosaur {Breed}. " +
			$"It was{(WasInJurassicParkMovie == true ? "" : "n't")} in the Jurassic Park Movie.";
		}
	}
}
