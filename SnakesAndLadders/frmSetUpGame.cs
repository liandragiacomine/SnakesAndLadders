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
	public partial class frmSetPlayers : Form
	{
		public frmSetPlayers()
		{
			InitializeComponent();
		}

		#region Handlers

		private void btnStart_Click(object sender, EventArgs e)
		{
			try
			{
				List<Player> players = GetPlayers();

				frmSnakesAndLadders frm = new frmSnakesAndLadders(players);

				frm.Show();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnAddPlayer_Click(object sender, EventArgs e)
		{
			try
			{
				string playerID = tbxPlayerID.Text;

				Validate(playerID);

				Player player = new Player(playerID);

				lbxPlayers.Items.Add(player);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		#endregion

		private void Validate(string playerID)
		{
			if(string.IsNullOrWhiteSpace(playerID))
			{
				throw new ArgumentOutOfRangeException("Player ID cannot be null");
			}

			if(lbxPlayers.Items.Count > 6)
			{
				throw new ArgumentOutOfRangeException("Maximum of 6 players allowed");
			}
			
			foreach(Player p in lbxPlayers.Items)
			{
				if(p.PlayerID == playerID)
				{
					throw new ArgumentOutOfRangeException(playerID + " already exists. Please enter a new ID.");
				}
			}
		}


		private List<Player> GetPlayers()
		{
			List<Player> players = new List<Player>();

			foreach(Player p in lbxPlayers.Items)
			{
				players.Add(p);
			}

			return players;
		}
	}
}
