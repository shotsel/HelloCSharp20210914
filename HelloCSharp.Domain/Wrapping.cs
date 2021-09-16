using System;

namespace HelloCSharp.Domain
{
	public class Wrapping<TContent> : Item
	{
		TContent _content = default(TContent);

		public Wrapping() 
			: base(DateTime.MaxValue)
		{
		}

		public bool IsEmpty 
		{
			get
			{
				return object.Equals(_content, default(TContent));
			}
		}

		public bool IsFull
		{
			get
			{
				return !object.Equals(_content, default(TContent));
			}
		}

		public void Put(TContent content)
		{
			_content = content;
		}

		public TContent Remove()
		{
			return _content;
		}
	}
}
