using HelloCSharp.Tools.Physics;
using System;

namespace HelloCSharp.Domain
{
	public class Sandwich : Item
	{
		private readonly Weight _weight;

		private Sandwich()
			: base(DateTime.Now.AddDays(3))
		{ }

		public Sandwich(Weight weight)
			: this()
		{
			_weight = weight;

			Size = ComputeSize(weight);
		}

		/// <summary>
		/// Creates <see cref="Sandwich"/> based on weight expressed in grams.
		/// </summary>
		/// <param name="weight">Grams</param>
		public Sandwich(int weight)
			: this(new Weight(weight))
		{
		}

		public Weight Weight => _weight;

		public string Name { get; set; }

		public SandwichSize Size { get; }

		private SandwichSize ComputeSize(Weight weight)
		{
			/*
			 * TODO implement size computation. Do some automation, decision making code on behalf human's perception.
			 */
			return SandwichSize.Small;
		}
	}
}
