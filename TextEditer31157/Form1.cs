using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditer31157 {
	public partial class Form1 : Form {
		private string fileName = "";
		
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			initTextEditer();
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e) {
			//終了
			Application.Exit();
		}

		private void NamedSaveToolStripMenuItem_Click(object sender, EventArgs e) {
			//名前を付けて保存
			if (sfdFileSave.ShowDialog() == DialogResult.OK) {
				FileSave(sfdFileSave.FileName);
			}
		}

		private void SaveToolStripMenuItem_Click(object sender, EventArgs e) {
			//保存
			if (fileName != "") {
				FileSave(fileName);
			}
			else {
				NamedSaveToolStripMenuItem_Click(sender, e);
			}
		}

		private void FileSave(String fileName) {
			//保存メソッド
			using (StreamWriter sw = new StreamWriter
									(fileName, false, Encoding.GetEncoding("utf-8"))) {
				sw.WriteLine(rtTextArea.Text);
				Text = fileName + " - テキストエディタ";
			}
		}

		private void OpenToolStripMenuItem_Click(object sender, EventArgs e) {
			//開く
			if (ofdFileOpen.ShowDialog() == DialogResult.OK) {
				using (StreamReader sr = new StreamReader
					(ofdFileOpen.FileName, Encoding.GetEncoding("utf-8"), false)) {
					rtTextArea.Text = sr.ReadToEnd();
					fileName = ofdFileOpen.FileName;
					Text = fileName + " - テキストエディタ";
				}
			}
		}

		private void NewToolStripMenuItem_Click(object sender, EventArgs e) {
			//新規作成
			initTextEditer();
		}

		private void initTextEditer() {
			//初期化メソッド
			rtTextArea.Clear();
			fileName = "";
			Text = "無題 - テキストエディタ";
		}

		private void UndoToolStripMenuItem_Click(object sender, EventArgs e) {
			//元に戻す
			if (rtTextArea.CanUndo == true) {
				rtTextArea.Undo();
				RedoToolStripMenuItem.Enabled = true;
			}
			else {
				UndoToolStripMenuItem.Enabled = false;
			}
		}
		private void RedoToolStripMenuItem_Click(object sender, EventArgs e) {
			//やり直し
			if (rtTextArea.CanRedo == true) {			
				rtTextArea.Redo();
				UndoToolStripMenuItem.Enabled = true;
			}
			else {
				RedoToolStripMenuItem.Enabled = false;
			}
		}

		private void rtTextArea_TextChanged(object sender, EventArgs e) {
			//やり直し・元に戻すの判定
			if (rtTextArea.CanRedo == true) {
				RedoToolStripMenuItem.Enabled = true;
			}
			else {
				RedoToolStripMenuItem.Enabled = false;
			}
			if (rtTextArea.CanUndo == true) {
				UndoToolStripMenuItem.Enabled = true;
			}
			else {
				UndoToolStripMenuItem.Enabled = false;
			}
		}

		private void CutToolStripMenuItem_Click(object sender, EventArgs e) {
			//切り取り
			rtTextArea.Cut();
		}

		private void CopyToolStripMenuItem_Click(object sender, EventArgs e) {
			//コピー
			rtTextArea.Copy();
		}

		private void PasteToolStripMenuItem_Click(object sender, EventArgs e) {
			//貼り付け
			rtTextArea.Paste();
		}

		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e) {
			//削除
			int selectPos = rtTextArea.SelectionStart;
			try {
				rtTextArea.Text = rtTextArea.Text.Remove(selectPos, 1);
				rtTextArea.SelectionStart = selectPos;
			}
			catch (ArgumentOutOfRangeException) {
			}
		}

		private void ColorToolStripMenuItem_Click(object sender, EventArgs e) {
			//色
			if (cdColorDialog.ShowDialog() == DialogResult.OK) {
				if (rtTextArea.SelectionLength != 0) {
					rtTextArea.SelectionColor = cdColorDialog.Color;
				}
				else {
					rtTextArea.ForeColor = cdColorDialog.Color;
				}
			}
		}

		private void FontToolStripMenuItem_Click(object sender, EventArgs e) {
			//フォント
			if (fdFontDialog.ShowDialog() == DialogResult.OK) {
				if (rtTextArea.SelectionLength != 0) {
					rtTextArea.SelectionFont = fdFontDialog.Font;
				}
				else {
					rtTextArea.Font = fdFontDialog.Font;
				}

			}
		}


	}
}
