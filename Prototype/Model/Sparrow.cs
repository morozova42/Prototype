using Prototype.Interface;

namespace Prototype.Model
{
	/// <summary>
	/// Класс воробьёв, может быть Капитаном Джеком Воробьём
	/// </summary>
	public class Sparrow : Bird, IMyCloneable<Sparrow>, ICloneable
	{
		public bool IsCaptainJack { get; set; }

		public Sparrow()
		{
			Breed = "Sparrow";
		}
		public Sparrow(Sparrow prototype)
		: base(prototype)
		{
			IsCaptainJack = prototype.IsCaptainJack;
		}

		public new object Clone()
		{
			return MyClone();
		}

		public new Sparrow MyClone()
		{
			return new Sparrow(this);
		}
		public override string ToString()
		{
			return base.ToString() + (IsCaptainJack == true ? $"{Environment.NewLine}It is the one and only Captain Sparrow!" : "It's not a captain");
		}
	}
}
