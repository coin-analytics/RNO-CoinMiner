namespace coinminner
{
	// Token: 0x02000002 RID: 2
	public partial class CoinMinner : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000E RID: 14 RVA: 0x000024EF File Offset: 0x000006EF
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002510 File Offset: 0x00000710
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::coinminner.CoinMinner));
			this.WalletTextBox = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.ConnectButton = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.errorLabel = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.WalletTextBox.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.WalletTextBox.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.WalletTextBox.Location = new global::System.Drawing.Point(557, 328);
			this.WalletTextBox.Margin = new global::System.Windows.Forms.Padding(4);
			this.WalletTextBox.Name = "WalletTextBox";
			this.WalletTextBox.Size = new global::System.Drawing.Size(401, 39);
			this.WalletTextBox.TabIndex = 2;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("맑은 고딕", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.label2.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new global::System.Drawing.Point(552, 292);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(251, 32);
			this.label2.TabIndex = 3;
			this.label2.Text = "Mining wallet address";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("맑은 고딕", 7.875f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.label3.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label3.Location = new global::System.Drawing.Point(925, 642);
			this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(177, 30);
			this.label3.TabIndex = 4;
			this.label3.Text = "Miner version 1.2";
			this.label3.Click += new global::System.EventHandler(this.label3_Click);
			this.ConnectButton.BackColor = global::System.Drawing.Color.Black;
			this.ConnectButton.FlatAppearance.BorderSize = 0;
			this.ConnectButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.ConnectButton.Font = new global::System.Drawing.Font("맑은 고딕", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 129);
			this.ConnectButton.ForeColor = global::System.Drawing.Color.White;
			this.ConnectButton.Location = new global::System.Drawing.Point(557, 442);
			this.ConnectButton.Margin = new global::System.Windows.Forms.Padding(4);
			this.ConnectButton.Name = "ConnectButton";
			this.ConnectButton.Size = new global::System.Drawing.Size(171, 56);
			this.ConnectButton.TabIndex = 5;
			this.ConnectButton.Text = "Connect";
			this.ConnectButton.UseVisualStyleBackColor = false;
			this.ConnectButton.Click += new global::System.EventHandler(this.ConnectButton_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("맑은 고딕", 16.125f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 129);
			this.label1.Location = new global::System.Drawing.Point(542, 154);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(559, 59);
			this.label1.TabIndex = 1;
			this.label1.Text = "Connect into RNO Mining";
			this.label4.AutoSize = true;
			this.label4.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.label4.Font = new global::System.Drawing.Font("맑은 고딕", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.label4.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label4.Location = new global::System.Drawing.Point(555, 514);
			this.label4.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(356, 30);
			this.label4.TabIndex = 6;
			this.label4.Text = "Forgot the mining wallet address?";
			this.label5.AutoSize = true;
			this.label5.BackColor = global::System.Drawing.Color.Transparent;
			this.label5.Font = new global::System.Drawing.Font("맑은 고딕", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 129);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(104, 352);
			this.label5.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(0, 45);
			this.label5.TabIndex = 8;
			this.errorLabel.AutoSize = true;
			this.errorLabel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.errorLabel.Font = new global::System.Drawing.Font("맑은 고딕", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.errorLabel.ForeColor = global::System.Drawing.Color.Crimson;
			this.errorLabel.Location = new global::System.Drawing.Point(552, 388);
			this.errorLabel.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
			this.errorLabel.Name = "errorLabel";
			this.errorLabel.Size = new global::System.Drawing.Size(0, 30);
			this.errorLabel.TabIndex = 9;
			this.errorLabel.Click += new global::System.EventHandler(this.errorLabel_Click);
			this.label6.AutoSize = true;
			this.label6.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.label6.Font = new global::System.Drawing.Font("맑은 고딕", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.label6.ForeColor = global::System.Drawing.Color.MediumBlue;
			this.label6.Location = new global::System.Drawing.Point(895, 514);
			this.label6.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(58, 30);
			this.label6.TabIndex = 11;
			this.label6.Text = "Click";
			this.label6.Click += new global::System.EventHandler(this.label6_Click);
			this.label7.AutoSize = true;
			this.label7.BackColor = global::System.Drawing.Color.Transparent;
			this.label7.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.label7.Font = new global::System.Drawing.Font("Segoe UI Emoji", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.Color.White;
			this.label7.Location = new global::System.Drawing.Point(175, 512);
			this.label7.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(241, 35);
			this.label7.TabIndex = 13;
			this.label7.Text = " www.Rnocoin.com ";
			this.label7.Click += new global::System.EventHandler(this.label7_Click);
			this.pictureBox3.BackgroundImage = global::coinminner.Properties.Resources.closeBtn1;
			this.pictureBox3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBox3.Location = new global::System.Drawing.Point(1058, 6);
			this.pictureBox3.Margin = new global::System.Windows.Forms.Padding(6);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new global::System.Drawing.Size(55, 54);
			this.pictureBox3.TabIndex = 12;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new global::System.EventHandler(this.pictureBox3_Click);
			this.pictureBox2.BackgroundImage = global::coinminner.Properties.Resources.walletIco;
			this.pictureBox2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new global::System.Drawing.Point(960, 320);
			this.pictureBox2.Margin = new global::System.Windows.Forms.Padding(6);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(54, 50);
			this.pictureBox2.TabIndex = 10;
			this.pictureBox2.TabStop = false;
			this.pictureBox1.BackgroundImage = global::coinminner.Properties.Resources.KakaoTalk_20190422_203135019;
			this.pictureBox1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new global::System.Drawing.Point(-11, -2);
			this.pictureBox1.Margin = new global::System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(546, 690);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.pictureBox1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
			this.pictureBox1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(13f, 24f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(1122, 686);
			base.ControlBox = false;
			base.Controls.Add(this.label7);
			base.Controls.Add(this.pictureBox3);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.errorLabel);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.ConnectButton);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.WalletTextBox);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			this.Cursor = global::System.Windows.Forms.Cursors.Default;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4);
			base.Name = "CoinMinner";
			this.Text = "Form1";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000008 RID: 8
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.TextBox WalletTextBox;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Button ConnectButton;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Label errorLabel;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Label label7;
	}
}
