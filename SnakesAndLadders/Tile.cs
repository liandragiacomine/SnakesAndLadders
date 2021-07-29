using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
	public class Tile
	{

		public Tile(int tileNumber)
		{
			TileNumber = tileNumber;
		}

		public int X { get; set; }

		public int Y { get; set; }

		public int TileNumber { get; private set; }


	}
}
