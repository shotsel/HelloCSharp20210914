﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp.Domain
{
	class Dog : Animal
	{
		/* 
		 * TODO how to implement owner?
		 */

		public Dog(string sound = "bark") 
			: base(sound, Animal.AlwaysDomestic)
		{
		}
	}
}
