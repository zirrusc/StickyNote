using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Collections;
using System.IO;

namespace StickyNote
{
	public partial class Main : Form
	{
		//Sticky s;
		//ArrayList arraySticky = new ArrayList();
		public const string crlf = "\r\n";
		//public Hashtable hashSticky = new Hashtable();
		//public Hashtable hashForm = new Hashtable();
		//private Hashtable hashList = new Hashtable();
		//int iSticky = 0;
		const string emptyText = "<未記入>";
		const string beforeReplace = "\r\n";
		const string afterReplace = "$crlf;";
		const string savePath = "\\note";
		public Main()
		{
			InitializeComponent();
			if (Read() == false)
			{
				AddSticky();
			}
			timer1.Start();
		}

		private bool Read()
		{
			bool result = false;
			string currentDir = Environment.CurrentDirectory;
			int iHash = 0;
			string currentText;

			try
			{
				// ファイルのパスを通す
				if (File.Exists(currentDir + savePath) == false)
				{
					using (System.IO.FileStream hStream = System.IO.File.Create(currentDir + savePath))
					{
						// 作成時に返される FileStream を利用して閉じる
						if (hStream != null)
						{
							hStream.Close();
						}
					}
				}
				using (StreamReader sr = new StreamReader(currentDir + savePath))
				{
					while (sr.Peek() >= 0)
					{
						currentText = sr.ReadLine();
						currentText = currentText.Replace(afterReplace, beforeReplace);
						hashSticky.Add(iHash, currentText);
						iHash++;
					}
				}
			}
			catch (Exception ex)
			{
				exMessage(ref ex);
			}

			for (int i = 0; i < hashSticky.Count; i++)
			{
				//s = new Sticky(this, i, hashSticky[i].ToString());
				//s.Show();
				hashForm.Add(i, new StickyForm(this, i, hashSticky[i].ToString()));
				((Form)hashForm[i]).Show();
				result = true;
			}
			return result;
		}

		public void AddSticky()
		{
			//s = new Sticky(this, hashSticky.Count);
			//s.Show();
			hashForm.Add(hashForm.Count, new StickyForm(this, hashSticky.Count));
			((Form)hashForm[hashForm.Count - 1]).Show();
			//arraySticky.Add(s);
			hashSticky.Add(hashSticky.Count, null);
			//iSticky++;
			List(false);
		}

		public void DeleteSticky(int count)
		{
			Form f = ActiveForm;
			if (count == -1)
			{
				return;
			}
			if (f == null)
			{
				SystemSounds.Asterisk.Play();
				return;
			}

			if (f == this)
			{
				((Form)hashForm[count]).Close();

				int zure;
				for (int i = 0; i < hashForm.Count; i++)
				{
					if (hashForm[i] == null)
					{
						zure++;
					}
				}
				//((Form)hashForm[hashList[listBox1.SelectedIndex]]).Close();
				hashList.Remove(listBox1.SelectedIndex);
			}
			else
			{
				f.Close();
			}

			hashForm.Remove(count);
			hashSticky.Remove(count);

			if (this.WindowState != FormWindowState.Minimized)
			{
				List(false);
			}
		}

		public void exitApp(int p)
		{
			notifyIcon1.Dispose();
			//Environment.Exit(p);
			Application.Exit();
		}

		public void List(bool forceActivate)
		{
			if (forceActivate == true)
			{
				if (this.WindowState == FormWindowState.Minimized ||
					this.Visible == true)
				{
					this.Visible = true;
					this.WindowState = FormWindowState.Normal;
				}
				this.Activate();
			}
			listBox1.Items.Clear();
			hashList.Clear();
			for (int i = 0; i < hashSticky.Count; i++)
			{
				if (hashSticky[i] == null || (string)hashSticky[i] == "")
				{
					listBox1.Items.Add(emptyText);
				}
				else
				{
					listBox1.Items.Add(hashSticky[i]);
				}
				hashList.Add(listBox1.Items.Count - 1, i);
			}
		}

