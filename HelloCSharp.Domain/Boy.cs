using System;

namespace HelloCSharp.Domain
{
	public class Boy : Human
	{
		public Boy()
			: base("cry")
		{
		}

		public override Gender Gender => Gender.Male;

		public void GetSound()
		{
			Console.WriteLine("boy is crying");
		}
	}
}
