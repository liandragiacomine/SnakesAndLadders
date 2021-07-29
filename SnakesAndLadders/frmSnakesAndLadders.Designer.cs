
namespace SnakesAndLadders
{
	partial class frmSnakesAndLadders
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSnakesAndLadders));
			this.boardImage = new System.Windows.Forms.PictureBox();
			this.btnRoll = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lblTip = new System.Windows.Forms.Label();
			this.player1 = new System.Windows.Forms.PictureBox();
			this.player2 = new System.Windows.Forms.PictureBox();
			this.player3 = new System.Windows.Forms.PictureBox();
			this.player4 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.boardImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.player3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.player4)).BeginInit();
			this.SuspendLayout();
			// 
			// boardImage
			// 
			this.boardImage.Image = ((System.Drawing.Image)(resources.GetObject("boardImage.Image")));
			this.boardImage.Location = new System.Drawing.Point(20, 26);
			this.boardImage.Margin = new System.Windows.Forms.Padding(2);
			this.boardImage.Name = "boardImage";
			this.boardImage.Size = new System.Drawing.Size(420, 360);
			this.boardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.boardImage.TabIndex = 0;
			this.boardImage.TabStop = false;
			// 
			// btnRoll
			// 
			this.btnRoll.BackColor = System.Drawing.Color.Yellow;
			this.btnRoll.Location = new System.Drawing.Point(466, 217);
			this.btnRoll.Margin = new System.Windows.Forms.Padding(2);
			this.btnRoll.Name = "btnRoll";
			this.btnRoll.Size = new System.Drawing.Size(100, 31);
			this.btnRoll.TabIndex = 1;
			this.btnRoll.Text = "Roll";
			this.btnRoll.UseVisualStyleBackColor = false;
			this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(466, 133);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 69);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// lblTip
			// 
			this.lblTip.AutoSize = true;
			this.lblTip.Location = new System.Drawing.Point(475, 41);
			this.lblTip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTip.Name = "lblTip";
			this.lblTip.Size = new System.Drawing.Size(72, 15);
			this.lblTip.TabIndex = 3;
			this.lblTip.Text = "Player\'s turn";
			// 
			// player1
			// 
			this.player1.BackColor = System.Drawing.Color.Red;
			this.player1.Location = new System.Drawing.Point(24, 356);
			this.player1.Margin = new System.Windows.Forms.Padding(2);
			this.player1.Name = "player1";
			this.player1.Size = new System.Drawing.Size(15, 13);
			this.player1.TabIndex = 4;
			this.player1.TabStop = false;
			this.player1.Visible = false;
			// 
			// player2
			// 
			this.player2.BackColor = System.Drawing.Color.Blue;
			this.player2.Location = new System.Drawing.Point(34, 356);
			this.player2.Margin = new System.Windows.Forms.Padding(2);
			this.player2.Name = "player2";
			this.player2.Size = new System.Drawing.Size(15, 13);
			this.player2.TabIndex = 5;
			this.player2.TabStop = false;
			this.player2.Visible = false;
			// 
			// player3
			// 
			this.player3.BackColor = System.Drawing.Color.Yellow;
			this.player3.Location = new System.Drawing.Point(24, 356);
			this.player3.Margin = new System.Windows.Forms.Padding(2);
			this.player3.Name = "player3";
			this.player3.Size = new System.Drawing.Size(15, 13);
			this.player3.TabIndex = 6;
			this.player3.TabStop = false;
			this.player3.Visible = false;
			// 
			// player4
			// 
			this.player4.BackColor = System.Drawing.Color.Green;
			this.player4.Location = new System.Drawing.Point(34, 356);
			this.player4.Margin = new System.Windows.Forms.Padding(2);
			this.player4.Name = "player4";
			this.player4.Size = new System.Drawing.Size(15, 13);
			this.player4.TabIndex = 7;
			this.player4.TabStop = false;
			this.player4.Visible = false;
			// 
			// frmSnakesAndLadders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(599, 408);
			this.Controls.Add(this.player4);
			this.Controls.Add(this.player3);
			this.Controls.Add(this.player2);
			this.Controls.Add(this.player1);
			this.Controls.Add(this.lblTip);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.btnRoll);
			this.Controls.Add(this.boardImage);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frmSnakesAndLadders";
			this.ShowIcon = false;
			this.Text = "Snakes And Ladders";
			((System.ComponentModel.ISupportInitialize)(this.boardImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.player3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.player4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtbBoard;
		private System.Windows.Forms.PictureBox boardImage;
		private System.Windows.Forms.Button btnRoll;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lblTip;
		private System.Windows.Forms.PictureBox player1;
		private System.Windows.Forms.PictureBox player2;
		private System.Windows.Forms.PictureBox player3;
		private System.Windows.Forms.PictureBox player4;
	}
}