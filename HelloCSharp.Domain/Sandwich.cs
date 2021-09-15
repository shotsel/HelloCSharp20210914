using HelloCSharp.Tools.Physics;
using System;

namespace HelloCSharp.Domain
{
	public class Sandwich : Item
	{
		private Sandwich()
			: base(DateTime.Now.AddDays(3))
		{ }

		/// <summary>
		/// Creates <see cref="Sandwich"/> based on weight expressed in grams.
		/// </summary>
		/// <param name="weight">Grams</param>
		public Sandwich(int weight) 
			: this()
		{
			Weight = new Weight(weight);
		}

		public Sandwich(Weight weight) 
			: this()
		{
			Weight = weight;
		}

		public Weight Weight { get; }
	}
}
