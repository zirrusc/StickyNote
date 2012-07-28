namespace StickyNote
{
	partial class Main
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbAdd = new System.Windows.Forms.ToolStripButton();
			this.tsbDelete = new System.Windows.Forms.ToolStripButton();
			this.tsbCopy = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbExit = new System.Windows.Forms.ToolStripButton();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.新しい付箋AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.バージョン情報BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.アプリを終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.付箋リストLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.toolStrip1.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbDelete,
            this.tsbCopy,
            this.toolStripSeparator2,
            this.tsbRefresh,
            this.toolStripSeparator1,
            this.tsbExit});
			this.toolStrip1.Location = new System.Drawing.Point(3, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(139, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbAdd
			// 
			this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbAdd.Image = global::StickyNote.Properties.Resources.Add;
			this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAdd.Name = "tsbAdd";
			this.tsbAdd.Size = new System.Drawing.Size(23, 22);
			this.tsbAdd.Text = "新しい付箋(Ctrl + N)";
			this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
			// 
			// tsbDelete
			// 
			this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
			this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbDelete.Name = "tsbDelete";
			this.tsbDelete.Size = new System.Drawing.Size(23, 22);
			this.tsbDelete.Text = "付箋の削除(Ctrl + D)";
			this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
			// 
			// tsbCopy
			// 
			this.tsbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbCopy.Image = global::StickyNote.Properties.Resources.Copy;
			this.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbCopy.Name = "tsbCopy";
			this.tsbCopy.Size = new System.Drawing.Size(23, 22);
			this.tsbCopy.Text = "クリップボードにコピー(Ctrl + C)";
			this.tsbCopy.Click += new System.EventHandler(this.tsbCopy_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbRefresh
			// 
			this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbRefresh.Image = global::StickyNote.Properties.Resources.Refresh;
			this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbRefresh.Name = "tsbRefresh";
			this.tsbRefresh.Size = new System.Drawing.Size(23, 22);
			this.tsbRefresh.Text = "最新の状態に更新(F5)";
			this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbExit
			// 
			this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbExit.Image = global::StickyNote.Properties.Resources.exit;
			this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbExit.Name = "tsbExit";
			this.tsbExit.Size = new System.Drawing.Size(23, 22);
			this.tsbExit.Text = "アプリの終了(Ctrl + Q)";
			this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.listBox1);
			this.toolStripContainer1.ContentPanel.Padding = new System.Windows.Forms.Padding(3);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(284, 237);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(284, 262);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
			// 
			// listBox1
			// 
			this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 18;
			this.listBox1.Location = new System.Drawing.Point(3, 3);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(278, 231);
			this.listBox1.TabIndex = 0;
			this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
			// 
			// 新しい付箋AToolStripMenuItem
			// 
			this.新しい付箋AToolStripMenuItem.Name = "新しい付箋AToolStripMenuItem";
			this.新しい付箋AToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.新しい付箋AToolStripMenuItem.Text = "新しい付箋(&A)";
			this.新しい付箋AToolStripMenuItem.Click += new System.EventHandler(this.新しい付箋AToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 6);
			// 
			// バージョン情報BToolStripMenuItem
			// 
			this.バージョン情報BToolStripMenuItem.Name = "バージョン情報BToolStripMenuItem";
			this.バージョン情報BToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.バージョン情報BToolStripMenuItem.Text = "バージョン情報(&B)";
			this.バージョン情報BToolStripMenuItem.Click += new System.EventHandler(this.バージョン情報BToolStripMenuItem_Click);
			// 
			// アプリを終了XToolStripMenuItem
			// 
			this.アプリを終了XToolStripMenuItem.Name = "アプリを終了XToolStripMenuItem";
			this.アプリを終了XToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.アプリを終了XToolStripMenuItem.Text = "アプリを終了(&X)";
			this.アプリを終了XToolStripMenuItem.Click += new System.EventHandler(this.アプリを終了XToolStripMenuItem_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新しい付箋AToolStripMenuItem,
            this.付箋リストLToolStripMenuItem,
            this.toolStripMenuItem1,
            this.バージョン情報BToolStripMenuItem,
            this.アプリを終了XToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(179, 98);
			// 
			// 付箋リストLToolStripMenuItem
			// 
			this.付箋リストLToolStripMenuItem.Name = "付箋リストLToolStripMenuItem";
			this.付箋リストLToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.付箋リストLToolStripMenuItem.Text = "付箋リスト(&L)";
			this.付箋リストLToolStripMenuItem.Click += new System.EventHandler(this.付箋リストLToolStripMenuItem_Click);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "付箋";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
			// 
			// timer1
			// 
			this.timer1.Interval = 5000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Main
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.toolStripContainer1);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Name = "Main";
			this.ShowInTaskbar = false;
			this.Text = "付箋リスト";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.ClientSizeChanged += new System.EventHandler(this.Main_ClientSizeChanged);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripButton tsbAdd;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbDelete;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStripMenuItem 新しい付箋AToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem バージョン情報BToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem アプリを終了XToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		public System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ToolStripMenuItem 付箋リストLToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsbExit;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripButton tsbCopy;
		private System.Windows.Forms.ToolStripButton tsbRefresh;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ListBox listBox1;
	}
}

