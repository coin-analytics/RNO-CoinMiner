namespace coinminner
{
	// Token: 0x02000003 RID: 3
	public partial class Minner : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002B RID: 43 RVA: 0x000039D4 File Offset: 0x00001BD4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000039F4 File Offset: 0x00001BF4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::coinminner.Minner));
			this.label3 = new global::System.Windows.Forms.Label();
			this.WalletTextBox = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.MiningLevelLabel = new global::System.Windows.Forms.Label();
			this.WeightLabel = new global::System.Windows.Forms.Label();
			this.TotalHashRateLabel = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.ProcessCountBox = new global::System.Windows.Forms.ComboBox();
			this.notifyIcon1 = new global::System.Windows.Forms.NotifyIcon(this.components);
			this.button2 = new global::System.Windows.Forms.Button();
			this.label8 = new global::System.Windows.Forms.Label();
			this.button3 = new global::System.Windows.Forms.Button();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.label7 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
			base.SuspendLayout();
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("맑은 고딕", 7.875f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.label3.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label3.Location = new global::System.Drawing.Point(959, 66);
			this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(116, 30);
			this.label3.TabIndex = 14;
			this.label3.Text = "version 1.2";
			this.WalletTextBox.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.WalletTextBox.Location = new global::System.Drawing.Point(590, 179);
			this.WalletTextBox.Margin = new global::System.Windows.Forms.Padding(4);
			this.WalletTextBox.Name = "WalletTextBox";
			this.WalletTextBox.ReadOnly = true;
			this.WalletTextBox.Size = new global::System.Drawing.Size(489, 39);
			this.WalletTextBox.TabIndex = 15;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("맑은 고딕", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.label2.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new global::System.Drawing.Point(584, 127);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(251, 32);
			this.label2.TabIndex = 16;
			this.label2.Text = "Mining wallet address";
			this.button1.BackColor = global::System.Drawing.Color.Black;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new global::System.Drawing.Font("맑은 고딕", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(590, 627);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(189, 48);
			this.button1.TabIndex = 17;
			this.button1.Text = "채굴시작";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("맑은 고딕", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.label1.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label1.Location = new global::System.Drawing.Point(584, 253);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(149, 32);
			this.label1.TabIndex = 18;
			this.label1.Text = "Mining level";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("맑은 고딕", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.label4.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label4.Location = new global::System.Drawing.Point(584, 380);
			this.label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(143, 32);
			this.label4.TabIndex = 19;
			this.label4.Text = "채굴 가중치";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("맑은 고딕", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.label5.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label5.Location = new global::System.Drawing.Point(584, 295);
			this.label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(170, 32);
			this.label5.TabIndex = 20;
			this.label5.Text = "Total Hashrate";
			this.MiningLevelLabel.AutoSize = true;
			this.MiningLevelLabel.Font = new global::System.Drawing.Font("맑은 고딕", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.MiningLevelLabel.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.MiningLevelLabel.Location = new global::System.Drawing.Point(808, 253);
			this.MiningLevelLabel.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.MiningLevelLabel.Name = "MiningLevelLabel";
			this.MiningLevelLabel.Size = new global::System.Drawing.Size(149, 32);
			this.MiningLevelLabel.TabIndex = 21;
			this.MiningLevelLabel.Text = "Mining level";
			this.WeightLabel.AutoSize = true;
			this.WeightLabel.Font = new global::System.Drawing.Font("맑은 고딕", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.WeightLabel.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.WeightLabel.Location = new global::System.Drawing.Point(808, 380);
			this.WeightLabel.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.WeightLabel.Name = "WeightLabel";
			this.WeightLabel.Size = new global::System.Drawing.Size(143, 32);
			this.WeightLabel.TabIndex = 22;
			this.WeightLabel.Text = "나의 가중치";
			this.TotalHashRateLabel.AutoSize = true;
			this.TotalHashRateLabel.Font = new global::System.Drawing.Font("맑은 고딕", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.TotalHashRateLabel.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.TotalHashRateLabel.Location = new global::System.Drawing.Point(808, 295);
			this.TotalHashRateLabel.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TotalHashRateLabel.Name = "TotalHashRateLabel";
			this.TotalHashRateLabel.Size = new global::System.Drawing.Size(170, 32);
			this.TotalHashRateLabel.TabIndex = 23;
			this.TotalHashRateLabel.Text = "Total Hashrate";
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("맑은 고딕", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.label6.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label6.Location = new global::System.Drawing.Point(584, 430);
			this.label6.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(223, 32);
			this.label6.TabIndex = 24;
			this.label6.Text = "채굴 프로세스 갯수";
			this.ProcessCountBox.FormattingEnabled = true;
			this.ProcessCountBox.Location = new global::System.Drawing.Point(814, 432);
			this.ProcessCountBox.Name = "ProcessCountBox";
			this.ProcessCountBox.Size = new global::System.Drawing.Size(121, 32);
			this.ProcessCountBox.TabIndex = 25;
			this.ProcessCountBox.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.ProcessCountBox_KeyDown);
			this.notifyIcon1.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("notifyIcon1.Icon");
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.DoubleClick += new global::System.EventHandler(this.notifyIcon1_DoubleClick);
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("맑은 고딕", 7.875f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.button2.Location = new global::System.Drawing.Point(886, 627);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(189, 48);
			this.button2.TabIndex = 27;
			this.button2.Text = "창 내리기";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.label8.AutoSize = true;
			this.label8.Font = new global::System.Drawing.Font("Yu Gothic UI", 16.125f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.Location = new global::System.Drawing.Point(700, 44);
			this.label8.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(237, 59);
			this.label8.TabIndex = 33;
			this.label8.Text = "RNO Miner";
			this.button3.BackColor = global::System.Drawing.Color.Black;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button3.Font = new global::System.Drawing.Font("맑은 고딕", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.button3.ForeColor = global::System.Drawing.Color.White;
			this.button3.Location = new global::System.Drawing.Point(590, 627);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(189, 48);
			this.button3.TabIndex = 34;
			this.button3.Text = "채굴중지";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Visible = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click_1);
			this.label9.AutoSize = true;
			this.label9.BackColor = global::System.Drawing.Color.Transparent;
			this.label9.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.label9.Font = new global::System.Drawing.Font("Segoe UI Emoji", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.ForeColor = global::System.Drawing.Color.Black;
			this.label9.Location = new global::System.Drawing.Point(168, 513);
			this.label9.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(241, 35);
			this.label9.TabIndex = 35;
			this.label9.Text = " www.Rnocoin.com ";
			this.label9.Click += new global::System.EventHandler(this.label9_Click);
			this.label10.AutoSize = true;
			this.label10.Font = new global::System.Drawing.Font("맑은 고딕", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.label10.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label10.Location = new global::System.Drawing.Point(808, 337);
			this.label10.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(142, 32);
			this.label10.TabIndex = 37;
			this.label10.Text = "Pc Hashrate";
			this.label11.AutoSize = true;
			this.label11.Font = new global::System.Drawing.Font("맑은 고딕", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.label11.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label11.Location = new global::System.Drawing.Point(584, 337);
			this.label11.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(142, 32);
			this.label11.TabIndex = 36;
			this.label11.Text = "Pc Hashrate";
			this.label11.Click += new global::System.EventHandler(this.label11_Click);
			this.label12.AutoSize = true;
			this.label12.BackColor = global::System.Drawing.Color.Transparent;
			this.label12.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.label12.Font = new global::System.Drawing.Font("맑은 고딕", 7.875f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 129);
			this.label12.ForeColor = global::System.Drawing.SystemColors.MenuHighlight;
			this.label12.Location = new global::System.Drawing.Point(203, 557);
			this.label12.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(167, 30);
			this.label12.TabIndex = 41;
			this.label12.Text = "마이닝 로그보기";
			this.label12.Click += new global::System.EventHandler(this.label12_Click_1);
			this.pictureBox1.BackgroundImage = global::coinminner.Properties.Resources.KakaoTalk_20190422_213551232;
			this.pictureBox1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.ErrorImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.ErrorImage");
			this.pictureBox1.InitialImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.InitialImage");
			this.pictureBox1.Location = new global::System.Drawing.Point(-1, 1);
			this.pictureBox1.Margin = new global::System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(546, 690);
			this.pictureBox1.TabIndex = 32;
			this.pictureBox1.TabStop = false;
			this.pictureBox3.BackgroundImage = global::coinminner.Properties.Resources.closeBtn1;
			this.pictureBox3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBox3.Location = new global::System.Drawing.Point(1068, 0);
			this.pictureBox3.Margin = new global::System.Windows.Forms.Padding(6);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new global::System.Drawing.Size(55, 52);
			this.pictureBox3.TabIndex = 31;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new global::System.EventHandler(this.pictureBox3_Click_1);
			this.label7.AutoSize = true;
			this.label7.BackColor = global::System.Drawing.Color.Transparent;
			this.label7.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.label7.Font = new global::System.Drawing.Font("Segoe UI Emoji", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.Color.Black;
			this.label7.Location = new global::System.Drawing.Point(584, 535);
			this.label7.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(336, 35);
			this.label7.TabIndex = 42;
			this.label7.Text = "알노코인 공식 카페 바로가기";
			this.label7.Click += new global::System.EventHandler(this.label7_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(13f, 24f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(1126, 687);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.pictureBox3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.ProcessCountBox);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.TotalHashRateLabel);
			base.Controls.Add(this.WeightLabel);
			base.Controls.Add(this.MiningLevelLabel);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.WalletTextBox);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(6);
			base.Name = "Minner";
			this.Text = "Minner";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Minner_FormClosed);
			base.Load += new global::System.EventHandler(this.Minner_Load);
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Minner_MouseDown);
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Minner_MouseMove);
			base.Resize += new global::System.EventHandler(this.Minner_Resize);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000026 RID: 38
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.TextBox WalletTextBox;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Label MiningLevelLabel;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Label WeightLabel;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Label TotalHashRateLabel;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.ComboBox ProcessCountBox;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.NotifyIcon notifyIcon1;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Label label11;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Label label12;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Label label7;
	}
}
