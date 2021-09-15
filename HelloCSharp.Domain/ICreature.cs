using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp.Domain
{
	public interface ICreature : ISomething
	{
		void GetSound();

		void Eat(Sandwich sandwich);
	}
}
