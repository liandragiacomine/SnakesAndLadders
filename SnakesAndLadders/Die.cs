using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

			int val = random.Next(1, 6);

			return val;
		}
	}
}
