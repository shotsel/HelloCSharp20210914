using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp.Domain
{
	class Creature
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
	}
}
