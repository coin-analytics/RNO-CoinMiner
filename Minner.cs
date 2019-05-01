using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using coinminner.Properties;
using Newtonsoft.Json.Linq;

namespace coinminner
{
	// Token: 0x02000003 RID: 3
	public partial class Minner : Form
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00003108 File Offset: 0x00001308
		public Minner(string miningWallet, string initData)
		{
			this.InitializeComponent();
			ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback((object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true));
			this.WalletTextBox.Text = miningWallet;
			for (int i = 1; i <= this.cpuCount; i++)
			{
				this.ProcessCountBox.Items.Add(i);
			}
			this.ProcessCountBox.SelectedIndex = this.cpuCount - 1;
			this.setMinner();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000031C0 File Offset: 0x000013C0
		public void setMinner()
		{
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				string text = this.WalletTextBox.Text;
				stringBuilder.Append("miningWallet=" + text);
				byte[] bytes = Encoding.UTF8.GetBytes(stringBuilder.ToString());
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(this.domain + "/api/syncCoin"));
				httpWebRequest.Method = "POST";
				httpWebRequest.ContentType = "application/x-www-form-urlencoded";
				httpWebRequest.ContentLength = (long)bytes.Length;
				Stream requestStream = httpWebRequest.GetRequestStream();
				requestStream.Write(bytes, 0, bytes.Length);
				requestStream.Close();
				string json = new StreamReader(((HttpWebResponse)httpWebRequest.GetResponse()).GetResponseStream(), Encoding.Default).ReadToEnd();
				if (JObject.Parse(json)["result"].ToString() == "True")
				{
					this.walletInfo = JObject.Parse(json);
					this.TotalHashRateLabel.Text = this.walletInfo["msg"]["totalHashRate"].ToString();
					this.MiningLevelLabel.Text = this.walletInfo["msg"]["miningLevel"].ToString();
					this.WeightLabel.Text = this.walletInfo["msg"]["weight"].ToString();
					this.label10.Text = this.walletInfo["msg"]["hashRate"].ToString();
					this.nBits = int.Parse(this.walletInfo["msg"]["nBits"].ToString());
					this.hashText = this.walletInfo["msg"]["hashText"].ToString();
					this.nBitsStr = "";
					for (int i = 0; i < this.nBits; i++)
					{
						this.nBitsStr += "0";
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("서버 연결에 실패 하였습니다. 재시도 해주세요");
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003400 File Offset: 0x00001600
		private void Minner_MouseDown(object sender, MouseEventArgs e)
		{
			this.mousePoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000341C File Offset: 0x0000161C
		private void Minner_MouseMove(object sender, MouseEventArgs e)
		{
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
			{
				base.Location = new Point(base.Left - (this.mousePoint.X - e.X), base.Top - (this.mousePoint.Y - e.Y));
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003479 File Offset: 0x00001679
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003481 File Offset: 0x00001681
		private void Minner_Load(object sender, EventArgs e)
		{
			Control.CheckForIllegalCrossThreadCalls = false;
			this.label9.Parent = this.pictureBox1;
			this.label12.Parent = this.pictureBox1;
			this.tsForm = new transaction();
		}

		// Token: 0x06000016 RID: 22
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000017 RID: 23 RVA: 0x000034B8 File Offset: 0x000016B8
		public string SHA256Hash(string data)
		{
			byte[] array = new SHA256Managed().ComputeHash(Encoding.ASCII.GetBytes(data));
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in array)
			{
				stringBuilder.AppendFormat("{0:x2}", b);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000350B File Offset: 0x0000170B
		public void runC()
		{
			while (this.runcState == 1)
			{
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003518 File Offset: 0x00001718
		public void mining()
		{
			while (this.threadState == 1 && this.runMinner == 1)
			{
				try
				{
					int num = this.nonce;
					string value = this.nBitsStr;
					string text = this.hashText;
					string text2 = this.SHA256Hash(text + num);
					if (text2.StartsWith(value))
					{
						this.runMinner = 0;
						StringBuilder stringBuilder = new StringBuilder();
						string text3 = this.WalletTextBox.Text;
						stringBuilder.Append("miningWallet=" + text3);
						stringBuilder.Append("&createdHashString=" + text2);
						stringBuilder.Append("&nonce=" + num);
						stringBuilder.Append("&hashText=" + text);
						byte[] bytes = Encoding.UTF8.GetBytes(stringBuilder.ToString());
						HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(this.domain + "/api/minedCoin"));
						httpWebRequest.Method = "POST";
						httpWebRequest.ContentType = "application/x-www-form-urlencoded";
						httpWebRequest.ContentLength = (long)bytes.Length;
						Stream requestStream = httpWebRequest.GetRequestStream();
						requestStream.Write(bytes, 0, bytes.Length);
						requestStream.Close();
						JObject jobject = JObject.Parse(new StreamReader(((HttpWebResponse)httpWebRequest.GetResponse()).GetResponseStream(), Encoding.Default).ReadToEnd());
						JObject jobject2 = JObject.Parse(jobject["msg"].ToString());
						if (jobject["result"].ToString() == "True")
						{
							this.updateMinedCoin(jobject2["coins"].ToString());
							this.LogBoxStr = string.Concat(new string[]
							{
								this.LogBoxStr,
								DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss"),
								"\r\n",
								jobject2["hash"].ToString(),
								" ",
								jobject2["coins"].ToString(),
								"\r\n"
							});
							this.tsForm.setLog(this.LogBoxStr);
						}
						this.resetMinner();
						break;
					}
					this.nonce++;
				}
				catch (Exception)
				{
					this.runMinner = 1;
					this.resetMinner();
				}
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003780 File Offset: 0x00001980
		public void updateMinedCoin(string coins)
		{
			this.minedCoin += double.Parse(coins);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003798 File Offset: 0x00001998
		private void button1_Click(object sender, EventArgs e)
		{
			this.threadState = 1;
			this.runcState = 1;
			this.ProcessCountBox.Enabled = false;
			this.button1.Visible = false;
			this.button3.Visible = true;
			this.resetMinner();
			this.runMinner = 1;
			int num = 0;
			int num2 = int.Parse(this.ProcessCountBox.SelectedItem.ToString());
			if (num2 >= 2)
			{
				num = num2;
			}
			this.runThread = new Thread[num];
			for (int i = 0; i < num; i++)
			{
				this.runThread[i] = new Thread(new ThreadStart(this.runC));
				this.runThread[i].IsBackground = true;
				this.runThread[i].Start();
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003850 File Offset: 0x00001A50
		public void threadUp()
		{
			this.runMinner = 1;
			int num = int.Parse(this.ProcessCountBox.SelectedItem.ToString());
			this.syncThread = new Thread[num];
			this.runThread = new Thread[num];
			for (int i = 0; i < num; i++)
			{
				this.syncThread[i] = new Thread(new ThreadStart(this.mining));
				this.syncThread[i].IsBackground = true;
				this.syncThread[i].Start();
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000038D2 File Offset: 0x00001AD2
		public void resetMinner()
		{
			this.runMinner = 0;
			this.setMinner();
			this.threadUp();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000038E7 File Offset: 0x00001AE7
		private void notifyIcon1_DoubleClick(object sender, EventArgs e)
		{
			base.Visible = true;
			base.ShowIcon = true;
			this.notifyIcon1.Visible = false;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003903 File Offset: 0x00001B03
		private void button2_Click(object sender, EventArgs e)
		{
			base.Visible = false;
			base.ShowIcon = false;
			this.notifyIcon1.Visible = true;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000391F File Offset: 0x00001B1F
		private void Minner_Resize(object sender, EventArgs e)
		{
			if (base.WindowState == FormWindowState.Minimized)
			{
				base.Visible = false;
				base.ShowIcon = false;
				this.notifyIcon1.Visible = true;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003944 File Offset: 0x00001B44
		private void Minner_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.threadState = 0;
			Application.Exit();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003952 File Offset: 0x00001B52
		private void pictureBox3_Click_1(object sender, EventArgs e)
		{
			if (!this.tsForm.IsDisposed)
			{
				this.tsForm.Dispose();
			}
			Application.Exit();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003971 File Offset: 0x00001B71
		private void button3_Click_1(object sender, EventArgs e)
		{
			this.threadState = 0;
			this.runcState = 0;
			this.ProcessCountBox.Enabled = true;
			this.button1.Visible = true;
			this.button3.Visible = false;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000039A5 File Offset: 0x00001BA5
		private void label11_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000039A7 File Offset: 0x00001BA7
		private void label12_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000039A9 File Offset: 0x00001BA9
		private void label12_Click_1(object sender, EventArgs e)
		{
			this.tsForm.Show();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000039B6 File Offset: 0x00001BB6
		private void ProcessCountBox_KeyDown(object sender, KeyEventArgs e)
		{
			e.SuppressKeyPress = true;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000039BF File Offset: 0x00001BBF
		private void threaddd_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000039C1 File Offset: 0x00001BC1
		private void label7_Click(object sender, EventArgs e)
		{
			Process.Start("https://cafe.naver.com/RNOCOINFAMILY");
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000039CE File Offset: 0x00001BCE
		private void label9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000016 RID: 22
		private string domain = "http://rnoapi.com";

		// Token: 0x04000017 RID: 23
		private int cpuCount = Environment.ProcessorCount;

		// Token: 0x04000018 RID: 24
		private Point mousePoint;

		// Token: 0x04000019 RID: 25
		private int nBits;

		// Token: 0x0400001A RID: 26
		private string nBitsStr;

		// Token: 0x0400001B RID: 27
		private string hashText;

		// Token: 0x0400001C RID: 28
		private int nonce = 1;

		// Token: 0x0400001D RID: 29
		private int threadState;

		// Token: 0x0400001E RID: 30
		private int runMinner;

		// Token: 0x0400001F RID: 31
		private int runcState;

		// Token: 0x04000020 RID: 32
		private double minedCoin;

		// Token: 0x04000021 RID: 33
		private JObject walletInfo;

		// Token: 0x04000022 RID: 34
		private Thread[] syncThread;

		// Token: 0x04000023 RID: 35
		private Thread[] runThread;

		// Token: 0x04000024 RID: 36
		private transaction tsForm;

		// Token: 0x04000025 RID: 37
		private string LogBoxStr;

		// Token: 0x04000033 RID: 51
		private TextBox LogBox;
	}
}
