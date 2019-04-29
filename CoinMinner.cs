using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using coinminner.Properties;
using Newtonsoft.Json.Linq;

namespace coinminner
{
	// Token: 0x02000002 RID: 2
	public partial class CoinMinner : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public CoinMinner()
		{
			this.InitializeComponent();
			ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback((object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true));
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020A8 File Offset: 0x000002A8
		private void Form1_Load(object sender, EventArgs e)
		{
			this.label7.Parent = this.pictureBox1;
			StringBuilder stringBuilder = new StringBuilder();
			string text = this.WalletTextBox.Text;
			stringBuilder.Append("miningWallet=" + text);
			byte[] bytes = Encoding.UTF8.GetBytes(stringBuilder.ToString());
			this.wReq = (HttpWebRequest)WebRequest.Create(new Uri(this.domain + "/api/versionCheck"));
			this.wReq.Method = "POST";
			this.wReq.ContentType = "application/x-www-form-urlencoded";
			this.wReq.ContentLength = (long)bytes.Length;
			this.PostDataStream = this.wReq.GetRequestStream();
			this.PostDataStream.Write(bytes, 0, bytes.Length);
			this.PostDataStream.Close();
			this.wResp = (HttpWebResponse)this.wReq.GetResponse();
			this.respPostStream = this.wResp.GetResponseStream();
			this.readerPost = new StreamReader(this.respPostStream, Encoding.Default);
			JObject jobject = JObject.Parse(this.readerPost.ReadToEnd());
			if (jobject["result"].ToString() == "True" && jobject["msg"]["programVersion"].ToString() != "1.2")
			{
				MessageBox.Show("프로그램이 업데이트 되었습니다. 새로운 버젼을 다운로드 해주세요.");
				Application.Exit();
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000221B File Offset: 0x0000041B
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			this.mousePoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002234 File Offset: 0x00000434
		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
			{
				base.Location = new Point(base.Left - (this.mousePoint.X - e.X), base.Top - (this.mousePoint.Y - e.Y));
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002291 File Offset: 0x00000491
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002294 File Offset: 0x00000494
		private void ConnectButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.WalletTextBox.Text.Length == 0)
				{
					this.errorLabel.Text = "마이닝 지갑 주소를 입력 해주세요.";
					this.WalletTextBox.Select();
				}
				else
				{
					StringBuilder stringBuilder = new StringBuilder();
					string text = this.WalletTextBox.Text;
					stringBuilder.Append("miningWallet=" + text);
					byte[] bytes = Encoding.UTF8.GetBytes(stringBuilder.ToString());
					this.wReq = (HttpWebRequest)WebRequest.Create(new Uri(this.domain + "/api/syncCoin"));
					this.wReq.Method = "POST";
					this.wReq.ContentType = "application/x-www-form-urlencoded";
					this.wReq.ContentLength = (long)bytes.Length;
					this.PostDataStream = this.wReq.GetRequestStream();
					this.PostDataStream.Write(bytes, 0, bytes.Length);
					this.PostDataStream.Close();
					this.wResp = (HttpWebResponse)this.wReq.GetResponse();
					this.respPostStream = this.wResp.GetResponseStream();
					this.readerPost = new StreamReader(this.respPostStream, Encoding.Default);
					string text2 = this.readerPost.ReadToEnd();
					if (JObject.Parse(text2)["result"].ToString() == "True")
					{
						Control control = new Minner(text, text2);
						base.Hide();
						control.Show();
					}
					else
					{
						this.errorLabel.Text = "유효하지 않은 마이닝 지갑 입니다.";
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("서버 연결에 실패 하였습니다. 재시도 해주세요");
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002444 File Offset: 0x00000644
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002446 File Offset: 0x00000646
		private void errorLabel_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002448 File Offset: 0x00000648
		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			this.mousePoint = new Point(e.X, e.Y);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002464 File Offset: 0x00000664
		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
			{
				base.Location = new Point(base.Left - (this.mousePoint.X - e.X), base.Top - (this.mousePoint.Y - e.Y));
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000024C1 File Offset: 0x000006C1
		private void label6_Click(object sender, EventArgs e)
		{
			Process.Start(this.domain + "/wallet");
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000024D9 File Offset: 0x000006D9
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000024E1 File Offset: 0x000006E1
		private void label7_Click(object sender, EventArgs e)
		{
			Process.Start(this.domain);
		}

		// Token: 0x04000001 RID: 1
		private string domain = "https://rnoapi.com";

		// Token: 0x04000002 RID: 2
		private Point mousePoint;

		// Token: 0x04000003 RID: 3
		private HttpWebRequest wReq;

		// Token: 0x04000004 RID: 4
		private Stream PostDataStream;

		// Token: 0x04000005 RID: 5
		private Stream respPostStream;

		// Token: 0x04000006 RID: 6
		private StreamReader readerPost;

		// Token: 0x04000007 RID: 7
		private HttpWebResponse wResp;
	}
}
