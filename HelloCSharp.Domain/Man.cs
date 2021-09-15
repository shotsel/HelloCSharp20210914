namespace HelloCSharp.Domain
{
	public class Man : Human
	{
		public Man(string sound) 
			: base(sound)
		{
		}

		public override Gender Gender => Gender.Male;
	}
}
