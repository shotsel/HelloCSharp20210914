using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp.Domain
{
	class Animal : Creature
	{
		public static bool AlwaysDomestic = true;

		private bool _isDomestic;

		public Animal(string sound, bool isDomestic) 
			: base(sound)
		{
			_isDomestic = isDomestic;
		}
	}
}
