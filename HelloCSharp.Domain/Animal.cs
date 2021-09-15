using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp.Domain
{
	abstract class Animal : ICreature
	{
		public static bool AlwaysDomestic = true;

		private bool _isDomestic;

		public Animal(bool isDomestic)
		{
			_isDomestic = isDomestic;
			CreationDate = DateTime.Now;
		}

		public DateTime CreationDate { get; }

		public void Eat(Sandwich sandwich)
		{
			/*
			 * TODO implement how all animals will deal with sandwich
			 */
		}

		public abstract void GetSound();
	}
}
