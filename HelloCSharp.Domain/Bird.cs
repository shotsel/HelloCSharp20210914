namespace HelloCSharp.Domain
{
	class Bird : Animal
	{
		public Bird(string sound, bool isDomestic = false) 
			: base(sound, isDomestic)
		{
		}
	}
}
