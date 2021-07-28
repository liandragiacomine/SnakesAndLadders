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

		public void Move(int rollVal)
		{
			//move player to the position on the board according to their roll
			//check if they landed on a snake or ladder and adjust position if so
			//check if they have won the game


		}

	}
}
