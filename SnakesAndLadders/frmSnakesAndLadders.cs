using System;
using System.Collections.Concurrent;
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
		private ConcurrentDictionary<int, Image> DieImages;
		private ConcurrentBag<Tile> BoardTiles;

		public frmSnakesAndLadders(List<Player> players, Die die)
		{
			InitializeComponent();

			PlayerQueue = new Queue<Player>();

			DieImages = new ConcurrentDictionary<int, Image>();

			BoardTiles = new ConcurrentBag<Tile>();

			Players = players;

			Die = die;

			CreateBoard();

			InitializePlayerPosition();

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

			DieImages.TryAdd(1, image);

			image = Image.FromFile(directory + "Resources\\two.jpg");
			DieImages.TryAdd(2, image);

			image = Image.FromFile(directory + "Resources\\three.jpg");
			DieImages.TryAdd(3, image);

			image = Image.FromFile(directory + "Resources\\four.jpg");
			DieImages.TryAdd(4, image);

			image = Image.FromFile(directory + "Resources\\five.jpg");
			DieImages.TryAdd(5, image);

			image = Image.FromFile(directory + "Resources\\six.jpg");
			DieImages.TryAdd(6, image);
		}

		private void InitializePlayerPosition()
		{
			//this would be better implemented by creating the pawns dynamically and not having a restriction on players allowed
			
			Tile firstTile = BoardTiles.First(x => x.TileNumber == 1);

			int count = 1;
			foreach(Player p in Players)
			{
				p.PlayerTile = firstTile;

				switch(count)
				{
					case 1:
						p.PlayerPawn = player1;
						break;
					case 2:
						p.PlayerPawn = player2;
						break;
					case 3:
						p.PlayerPawn = player3;
						break;
					case 4:
						p.PlayerPawn = player4;
						break;

					default:
						break;
				}

				count++;
			}
		}

		private void CreateBoard()
		{
			//grid dimensions
			int tileWidth = boardImage.Size.Width / 10;
			int tileHeight = boardImage.Size.Height / 10;

			int tileNumber = 1;
			for(int row = 1; row <= 10; row++)
			{
				for(int col = 1; col <= 10; col++)
				{
					Tile tile = new Tile(tileNumber);

					tile.X = tileWidth * row;
					tile.Y = tileHeight * col;

					tileNumber++;

					BoardTiles.Add(tile);
				}
			}

		}

		private void MovePlayer(Player player, int rollVal)
		{
			//move player to the position on the board according to their roll
			//check if they landed on a snake or ladder and adjust position if so
			//check if they have won the game

			SetPlayerNewBoardPosition(player, rollVal);

			MovePlayerToNewBoardPosition(player);
		}

		private void SetPlayerNewBoardPosition(Player player, int rollVal)
		{
			int curTileNumber = player.PlayerTile.TileNumber;
			curTileNumber += rollVal;

			Tile newPlayerTile = BoardTiles.First(x => x.TileNumber == curTileNumber);

			player.PlayerTile = newPlayerTile;
		}

		private void MovePlayerToNewBoardPosition(Player player)
		{
			player.PlayerPawn.SetBounds(player.PlayerTile.X, player.PlayerTile.Y, player.PlayerPawn.Width, player.PlayerPawn.Height);
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

				MovePlayer(player, rollVal);

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				PlayerQueue.Enqueue(player);

				StringBuilder sb = new StringBuilder();

				Player nextPlayer = PlayerQueue.Peek();

				IndicatePlayerToRoll(sb, nextPlayer);
			}
		}

		#endregion

	}
}
