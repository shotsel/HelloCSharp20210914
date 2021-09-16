using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelloCSharp.Domain;
using HelloCSharp.Tools.Physics;

namespace HelloCSharp.AppCmd
{
	class Program
	{
		static void Main(string[] args)
		{
			FoodTrack();

			Console.ReadKey();
		}

		private static void FoodTrack()
		{
			var burgerBuda = new FoodTrack();

			var jedzenie = burgerBuda.PrepareFood(new[] { SandwichSize.Small, SandwichSize.Medium, SandwichSize.Medium });

			Man glodny = new Man("jesc");

			foreach (var burger in jedzenie.Sandwiches)
			{
				glodny.Eat(burger);
			}

			Recipe recipe = LoadRecipe(jedzenie.RecipeLocation);
		}

		private static Recipe LoadRecipe(string recipeLocation)
		{
			/*
			 * TODO 
			 * Deserialize recipe from hard drive using xml serializer.
			 */
			throw new NotImplementedException();
		}

		private static void Looping()
		{
			List<int> numbers = new List<int>();

			foreach(int number in numbers)
			{
				/*
				 * process single number, item from colleciton
				 */
				Console.WriteLine("numbers is: " + number);
			}

			int[] arrayOfNumbers = new int[5];

			for (int i = 0; i < arrayOfNumbers.Length; i++)
			{
				/*
				 * get item from index and later process it whatever you want
				 */
				var number = arrayOfNumbers[i];
			}
		}

		private static void Polimorphizm()
		{
			ICreature creature = new Man("im the creature");

			creature.GetSound();

			Dog dog = new Dog("as creature");
			creature = dog;
			creature.GetSound();

			Animal animal = dog;

			creature = animal;

			animal.GetSound();
			creature.GetSound();

			Console.WriteLine("boy vs creature:");

			Boy boy = new Boy();
			boy.GetSound();

			creature = boy;
			creature.GetSound();
		}

		private static void LogicFromExcersize()
		{
			var burger = new Sandwich(300);
			var paperBox = new Wrapping<Sandwich>();

			paperBox.Put(burger);

			Human peter = new Man("im hugry!!");
			peter.Eat(paperBox);
		}

		private static void Playground()
		{
			Man piotrek = new Man("jestem piotrek");
			Man szymon = new Man("jestem piotrek");

			// hand can not be swaped, it's Man's private. Due Human nature, it's not possible to swap body elements whenever you want.
			// piotrek._left = new Arm();

			piotrek.GetSound();

			Sandwich kanapkaZSzynka = new Sandwich(400);
			Sandwich kanapkaZSerem = new Sandwich(600);
			Sandwich suchyChleb = new Sandwich(200);


			Weight weight = Weight.FromGrams(300);

			piotrek.Eat(kanapkaZSzynka);
		}

		private static void ValueVsReference()
		{
			//Weight oryginal = new Weight(100);
			Weight oryginal = Weight.FromGrams(100);

			Weight duplicated = oryginal;
			Console.WriteLine(Environment.NewLine);
			Console.WriteLine("value type behaviour");
			Console.WriteLine("oryginal weight: " + oryginal.GetGrams());
			Console.WriteLine("duplicated weight: " + duplicated.GetGrams());

			duplicated.AddGrams(200);

			Console.WriteLine("after change");
			Console.WriteLine("oryginal weight: " + oryginal.GetGrams());
			Console.WriteLine("duplicated weight: " + duplicated.GetGrams());

			Console.WriteLine(Environment.NewLine);
			Console.WriteLine("reference type behaviour");

			Sandwich oryginalSandwich = new Sandwich(200);
			oryginalSandwich.Name = "oryginal";
			Sandwich duplicatedSandwich = oryginalSandwich;
			Console.WriteLine("oryginal sandwich weight: " + oryginalSandwich.Name);
			Console.WriteLine("duplicated duplicated weight: " + duplicatedSandwich.Name);

			duplicatedSandwich.Name = "duplicate";
			Console.WriteLine("after assignemnt change");
			Console.WriteLine("oryginal sandwich weight: " + oryginalSandwich.Name);
			Console.WriteLine("duplicated duplicated weight: " + duplicatedSandwich.Name);

			ChangeSandwichName(duplicatedSandwich, "changed in Method");
			Console.WriteLine("after change in method");
			Console.WriteLine("oryginal sandwich weight: " + oryginalSandwich.Name);
			Console.WriteLine("duplicated duplicated weight: " + duplicatedSandwich.Name);

			ChangeWeight(duplicated, 300);
			Console.WriteLine("after change in method");
			Console.WriteLine("oryginal weight: " + oryginal.GetGrams());
			Console.WriteLine("duplicated weight: " + duplicated.GetGrams());


			Sandwich newOne = new Sandwich(500);
			Weight sandwichWeight = newOne.Weight;

			sandwichWeight.AddGrams(30);
			Console.WriteLine("sandwich.weight: " + newOne.Weight.GetGrams());
			Console.WriteLine("sandwichWeight: " + sandwichWeight.GetGrams());
		}

		private static void ChangeSandwichName(Sandwich subject, string newName)
		{
			subject.Name = newName;
		}

		private static void ChangeWeight(Weight subject, int delta)
		{
			subject.AddGrams(delta);
			Console.WriteLine("changes weigh in method: " + subject.GetGrams());
		}
	}
}
