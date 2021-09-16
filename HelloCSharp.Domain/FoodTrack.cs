using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp.Domain
{
	public class FoodTrack
	{
		public Wrapping<Sandwich>[] PrepareFood(IEnumerable<SandwichSize> order)
		{
			List<Wrapping<Sandwich>> sandwiches = new List<Wrapping<Sandwich>>();

			foreach(SandwichSize size in order)
			{
				Sandwich sandwitch = MakeSandwich(size);

				var packedSandwich = Wrap(sandwitch);

				sandwiches.Add(packedSandwich);
			}

			return sandwiches.ToArray();
		}

		public IEnumerable<Wrapping<Sandwich>> PrepareFood(IDictionary<SandwichSize, int> order)
		{
			List<Wrapping<Sandwich>> sandwiches = new List<Wrapping<Sandwich>>();

			foreach (var positionFromOrder in order)
			{
				for (int i = 0; i < positionFromOrder.Value; i++)
				{
					Sandwich sandwitch = MakeSandwich(positionFromOrder.Key);
					var packedSandwich = Wrap(sandwitch);
					sandwiches.Add(packedSandwich);
				}
			}

			return sandwiches;
		}

		IEnumerable<Wrapping<Sandwich>> PrepareFood(FoodOrder order)
		{
			return new Wrapping<Sandwich>[0];
		}

		private Sandwich MakeSandwich(SandwichSize size)
		{
			switch (size)
			{
				case SandwichSize.Small: return MakeSmall();
				case SandwichSize.Big: return MakeBig();
				case SandwichSize.Medium: return MakeMedium();
			}

			/*
			 * TODO can i return nothing when asked for sandwitch? is this ok?
			 */
			return null; 
		}

		private Sandwich MakeBig()
		{
			return new Sandwich(100);
		}

		private Sandwich MakeMedium()
		{
			return new Sandwich(150);
		}

		private Sandwich MakeSmall()
		{
			return new Sandwich(200);
		}

		private Wrapping<Sandwich> Wrap(Sandwich sandwitch)
		{
			var box = new Wrapping<Sandwich>();
			box.Put(sandwitch);
			return box;
		}
   	}
}
