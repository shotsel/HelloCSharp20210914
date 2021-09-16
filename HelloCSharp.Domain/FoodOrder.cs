using System.Collections.Generic;

namespace HelloCSharp.Domain
{
	internal class FoodOrder
	{
		private List<SandwichSize> _sizes = new List<SandwichSize>();

		public FoodOrder(IEnumerable<SandwichSize> sizes)
		{
			_sizes = new List<SandwichSize>(sizes);
		}

		public FoodOrder(IDictionary<SandwichSize, int> sizes)
		{

		}

		public void Add(SandwichSize size, int count = 1)
		{

		}

		public IEnumerable<SandwichSize> GetDetails()
		{
			return _sizes;
		}
	}
}