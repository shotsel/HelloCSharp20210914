using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp.Domain
{
	public class Item : Something
	{
		public Item(DateTime expireDate)
		{
			ExpireDate = expireDate;
		}

		public DateTime ExpireDate { get; }
	}
 }
