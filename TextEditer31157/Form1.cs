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
		private bool Changed = false;
		
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			//ロード
			initTextEditer();
			
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e) {
			//終了
			ExitApplication(sender,e);
		}

		private void ExitApplication(object sender, EventArgs e) {
			//終了判定メソッド
			if (rtTextArea.Text != "") {
				if (Changed) {
					DialogResult dr = MessageBox.Show
						(Text + "は更新されています。保存しますか?",
						Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					Changed = false;
					if (dr == DialogResult.Yes) {
						SaveToolStripMenuItem_Click(sender, e);
					}
					else {
						Application.Exit();
					}
				}
				else {
					Application.Exit();
				}
			}
			else{
				Application.Exit();
			}
		}

		private void NamedSaveToolStripMenuItem_Click(object sender, EventArgs e) {
			//名前を付けて保存
			sfdFileSave.Filter = "テキスト文書 (.txt)|*.txt|すべてのファイル (*.*)|*.*";
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
				initChanged();
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
					initChanged();
				}
			}
		}

		private void NewToolStripMenuItem_Click(object sender, EventArgs e) {
			//新規作成
			if (rtTextArea.Text != "") {
				if (Changed) {
					DialogResult dr = MessageBox.Show
						(Text + "は更新されています。保存しますか?",
						Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (dr == DialogResult.Yes) {
						SaveToolStripMenuItem_Click(sender, e);
					}
					else {
						initTextEditer();
					}
				}
				else {
					initTextEditer();
				}
			}
			else {
				initTextEditer();
			}
		}

		private void SaveJudge() {
			Changed = true;
		}
		private void initTextEditer() {
			//初期化メソッド
			rtTextArea.Clear();
			PasteJudge();
			DeleteJudge();
			fileName = "";
			Text = "無題 - テキストエディタ";
			initChanged();
		}

		private void initChanged() {
			Changed = false;
		}

		private void UndoToolStripMenuItem_Click(object sender, EventArgs e) {
			//元に戻す
			rtTextArea.Undo();
		}
		private void RedoToolStripMenuItem_Click(object sender, EventArgs e) {
			//やり直し
			rtTextArea.Redo();
		}

		private void rtTextArea_TextChanged(object sender, EventArgs e) {
			//やり直し・元に戻す・削除・保存の判定
			RedoToolStripMenuItem.Enabled = rtTextArea.CanRedo ;
			UndoToolStripMenuItem.Enabled = rtTextArea.CanUndo ;
			DeleteJudge();
			SaveJudge();
		}

		private void CutToolStripMenuItem_Click(object sender, EventArgs e) {
			//切り取り
			rtTextArea.Cut();
			PasteJudge();
		}

		private void CopyToolStripMenuItem_Click(object sender, EventArgs e) {
			//コピー
			rtTextArea.Copy();
			PasteJudge();
		}

		private void PasteToolStripMenuItem_Click(object sender, EventArgs e) {
			//貼り付け
			rtTextArea.Paste();
		}

		private void PasteJudge() {
			//貼り付け判定
			PasteToolStripMenuItem.Enabled = Clipboard.GetDataObject().GetDataPresent(DataFormats.Rtf);
		}

		private void DeleteJudge() {
			//削除判定
			DeleteToolStripMenuItem.Enabled = rtTextArea.Text.Length > 0;
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

		private void rtTextArea_SelectionChanged(object sender, EventArgs e) {
			//切り取り・コピー判定
			CutToolStripMenuItem.Enabled = rtTextArea.SelectedText.Length > 0 ;
			CopyToolStripMenuItem.Enabled = rtTextArea.SelectedText.Length > 0 ;
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			ExitApplication(sender, e);
		}
	}
}
