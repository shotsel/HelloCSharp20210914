using System;

namespace HelloCSharp.Domain
{
	internal class Something
	{
		public Something()
		{
			CreationDate = DateTime.Now;
		}

		public Something(DateTime creationDate)
		{
			CreationDate = creationDate;
		}

		public DateTime CreationDate { get; }
	}
}