using System;

namespace HelloCSharp.Domain
{
	public class Something
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