using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp.Domain
{
	public class Human : Creature
	{
		private Arm _left;
		private Arm _right;

		public Human(string sound) 
			: base(sound)
		{
		}

		public Arm Left 
		{ 
			get => _left;
			protected set => CheckIfHangCanBeSwapped(value);
		}

		private void CheckIfHangCanBeSwapped(Arm value)
		{
			throw new NotImplementedException();
		}

		public void MakeFriendship(Human other)
		{
			other._left = new Arm();
			other._right = new Arm();
		}
	}
}
