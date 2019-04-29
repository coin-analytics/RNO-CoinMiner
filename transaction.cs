using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace coinminner
{
	// Token: 0x02000005 RID: 5
	public partial class transaction : Form
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00004DB7 File Offset: 0x00002FB7
		public transaction()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004DC5 File Offset: 0x00002FC5
		private void transaction_FormClosing(object sender, FormClosingEventArgs e)
		{
			base.Hide();
			e.Cancel = true;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004DD4 File Offset: 0x00002FD4
		public void setLog(string log)
		{
			this.LogBox.Text = log;
			this.LogBox.SelectionStart = this.LogBox.Text.Length;
			this.LogBox.ScrollToCaret();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004E08 File Offset: 0x00003008
		private void LogBox_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004E0A File Offset: 0x0000300A
		private void transaction_Load(object sender, EventArgs e)
		{
			base.MaximizeBox = false;
		}
	}
}
