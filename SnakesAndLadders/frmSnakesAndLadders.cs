using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakesAndLadders
{
	public partial class frmSnakesAndLadders : Form
	{
		private Die Die;

		private List<Player> Players;
		private Queue<Player> PlayerQueue;
		private Dictionary<int, Image> DieImages = new Dictionary<int, Image>();

		public frmSnakesAndLadders(List<Player> players, Die die)
		{
			InitializeComponent();

			PlayerQueue = new Queue<Player>();

			Players = players;

			Die = die;

			SetDieImages();

			StartGame();
		}

		private void StartGame()
		{
			Dictionary<Player, int> playerDieRoll = RollDieForAllPlayers();

			while(!ContainsDifferentValues(playerDieRoll))
			{
				playerDieRoll = RollDieForAllPlayers();
			}

			IOrderedEnumerable<KeyValuePair<Player, int>> rollValues = playerDieRoll.OrderByDescending(x => x.Value);

			foreach(KeyValuePair<Player, int> playerRoll in rollValues)
			{
				PlayerQueue.Enqueue(playerRoll.Key);
			}

			DisplayOrder(rollValues);
		}

		private Dictionary<Player, int> RollDieForAllPlayers()
		{
			Dictionary<Player, int> playerDieRoll = new Dictionary<Player, int>();

			foreach(Player p in Players)
			{
				int val = Die.RollDie();

				playerDieRoll.Add(p, val);
			}

			return playerDieRoll;
		}

		private bool ContainsDifferentValues(Dictionary<Player, int> playerDieRoll)
		{
			//ensure we have different values to determine who begins

			bool first = true;
			int rollVal = 0;
			foreach(int val in playerDieRoll.Values)
			{
				if(first)
				{
					rollVal = val;
					first = false;
					continue;
				}

				if(rollVal != val)
				{
					return true;
				}
			}

			return false;
		}

		private void DisplayOrder(IOrderedEnumerable<KeyValuePair<Player, int>> rollValues)
		{
			StringBuilder sb = new StringBuilder();

			Player firstPlayer = null;
			foreach(KeyValuePair<Player, int> keyValue in rollValues)
			{
				if(firstPlayer == null)
				{
					firstPlayer = keyValue.Key;
				}

				sb.Append("Player: ");
				sb.Append(keyValue.Key);
				sb.Append(", Roll: ");
				sb.Append(keyValue.Value);
				sb.Append("\n");
			}

			sb.Append("\n");
			sb.Append("\n");
			IndicatePlayerToRoll(sb, firstPlayer);

			lblTip.Text = sb.ToString();
		}

		private void IndicatePlayerToRoll(StringBuilder sb, Player player)
		{
			sb.Append(player);
			sb.Append(" please roll!");
		}

		private int Roll()
		{
			int rollVal = Die.RollDie();

			ModifyPictureBoxImage(rollVal);

			return rollVal;
		}


		private void SetDieImages()
		{
			string directory = Directory.GetCurrentDirectory();

			directory = directory.Substring(0, directory.LastIndexOf("SnakesAndLadders") + 16);

			directory += "\\";

			Image image = Image.FromFile(directory + "Resources\\one.jpg");

			DieImages.Add(1, image);

			image = Image.FromFile(directory + "Resources\\two.jpg");
			DieImages.Add(2, image);

			image = Image.FromFile(directory + "Resources\\three.jpg");
			DieImages.Add(3, image);

			image = Image.FromFile(directory + "Resources\\four.jpg");
			DieImages.Add(4, image);

			image = Image.FromFile(directory + "Resources\\five.jpg");
			DieImages.Add(5, image);

			image = Image.FromFile(directory + "Resources\\six.jpg");
			DieImages.Add(6, image);
		}

		private void ModifyPictureBoxImage(int value)
		{
			if (DieImages.TryGetValue(value, out Image image))
			{
				this.pictureBox2.Image = image;
			}

		}

		#region Handlers

		private void btnRoll_Click(object sender, EventArgs e)
		{
			Player player = PlayerQueue.Dequeue();

			try
			{
				int rollVal = Roll();

				player.Move(rollVal);

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				PlayerQueue.Enqueue(player);
			}
		}

		#endregion

	}
}
