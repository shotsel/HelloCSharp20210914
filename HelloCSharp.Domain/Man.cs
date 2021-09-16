using System;

namespace HelloCSharp.Domain
{
	public class Man : Human
	{
		private string _sound;

		public Man(string sound) 
			: base(sound)
		{
			_sound = sound;
		}

		public override Gender Gender => Gender.Male;

		public override void GetSound()
		{
			Console.WriteLine("Adult {0} says: {1}", Gender, _sound);
		}
	}
}
