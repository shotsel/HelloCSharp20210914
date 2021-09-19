using HelloCSharp.Tools.Time;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp.Domain
{
	public abstract class Human : ICreature, IDisposable
	{
		private Arm _left;
		private Arm _right;
		private int _age;
		private readonly string _sound;

		public Human(string sound) 
		{
			CreationDate = DateTime.Now.Date;
			_sound = sound;
			Clock.NewDay += OnNewDay;
		}

		public Arm Left 
		{ 
			get => _left;
			protected set => CheckIfHangCanBeSwapped(value);
		}

		public DateTime CreationDate { get; }

		public int Age => _age;

		public abstract Gender Gender { get; }

		public void Dispose()
		{
			Clock.NewDay -= OnNewDay;
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

		public void Eat(Wrapping<Sandwich> wrappingWithFood)
		{
			if (wrappingWithFood.IsEmpty)
			{ 
				// Ha! Ha! Ha! What a "nice" joke... :/
				return; 
			}

			var food = wrappingWithFood.Remove();

			Eat(food);
		}

		private void OnNewDay(Time time)
		{
			if (time.Day != CreationDate.DayOfYear)
			{
				return;
			}

			/*
			 * local field modification, in conjuction with read via property, may require 
			 * thread safe implementation (threads synchronization)
			 */
			_age++;
		}

		private void CheckIfHangCanBeSwapped(Arm value)
		{
			throw new NotImplementedException();
		}
	}
}
