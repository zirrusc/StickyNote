using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StickyNote.Properties;
using System.Reflection;
using System.IO;
using System.Diagnostics;

namespace StickyNote
{
	public partial class Sticky : Form
	{
		private Main main;
		private Point mousePoint;
		private int formCount;

		//private static string _text;
		//public static string text
		//{
		//    private set
		//    {
		//        _text = value;
		//    }
		//    get
		//    {
		//        return _text;
		//    }
		//}

		public Sticky(Main m, int count, string text = "")
		{
			InitializeComponent();

			main = m;
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
		//protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		//{
		//    return ProcessCmdKey2(ref msg, keyData);
		//}

		//internal bool ProcessCmdKey2(ref Message msg, Keys keyData)
		//{
		//    int data = (int)keyData;
		//    int control = (int)Keys.Control;

		//    // ctrl + n
		//    if (data == control + (int)Keys.N)
		//    {
		//        main.AddSticky();
		//    }
		//    else if (data == control + (int)Keys.D)
		//    {
		//        main.DeleteSticky(formCount);
		//    }
		//    else if (data == control + (int)Keys.Q)
		//    {
		//        exitApp(0);
		//    }
		//    else if (data == control + (int)Keys.L)
		//    {
		//        textBox1.Clear();
		//    }
		//    return base.ProcessCmdKey(ref msg, keyData);
		//}

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

		//private void exitApp(int result)
		//{
		//    main.notifyIcon1.Dispose();
		//    Environment.Exit(result);
		//}

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

		//private void Sticky_Activated(object sender, EventArgs e)
		//{
			//main.notifyIcon1.Visible = true;
		//}

		//private void Sticky_Deactivate(object sender, EventArgs e)
		//{
			//Form f = ActiveForm;
			//if (f != null)
			//{
			//    main.notifyIcon1.Visible = false;
			//}
		//}


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
			//text = textBox1.Text;
			main.hashSticky[formCount] = textBox1.Text;
		}

		private void tsbList_Click(object sender, EventArgs e)
		{
			main.List(true);
		}
	}
}
