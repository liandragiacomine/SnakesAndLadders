using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakesAndLadders
{
	public class Player
	{
		public Player(string id)
		{
			PlayerID = id;
		}

		public string PlayerID { get; private set; }

		public Tile PlayerTile { get; set; }

		public PictureBox PlayerPawn { get; set; }

		public override string ToString()
		{
			return PlayerID;
		}

	}
}