		private void notifyIcon1_DoubleClick(object sender, EventArgs e)
		{
			//foreach (var item in hashForm)
			//{
			//    ((Form)item).Activate();
			//}
			for (int i = 0; i < hashForm.Count; i++)
			{
				((Form)hashForm[i]).Activate();
			}
			//this.Activate();
		}

		#region ToolStrip

		private void tsbAdd_Click(object sender, EventArgs e)
		{
			AddSticky();
		}

		private void tsbCopy_Click(object sender, EventArgs e)
		{
			Copy();
		}

		private void Copy()
		{
			string text;
			if (listBox1.SelectedItem != null)
			{
				text = (string)listBox1.SelectedItem;
				if (text != emptyText)
				{
					Clipboard.SetText(text);		
				}
			}
		}


		private void tsbDelete_Click(object sender, EventArgs e)
		{
			//if (listBox1.SelectedIndex != null)
			//{
				DeleteSticky(listBox1.SelectedIndex);
			//}
		}

		private void tsbRefresh_Click(object sender, EventArgs e)
		{
			int index = listBox1.SelectedIndex;
			List(true);
			listBox1.SelectedIndex = index;
		}

		private void 付箋リストLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			List(true);
		}

		private void 新しい付箋AToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddSticky();
		}

		private void バージョン情報BToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutBox1 about = new AboutBox1();
			about.Show();
		}

		private void アプリを終了XToolStripMenuItem_Click(object sender, EventArgs e)
		{
			exitApp(0);
		}

		private void tsbExit_Click(object sender, EventArgs e)
		{
			exitApp(0);
		}

		#endregion // toolstrip

		// ショートカットキーを割り当て
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			return ProcessCmdKey2(ref msg, keyData);
		}

		internal bool ProcessCmdKey2(ref Message msg, Keys keyData)
		{
			int data = (int)keyData;
			int control = (int)Keys.Control;

			// ctrl + n
			if (data == control + (int)Keys.N)
			{
				AddSticky();
			}
			else if (data == control + (int)Keys.D)
			{
				if (listBox1.SelectedIndex != -1)
				{
					DeleteSticky(listBox1.SelectedIndex);
				}
			}
			else if (data == control + (int)Keys.Q)
			{
				exitApp(0);
			}
			else if (data == (int)Keys.F5)
			{
				List(true);
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (this.WindowState != FormWindowState.Minimized)
			{
				int index = listBox1.SelectedIndex;
				List(false);
				listBox1.SelectedIndex = index;
			}
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			Save();
		}

		private void Save()
		{
			string currentDir = Environment.CurrentDirectory;
			string currentHash;
			try
			{
				using (StreamWriter sr = new StreamWriter(currentDir + savePath, false))
				{
					for (int i = 0; i < hashSticky.Count; i++)
					{
						currentHash = (string)hashSticky[i];
						if (currentHash != null)
						{
							currentHash = currentHash.Replace(beforeReplace, afterReplace);
							sr.WriteLine(currentHash);
						}
					}
				}
			}
			catch (Exception ex)
			{
				exMessage(ref ex);
			}
		}

		private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			//if (listBox1.SelectedIndex != -1)
			//{
			//    ((Form)hashForm[listBox1.SelectedIndex]).Activate();
			//}
			int index = listBox1.SelectedIndex;
			if (index != -1)
			{
				List(false);
				((Form)hashForm[hashList[index]]).Activate();
				//((Form)hashForm[listBox1.SelectedIndex]).Activate();
			}
		}

		private void Main_ClientSizeChanged(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.Hide();
			}
		}

		public void exMessage(ref Exception ex)
		{
			string targetSite;
			if (ex.TargetSite == null)
			{
				targetSite = "null";
			}
			else
			{
				targetSite = ex.TargetSite.Name;
			}
			string message = ex.Message;
			string innerMessage;
			if (ex.InnerException == null)
			{
				innerMessage = "null";
			}
			else
			{
				innerMessage = ex.InnerException.Message;
			}

			MessageBox.Show(
				"*TargetSite : " + targetSite + crlf + crlf +
				"*Message : " + message + crlf + crlf +
				"*InnerException : " + innerMessage,
				"エラー - 付箋",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error);
		}

	}
}
