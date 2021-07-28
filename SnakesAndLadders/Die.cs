using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
	public class Die
	{
		public Die()
		{
		}

		public int Value { get; private set; }

		public int RollDie()
		{
			Random random = new Random();

			return random.Next(1, 6);
		}
	}
}
