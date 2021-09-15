using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp.Domain
{
	public class Item : ISomething
	{
		public Item(DateTime expireDate)
		{
			ExpireDate = expireDate;
			CreationDate = DateTime.Now;
		}

		public DateTime ExpireDate { get; }

		public DateTime CreationDate { get; }
	}
 }
