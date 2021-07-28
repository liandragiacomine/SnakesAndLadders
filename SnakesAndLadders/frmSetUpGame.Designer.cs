
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lblID = new System.Windows.Forms.Label();
			this.lbxPlayerID = new System.Windows.Forms.ListBox();
			this.btnAddPlayer = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnStart.Location = new System.Drawing.Point(284, 319);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(234, 42);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start Game";
			this.btnStart.UseVisualStyleBackColor = false;
			//this.btnStart.Click += new System.EventHandler(this.btnStart.Click)
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(284, 72);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(234, 31);
			this.textBox1.TabIndex = 1;
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Location = new System.Drawing.Point(166, 75);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(86, 25);
			this.lblID.TabIndex = 2;
			this.lblID.Text = "Player ID:";
			// 
			// lbxPlayerID
			// 
			this.lbxPlayerID.BackColor = System.Drawing.Color.LightGray;
			this.lbxPlayerID.FormattingEnabled = true;
			this.lbxPlayerID.ItemHeight = 25;
			this.lbxPlayerID.Location = new System.Drawing.Point(284, 136);
			this.lbxPlayerID.Name = "lbxPlayerID";
			this.lbxPlayerID.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbxPlayerID.Size = new System.Drawing.Size(234, 129);
			this.lbxPlayerID.TabIndex = 3;
			// 
			// btnAddPlayer
			// 
			this.btnAddPlayer.Location = new System.Drawing.Point(550, 72);
			this.btnAddPlayer.Name = "btnAddPlayer";
			this.btnAddPlayer.Size = new System.Drawing.Size(86, 34);
			this.btnAddPlayer.TabIndex = 4;
			this.btnAddPlayer.Text = "Add";
			this.btnAddPlayer.UseVisualStyleBackColor = true;
			// 
			// frmSetPlayers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnAddPlayer);
			this.Controls.Add(this.lbxPlayerID);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnStart);
			this.Name = "frmSetPlayers";
			this.ShowIcon = false;
			this.Text = "Snakes And Ladders";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.ListBox lbxPlayerID;
		private System.Windows.Forms.Button btnAddPlayer;
	}
}

