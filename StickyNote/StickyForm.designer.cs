namespace StickyNote
{
	partial class StickyForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StickyForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbAdd = new System.Windows.Forms.ToolStripButton();
			this.tsbClear = new System.Windows.Forms.ToolStripButton();
			this.tsbDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbList = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbExit = new System.Windows.Forms.ToolStripButton();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.toolStrip1.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbClear,
            this.tsbDelete,
            this.toolStripSeparator2,
            this.tsbList,
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
			// tsbClear
			// 
			this.tsbClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbClear.Image = global::StickyNote.Properties.Resources.Clear;
			this.tsbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbClear.Name = "tsbClear";
			this.tsbClear.Size = new System.Drawing.Size(23, 22);
			this.tsbClear.Text = "クリア(Ctrl + E)";
			this.tsbClear.Click += new System.EventHandler(this.tsbClear_Click);
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
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbList
			// 
			this.tsbList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbList.Image = global::StickyNote.Properties.Resources.bulleted_list_options;
			this.tsbList.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbList.Name = "tsbList";
			this.tsbList.Size = new System.Drawing.Size(23, 22);
			this.tsbList.Text = "付箋リスト(Ctrl + L)";
			this.tsbList.Click += new System.EventHandler(this.tsbList_Click);
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
			this.tsbExit.Text = "保存してアプリを終了(Ctrl + Q)";
			this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.textBox1);
			this.toolStripContainer1.ContentPanel.Padding = new System.Windows.Forms.Padding(2);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(204, 117);
			this.toolStripContainer1.ContentPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.toolStripContainer1.ContentPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(204, 142);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
			this.toolStripContainer1.TopToolStripPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.toolStripContainer1.TopToolStripPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.toolStripContainer1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.toolStripContainer1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			// 
			// textBox1
			// 
			this.textBox1.AcceptsReturn = true;
			this.textBox1.AcceptsTab = true;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(2, 2);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(200, 113);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// Sticky
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(204, 142);
			this.Controls.Add(this.toolStripContainer1);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Name = "Sticky";
			this.ShowInTaskbar = false;
			this.Text = "Sticky";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ContentPanel.PerformLayout();
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStripButton tsbAdd;
		private System.Windows.Forms.ToolStripButton tsbDelete;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ToolStripButton tsbExit;
		private System.Windows.Forms.ToolStripButton tsbClear;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsbList;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
	}
}

