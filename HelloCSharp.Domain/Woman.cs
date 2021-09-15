namespace HelloCSharp.Domain
{
	class Woman : Human
	{
		public Woman(string sound) 
			: base(sound)
		{
		}

		public override Gender Gender => Gender.Female;
	}
}
