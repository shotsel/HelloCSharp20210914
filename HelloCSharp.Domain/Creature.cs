using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp.Domain
{
	public class Creature : Something
	{
		private string _sound;
		private Head _head;

		public Creature(string sound)
		{
			_sound = sound;
		}

		public void GetSound()
		{
			Console.Write("my sound:" + _sound);

			/*
			 * implement how sound is given
			 */
		}

		public void Eat(Sandwich sandwich)
		{
			/*
			 * TODO teach this object (and all hierarchy) how to eat.
			 */
		}
	}
}
