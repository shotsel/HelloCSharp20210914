using HelloCSharp.Tools.Physics;
using System;

namespace HelloCSharp.Domain
{
	public class Sandwich : Item, IEquatable<Sandwich>, IComparable<Sandwich>, IComparable<Wrapping<Sandwich>>
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
		public Sandwich(int grams)
			: this(Weight.FromGrams(grams))
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

		public bool Equals(Sandwich other)
		{
			if (ReferenceEquals(this, other))
			{ 
				return true; 
			}

			return _weight == other._weight;
			//return _weight.Equals(other._weight); 
		}

		public int CompareTo(Sandwich other)
		{
			if (other == null)
			{
				// TODO handle null somehow to prevent crashes (unexpected)
				return 1;
			}

			/*
			 * delegate to size indication or use custom implementiton below
			 * 
			 * return Size.CompareTo(other.Size);
			 */
			
			// weight tolerance in grams
			var weightTolerance = 10;

			if (other.Weight.GetGrams() + weightTolerance < _weight.GetGrams() - weightTolerance)
			{
				return 1;
			}

			if (other.Weight.GetGrams() - weightTolerance > _weight.GetGrams() + weightTolerance)
			{
				return -1;
			}

			return 0;
		}

		public int CompareTo(Wrapping<Sandwich> other)
		{
			if (other == null)
			{
				// TODO handle null somehow to prevent crashes (unexpected)
				return 1;
			}

			if (other.IsEmpty)
			{
				return 1;
			}

			return CompareTo(other.Show());
		}
	}
}
