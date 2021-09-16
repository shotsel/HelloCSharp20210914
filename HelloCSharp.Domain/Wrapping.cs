using System;

namespace HelloCSharp.Domain
{
	public class Wrapping<TContent> : Item, IEquatable<Wrapping<TContent>>
	{
		TContent _content = default(TContent);

		private bool _hasContent = false;

		public Wrapping() 
			: base(DateTime.MaxValue)
		{
		}

		protected Wrapping(TContent content)
			: base(DateTime.MaxValue)
		{
			_content = content;
			_hasContent = true;
		}

		public bool IsEmpty 
		{
			get
			{
				return !_hasContent;
			}
		}

		public bool IsFull
		{
			get
			{
				return _hasContent;
			}
		}

		public void Put(TContent content)
		{
			_hasContent = true;
			_content = content;
		}

		public TContent Remove()
		{
			_hasContent = false;
			return _content;
		}

		public TContent Show()
		{
			return _content;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(obj, this))
			{
				return true;
			}

			var wrappingForTheSame = obj as Wrapping<TContent>; 

			if (wrappingForTheSame == null)
			{
				return false;
			}

			return Equals(wrappingForTheSame);
		}

		public bool Equals(Wrapping<TContent> other)
		{
			if (ReferenceEquals(other, this))
			{ 
				return true; 
			}

			// return ReferenceEquals(_content, other._content);
			return _hasContent && _content.Equals(other._content);
		}

		public override int GetHashCode()
		{
			if (IsEmpty)
			{
				return base.GetHashCode();
			}

			return _content.GetHashCode();
		}
	}
}
