using Prototype.Interface;
using Prototype.Model;

namespace Prototype
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Prototypes:");
			List<ICloneable> prototypes = new List<ICloneable>();
			List<IMyCloneable<Animal>> myPrototypes = new List<IMyCloneable<Animal>>();

			// Создание прототипов разных классов
			#region TRex
			TRex SuperStarTRex = new TRex()
			{
				Age = 20,
				Name = "TRex Super Star",
				IsStarringTRex = true,
				WasInJurassicParkMovie = true
			};

			Console.ForegroundColor = ConsoleColor.Cyan;
			WriteNiceLine(SuperStarTRex);
			prototypes.Add(SuperStarTRex);
			myPrototypes.Add(SuperStarTRex);
			#endregion

			#region dino
			Dinosaur ordinaryDino = new Dinosaur()
			{
				Age = 1000000,
				Name = "NoName",
				WasInJurassicParkMovie = false,
				Breed = "Ihtiosaur"
			};
			Console.ForegroundColor = ConsoleColor.Cyan;
			WriteNiceLine(ordinaryDino);
			prototypes.Add(ordinaryDino);
			myPrototypes.Add(ordinaryDino);
			#endregion

			#region sparrow
			Sparrow captain = new Sparrow()
			{
				Age = 42,
				Name = "Jack",
				CanFly = false,
				IsCaptainJack = true
			};
			Console.ForegroundColor = ConsoleColor.Cyan;
			WriteNiceLine(captain);
			prototypes.Add(captain);
			myPrototypes.Add(captain);
			#endregion

			#region eagle
			Bird bird = new Bird()
			{
				Age = 333,
				Name = "Fred",
				CanFly = true,
				Breed = "Eagle"
			};
			Console.ForegroundColor = ConsoleColor.Cyan;
			WriteNiceLine(bird);
			prototypes.Add(bird);
			myPrototypes.Add(bird);
			#endregion

			// Клонирование прототипов через разные интерфейсы
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Now start cloning via ICloneable");
			SayCloning();
			for (int i = 0; i < prototypes.Count; i++)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				var proto = prototypes[i];
				Animal clone = proto.Clone() as Animal;
				clone.Age = i;
				WriteNiceLine(clone);
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("His prototype:");
				WriteNiceLine(proto);
			}

			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine("Now start cloning via IMyCloneable");
			SayCloning();
			for (int i = 0; i < myPrototypes.Count; i++)
			{
				Console.ForegroundColor = ConsoleColor.Magenta;
				Animal clone = myPrototypes[i].MyClone();
				clone.Age = i;
				WriteNiceLine(clone);
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("His prototype:");
				WriteNiceLine(myPrototypes[i]);
			}

			Console.ResetColor();
		}

		static void SayCloning()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("Cloning");
			for (int i = 0; i < 5; i++)
			{
				Thread.Sleep(250);
				Console.Write(".");
			}
		}

		static void WriteNiceLine(object obj)
		{
			Console.WriteLine();
			Console.WriteLine(obj);
			Console.WriteLine();
		}
	}
}