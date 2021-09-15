using System;

namespace HelloCSharp.Domain
{
	class Bird : Animal
	{
		public Bird(bool isDomestic = false) 
			: base(isDomestic)
		{
		}

		public override void GetSound()
		{
			Console.WriteLine("Bird gives melody");
		}
	}
}
