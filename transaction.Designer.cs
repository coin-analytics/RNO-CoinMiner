namespace coinminner
{
	// Token: 0x02000005 RID: 5
	public partial class transaction : global::System.Windows.Forms.Form
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00004EC7 File Offset: 0x000030C7
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004EE8 File Offset: 0x000030E8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::coinminner.transaction));
			this.LogBox = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.LogBox.BackColor = global::System.Drawing.Color.Black;
			this.LogBox.Font = new global::System.Drawing.Font("Yu Gothic UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LogBox.ForeColor = global::System.Drawing.Color.White;
			this.LogBox.Location = new global::System.Drawing.Point(0, 1);
			this.LogBox.Multiline = true;
			this.LogBox.Name = "LogBox";
			this.LogBox.ReadOnly = true;
			this.LogBox.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.LogBox.Size = new global::System.Drawing.Size(1138, 711);
			this.LogBox.TabIndex = 27;
			this.LogBox.TextChanged += new global::System.EventHandler(this.LogBox_TextChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(13f, 24f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1140, 712);
			base.Controls.Add(this.LogBox);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "transaction";
			this.Text = "mining log";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.transaction_FormClosing);
			base.Load += new global::System.EventHandler(this.transaction_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000040 RID: 64
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.TextBox LogBox;
	}
}
