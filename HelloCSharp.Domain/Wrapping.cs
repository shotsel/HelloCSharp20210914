using System;

namespace HelloCSharp.Domain
{
	public class Wrapping : Item
	{
		object _content = null;

		public Wrapping() 
			: base(DateTime.MaxValue)
		{
		}

		public bool IsEmpty 
		{
			get
			{
				return _content == null;
			}
		}

		public bool IsFull
		{
			get
			{
				return _content != null;
			}
		}

		public void Put(object content)
		{
			_content = content;
		}

		public object Remove()
		{
			return _content;
		}
	}
}
