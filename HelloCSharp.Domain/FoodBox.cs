using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp.Domain
{
	public class FoodBox
	{
		private List<Wrapping<Sandwich>> _food;

		public FoodBox()
		{
		}

		public FoodBox(IEnumerable<Wrapping<Sandwich>> food, string recipeLocation)
		{
			RecipeLocation = recipeLocation;
			_food = new List<Wrapping<Sandwich>>(food);
		}

		public string RecipeLocation { get; private set; }

		public IEnumerable<Wrapping<Sandwich>> Sandwiches => _food.ToArray();

		public void Add(Wrapping<Sandwich> food)
		{
			_food.Add(food);
		}

		public void PutRecipe(string location)
		{
			RecipeLocation = location;
		}
	}
}
