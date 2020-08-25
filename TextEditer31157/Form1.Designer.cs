﻿namespace TextEditer31157 {
	partial class Form1 {
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
			this.ofdFileOpen = new System.Windows.Forms.OpenFileDialog();
			this.sfdFileSave = new System.Windows.Forms.SaveFileDialog();
			this.rtTextArea = new System.Windows.Forms.RichTextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NamedSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RedoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.ColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.文字コードToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cdColorDialog = new System.Windows.Forms.ColorDialog();
			this.fdFontDialog = new System.Windows.Forms.FontDialog();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ofdFileOpen
			// 
			this.ofdFileOpen.FileName = "openFileDialog1";
			// 
			// rtTextArea
			// 
			this.rtTextArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtTextArea.EnableAutoDragDrop = true;
			this.rtTextArea.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.rtTextArea.Location = new System.Drawing.Point(0, 24);
			this.rtTextArea.Name = "rtTextArea";
			this.rtTextArea.Size = new System.Drawing.Size(1189, 668);
			this.rtTextArea.TabIndex = 0;
			this.rtTextArea.Text = "";
			this.rtTextArea.TextChanged += new System.EventHandler(this.rtTextArea_TextChanged);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.文字コードToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1189, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// FileToolStripMenuItem
			// 
			this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.NamedSaveToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitToolStripMenuItem});
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			this.FileToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.FileToolStripMenuItem.Text = "ファイル(F)";
			// 
			// NewToolStripMenuItem
			// 
			this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
			this.NewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.NewToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
			this.NewToolStripMenuItem.Text = "新規作成(&N)";
			this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
			// 
			// OpenToolStripMenuItem
			// 
			this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
			this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.OpenToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
			this.OpenToolStripMenuItem.Text = "開く(&O)...";
			this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
			// 
			// SaveToolStripMenuItem
			// 
			this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
			this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.SaveToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
			this.SaveToolStripMenuItem.Text = "保存(&S)";
			this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
			// 
			// NamedSaveToolStripMenuItem
			// 
			this.NamedSaveToolStripMenuItem.Name = "NamedSaveToolStripMenuItem";
			this.NamedSaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.NamedSaveToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
			this.NamedSaveToolStripMenuItem.Text = "名前を付けて保存(&A)...";
			this.NamedSaveToolStripMenuItem.Click += new System.EventHandler(this.NamedSaveToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(254, 6);
			// 
			// ExitToolStripMenuItem
			// 
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
			this.ExitToolStripMenuItem.Text = "終了(&X)";
			this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// EditToolStripMenuItem
			// 
			this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoToolStripMenuItem,
            this.RedoToolStripMenuItem,
            this.toolStripSeparator2,
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.toolStripSeparator3,
            this.ColorToolStripMenuItem,
            this.FontToolStripMenuItem});
			this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
			this.EditToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.EditToolStripMenuItem.Text = "編集(E)";
			// 
			// UndoToolStripMenuItem
			// 
			this.UndoToolStripMenuItem.Enabled = false;
			this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
			this.UndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.UndoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.UndoToolStripMenuItem.Text = "元に戻す(&U)";
			this.UndoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
			// 
			// RedoToolStripMenuItem
			// 
			this.RedoToolStripMenuItem.Enabled = false;
			this.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem";
			this.RedoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.RedoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.RedoToolStripMenuItem.Text = "やり直し(&R)";
			this.RedoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// CutToolStripMenuItem
			// 
			this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
			this.CutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.CutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.CutToolStripMenuItem.Text = "切り取り(&T)";
			this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
			// 
			// CopyToolStripMenuItem
			// 
			this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
			this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.CopyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.CopyToolStripMenuItem.Text = "コピー(&C)";
			this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
			// 
			// PasteToolStripMenuItem
			// 
			this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
			this.PasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.PasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.PasteToolStripMenuItem.Text = "貼り付け(&P)";
			this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
			// 
			// DeleteToolStripMenuItem
			// 
			this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
			this.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.DeleteToolStripMenuItem.Text = "削除(&D)";
			this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
			// 
			// ColorToolStripMenuItem
			// 
			this.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem";
			this.ColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.ColorToolStripMenuItem.Text = "色...";
			this.ColorToolStripMenuItem.Click += new System.EventHandler(this.ColorToolStripMenuItem_Click);
			// 
			// FontToolStripMenuItem
			// 
			this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
			this.FontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.FontToolStripMenuItem.Text = "フォント...";
			this.FontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
			// 
			// 文字コードToolStripMenuItem
			// 
			this.文字コードToolStripMenuItem.Name = "文字コードToolStripMenuItem";
			this.文字コードToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
			this.文字コードToolStripMenuItem.Text = "文字コード(C)";
			// 
			// ヘルプHToolStripMenuItem
			// 
			this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
			this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.ヘルプHToolStripMenuItem.Text = "ヘルプ(H)";
			// 
			// fdFontDialog
			// 
			this.fdFontDialog.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1189, 692);
			this.Controls.Add(this.rtTextArea);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "テキストエディタ";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog ofdFileOpen;
		private System.Windows.Forms.SaveFileDialog sfdFileSave;
		private System.Windows.Forms.RichTextBox rtTextArea;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 文字コードToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem NamedSaveToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RedoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem ColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
		private System.Windows.Forms.ColorDialog cdColorDialog;
		private System.Windows.Forms.FontDialog fdFontDialog;
	}
}

