using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp.Domain
{
	class Creature : Something
	{
		private string _sound;
		private Head _head;

		public Creature(string sound)
		{
			_sound = sound;
		}

		void GetSound()
		{
			Console.Write("my sound:" + _sound);

			/*
			 * implement how sound is given
			 */
		}

		void Eat(Sandwich sandwich)
		{
			/*
			 * TODO teach this object (and all hierarchy) how to eat.
			 */
		}
	}
}
