using Prototype.Interface;

namespace Prototype.Model
{
	/// <summary>
	/// Класс тиранозавров, мог сниматься в кино в главной роли
	/// </summary>
	public class TRex : Dinosaur, IMyCloneable<TRex>, ICloneable
	{
		public bool? IsStarringTRex { get; set; }

		public TRex()
		{
			Breed = "Tiranosaur Rex";
		}
		public TRex(TRex prototype)
		: base(prototype)
		{
			IsStarringTRex = prototype.IsStarringTRex;
		}

		public new object Clone()
		{
			return MyClone();
		}

		public new TRex MyClone()
		{
			return new TRex(this);
		}

		public override string ToString()
		{
			return base.ToString() + (IsStarringTRex == true ? $"{Environment.NewLine}It was the movie star!" : "");
		}

	}
}
