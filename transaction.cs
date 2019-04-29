using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace coinminner
{
	// Token: 0x02000005 RID: 5
	public partial class transaction : Form
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00004E6B File Offset: 0x0000306B
		public transaction()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004E79 File Offset: 0x00003079
		private void transaction_FormClosing(object sender, FormClosingEventArgs e)
		{
			base.Hide();
			e.Cancel = true;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004E88 File Offset: 0x00003088
		public void setLog(string log)
		{
			this.LogBox.Text = log;
			this.LogBox.SelectionStart = this.LogBox.Text.Length;
			this.LogBox.ScrollToCaret();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004EBC File Offset: 0x000030BC
		private void LogBox_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004EBE File Offset: 0x000030BE
		private void transaction_Load(object sender, EventArgs e)
		{
			base.MaximizeBox = false;
		}
	}
}
