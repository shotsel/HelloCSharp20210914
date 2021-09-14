using System;

namespace HelloCSharp.Domain
{
	class Sandwich : Item
	{
		public Sandwich(int size) 
			: base(DateTime.Now.AddDays(3))
		{
			Size = size;
		}

		/*
		 * TODO number is not so expresive because i dont know what it means
		 */
		public int Size { get; }
	}
}
