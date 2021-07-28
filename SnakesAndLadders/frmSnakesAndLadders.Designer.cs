
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
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.boardImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.boardImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.boardImage.Location = new System.Drawing.Point(28, 44);
			this.boardImage.Name = "pictureBox1";
			this.boardImage.Size = new System.Drawing.Size(600, 600);
			this.boardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.boardImage.TabIndex = 0;
			this.boardImage.TabStop = false;
			// 
			// button1
			// 
			this.btnRoll.BackColor = System.Drawing.Color.Yellow;
			this.btnRoll.Location = new System.Drawing.Point(666, 361);
			this.btnRoll.Name = "btnRoll";
			this.btnRoll.Size = new System.Drawing.Size(143, 52);
			this.btnRoll.TabIndex = 1;
			this.btnRoll.Text = "Roll";
			this.btnRoll.UseVisualStyleBackColor = false;
			this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(666, 221);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(143, 115);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// label1
			// 
			this.lblTip.AutoSize = true;
			this.lblTip.Location = new System.Drawing.Point(678, 68);
			this.lblTip.Name = "label1";
			this.lblTip.Size = new System.Drawing.Size(108, 25);
			this.lblTip.TabIndex = 3;
			this.lblTip.Text = "Player\'s turn";
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Red;
			this.pictureBox3.Location = new System.Drawing.Point(38, 590);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(22, 22);
			this.pictureBox3.TabIndex = 4;
			this.pictureBox3.TabStop = false;
			// 
			// frmSnakesAndLadders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(856, 680);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.lblTip);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.btnRoll);
			this.Controls.Add(this.boardImage);
			this.Name = "frmSnakesAndLadders";
			this.ShowIcon = false;
			this.Text = "Snakes And Ladders";
			((System.ComponentModel.ISupportInitialize)(this.boardImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtbBoard;
		private System.Windows.Forms.PictureBox boardImage;
		private System.Windows.Forms.Button btnRoll;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lblTip;
		private System.Windows.Forms.PictureBox pictureBox3;
	}
}