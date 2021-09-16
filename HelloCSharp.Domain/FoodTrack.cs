using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HelloCSharp.Domain
{
	public class FoodTrack
	{
		public FoodBox PrepareFood(IEnumerable<SandwichSize> order)
		{
			List<Wrapping<Sandwich>> sandwiches = new List<Wrapping<Sandwich>>();

			foreach(SandwichSize size in order)
			{
				Sandwich sandwitch = MakeSandwich(size);

				var packedSandwich = Wrap(sandwitch);

				sandwiches.Add(packedSandwich);
			}

			var recipe = PrintRecipe();
			var location = StoreRecipe(recipe);

			return new FoodBox(sandwiches, location);
		}

		public FoodBox PrepareFood(IDictionary<SandwichSize, int> order)
		{
			FoodBox box = new FoodBox();

			foreach (var positionFromOrder in order)
			{
				for (int i = 0; i < positionFromOrder.Value; i++)
				{
					Sandwich sandwitch = MakeSandwich(positionFromOrder.Key);
					var packedSandwich = Wrap(sandwitch);
					box.Add(packedSandwich);
				}
			}

			var recipe = PrintRecipe();
			var location = StoreRecipe(recipe);

			box.PutRecipe(location);

			return box;
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

		private string StoreRecipe(Recipe recipe)
		{
			var path = Path.Combine(@"c:\recipies", recipe.Number + ".xml");
			var fileStream = File.OpenWrite(path);
			using(fileStream)
			{
				var serializer = new XmlSerializer(typeof(Recipe));
				serializer.Serialize(fileStream, recipe);
			}

			return path;
		}

		private Recipe PrintRecipe()
		{
			/*
			 * TODO place purchaces items on recipe, create it. 
			 */
			return new Recipe();
		}
	}
}
