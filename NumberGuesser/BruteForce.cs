using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
	class BruteForce : Player
	{
		public int guessNum = 1;

		public override int Guess()
		{
			return guessNum++;
		}
	}
}
