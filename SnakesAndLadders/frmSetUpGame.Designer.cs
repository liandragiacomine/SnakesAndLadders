
namespace SnakesAndLadders
{
	partial class frmSetPlayers
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnStart = new System.Windows.Forms.Button();
			this.tbxPlayerID = new System.Windows.Forms.TextBox();
			this.lblID = new System.Windows.Forms.Label();
			this.lbxPlayers = new System.Windows.Forms.ListBox();
			this.btnAddPlayer = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.Color.Lime;
			this.btnStart.Location = new System.Drawing.Point(277, 358);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(234, 42);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start Game";
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// tbxPlayerID
			// 
			this.tbxPlayerID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tbxPlayerID.Location = new System.Drawing.Point(270, 138);
			this.tbxPlayerID.Name = "tbxPlayerID";
			this.tbxPlayerID.Size = new System.Drawing.Size(241, 31);
			this.tbxPlayerID.TabIndex = 1;
			// 
			// lblID
			// 
			this.lblID.BackColor = System.Drawing.Color.Ivory;
			this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblID.Location = new System.Drawing.Point(142, 138);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(122, 29);
			this.lblID.TabIndex = 2;
			this.lblID.Text = "Player ID:";
			// 
			// lbxPlayers
			// 
			this.lbxPlayers.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.lbxPlayers.FormattingEnabled = true;
			this.lbxPlayers.ItemHeight = 25;
			this.lbxPlayers.Location = new System.Drawing.Point(277, 201);
			this.lbxPlayers.Name = "lbxPlayers";
			this.lbxPlayers.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbxPlayers.Size = new System.Drawing.Size(234, 129);
			this.lbxPlayers.TabIndex = 3;
			// 
			// btnAddPlayer
			// 
			this.btnAddPlayer.BackColor = System.Drawing.Color.DarkOrange;
			this.btnAddPlayer.Location = new System.Drawing.Point(530, 137);
			this.btnAddPlayer.Name = "btnAddPlayer";
			this.btnAddPlayer.Size = new System.Drawing.Size(105, 33);
			this.btnAddPlayer.TabIndex = 4;
			this.btnAddPlayer.Text = "Add";
			this.btnAddPlayer.UseVisualStyleBackColor = false;
			this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(186, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(408, 44);
			this.label1.TabIndex = 5;
			this.label1.Text = "Snakes And Ladders";
			// 
			// frmSetPlayers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Ivory;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAddPlayer);
			this.Controls.Add(this.lbxPlayers);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.tbxPlayerID);
			this.Controls.Add(this.btnStart);
			this.Name = "frmSetPlayers";
			this.ShowIcon = false;
			this.Text = "Snakes And Ladders";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tbxPlayerID;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.ListBox lbxPlayers;
		private System.Windows.Forms.Button btnAddPlayer;
		private System.Windows.Forms.Label label1;
	}
}

