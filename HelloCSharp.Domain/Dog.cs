using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp.Domain
{
	class Dog : Animal
	{
		public Dog(string sound) 
			: base(sound, Animal.AlwaysDomestic)
		{
		}
	}
}
