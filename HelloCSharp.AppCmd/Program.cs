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
			Man piotrek = new Man("jestem piotrek");
			Man szymon = new Man("jestem piotrek");

			// hand can not be swaped, it's Man's private. Due Human nature, it's not possible to swap body elements whenever you want.
			// piotrek._left = new Arm();

			piotrek.GetSound();
			
			Sandwich kanapkaZSzynka = new Sandwich(400);
			Sandwich kanapkaZSerem = new Sandwich(600);
			Sandwich suchyChleb = new Sandwich(200);


			Weight weight = new Weight(300);

			piotrek.Eat(kanapkaZSzynka);

			Console.ReadKey();
		}
	}
}
