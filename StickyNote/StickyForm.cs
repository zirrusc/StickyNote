using System;
using System.Drawing;
using System.Windows.Forms;

namespace StickyNote
{
	public partial class StickyForm : Form
	{
		//private Main main;
		private Sticky sticky;
		private Point mousePoint;
		private int formCount;

		public StickyForm(Sticky s, int count, string text = "")
		{
			InitializeComponent();
			sticky = s;
			// main = m;
			formCount = count;

			// タイトルバーを非表示
			this.ControlBox = false;
			this.Text = "";

			textBox1.Text = text;

		}

		// フォームを移動する
		#region Move form

		private void FormMouseDown(MouseEventArgs e)
		{
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
			{
				mousePoint = new Point(e.X, e.Y);
			}
		}


		private void FormMouseMove(MouseEventArgs e)
		{
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
			{
				this.Left += e.X - mousePoint.X;
				this.Top += e.Y - mousePoint.Y;
			}
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			FormMouseDown(e);
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			FormMouseMove(e);
		}

		#endregion

		// ショートカットキーを割り当て
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			switch (keyData)
			{
				case Keys.A | Keys.Control:
					textBox1.SelectAll();
					return true;
				case Keys.Control | Keys.E:
					textBox1.Clear();
					return true;
				case Keys.Control | Keys.N:
					sticky.AddSticky();
					return true;
				case Keys.Control | Keys.D:
					sticky.DeleteSticky(formCount);
					return true;
				case Keys.Control | Keys.Q:
					sticky.exitApp(0);
					return true;
				case Keys.Control | Keys.L:
					sticky.ShowList(true);
					return true;
				default:
					break;
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}

		protected override bool ProcessDialogKey(Keys keyData)
		{
			switch (keyData)
			{
				case Keys.A | Keys.Control:
					textBox1.SelectAll();
					return true;
				case Keys.Control | Keys.E:
					textBox1.Clear();
					return true;
				case Keys.Control | Keys.N:
					main.AddSticky();
					return true;
				case Keys.Control | Keys.D:
					main.DeleteSticky(formCount);
					return true;
				case Keys.Control | Keys.Q:
					main.exitApp(0);
					return true;
				case Keys.Control | Keys.L:
					main.List(true);
					return true;
				default:
					break;
			}
			return base.ProcessDialogKey(keyData);
		}

		#region ToolStrip

		private void tsbAdd_Click(object sender, EventArgs e)
		{
			main.AddSticky();
		}

		private void tsbDelete_Click(object sender, EventArgs e)
		{
			main.DeleteSticky(formCount);
		}

		#endregion


		private void notifyIcon1_DoubleClick(object sender, EventArgs e)
		{
			this.Activate();
		}

		private void tsbExit_Click(object sender, EventArgs e)
		{
			main.exitApp(0);
		}

		private void tsbClear_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			main.hashSticky[formCount] = textBox1.Text;
		}

		private void tsbList_Click(object sender, EventArgs e)
		{
			main.List(true);
		}
	}
}
