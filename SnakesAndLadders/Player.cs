using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
	public class Player
	{
		public Player(string id)
		{
			PlayerID = id;
		}

		public string PlayerID { get; private set; }

		public override string ToString()
		{
			return PlayerID;
		}
	}
}
