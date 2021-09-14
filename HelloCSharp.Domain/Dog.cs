using System;
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

		public void ChangeOwner(Human owner)
		{
			// hand can not be swaped, it's Man's private. 
			// Due Human nature, it's not possible to swap body elements whenever you want.
			// Even though property (gated access) to the private field exists, still only "viewing" option is possible
			// owner.Left = new Arm();
		}
	}
}
