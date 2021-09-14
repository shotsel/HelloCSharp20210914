using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp.Domain
{
	class Human : Creature
	{
		private Arm _left;
		private Arm _right;

		public Human(string sound) 
			: base(sound)
		{
		}
	}
}
