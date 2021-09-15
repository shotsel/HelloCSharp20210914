using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp.Domain
{
	class Dog : Animal
	{
		private readonly string _sound;

		/* 
* TODO how to implement owner?
*/

		public Dog(string sound = "bark") 
			: base(Animal.AlwaysDomestic)
		{
			_sound = sound;
		}

		public void ChangeOwner(Human owner)
		{
			// hand can not be swaped, it's Man's private. 
			// Due Human nature, it's not possible to swap body elements whenever you want.
			// Even though property (gated access) to the private field exists, still only "viewing" option is possible
			// owner.Left = new Arm();
		}

		public override void GetSound()
		{
			Console.WriteLine("dog does " + _sound);
		}
	}
}
