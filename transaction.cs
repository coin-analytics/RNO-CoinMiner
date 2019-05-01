using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace coinminner
{
	// Token: 0x02000005 RID: 5
	public partial class transaction : Form
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00004DB3 File Offset: 0x00002FB3
		public transaction()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004DC1 File Offset: 0x00002FC1
		private void transaction_FormClosing(object sender, FormClosingEventArgs e)
		{
			base.Hide();
			e.Cancel = true;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004DD0 File Offset: 0x00002FD0
		public void setLog(string log)
		{
			this.LogBox.Text = log;
			this.LogBox.SelectionStart = this.LogBox.Text.Length;
			this.LogBox.ScrollToCaret();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004E04 File Offset: 0x00003004
		private void LogBox_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004E06 File Offset: 0x00003006
		private void transaction_Load(object sender, EventArgs e)
		{
			base.MaximizeBox = false;
		}
	}
}
