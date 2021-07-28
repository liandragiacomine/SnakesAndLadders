using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakesAndLadders
{
	public partial class frmSnakesAndLadders : Form
	{

		public frmSnakesAndLadders(List<Player> players)
		{
			InitializeComponent();

			Players = players;

			DetermineOrder();

			StartGame();
		}

		public List<Player> Players {get; private set; }

		private void DetermineOrder()
		{

		}

		private void StartGame()
		{
	


		}

	}
}
