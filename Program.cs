using System;
using System.Threading;
using System.Windows.Forms;

namespace coinminner
{
	// Token: 0x02000004 RID: 4
	internal static class Program
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00004E2C File Offset: 0x0000302C
		[STAThread]
		private static void Main()
		{
			bool flag;
			Mutex mutex = new Mutex(true, "MutexName", ref flag);
			if (flag)
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new CoinMinner());
				mutex.ReleaseMutex();
				return;
			}
			Application.Exit();
		}
	}
}
