using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp.Domain
{
	public abstract class Human : ICreature
	{
		private Arm _left;
		private Arm _right;
		private readonly string _sound;

		public Human(string sound) 
		{
			CreationDate = DateTime.Now.Date;
			_sound = sound;
		}

		public Arm Left 
		{ 
			get => _left;
			protected set => CheckIfHangCanBeSwapped(value);
		}

		public DateTime CreationDate { get; }

		public abstract Gender Gender { get; }

		private void CheckIfHangCanBeSwapped(Arm value)
		{
			throw new NotImplementedException();
		}

		public void MakeFriendship(Human other)
		{
			other._left = new Arm();
			other._right = new Arm();
		}

		public virtual void GetSound()
		{
			Console.WriteLine("im speaking now: " + _sound);
		}

		public void Eat(Sandwich sandwich)
		{			
			/*
			 * TODO how human eats???
			 */
		}

		public void Eat(Wrapping wrappingWithFood)
		{
			if (wrappingWithFood.IsEmpty)
			{ 
				// Ha! Ha! Ha! What a "nice" joke... :/
				return; 
			}

			var food = wrappingWithFood.Remove();
			if (!(food is Sandwich))
			{
				// even more funny you idiot....
				return;
			}

			Eat((Sandwich)food);
		}
	}
}
