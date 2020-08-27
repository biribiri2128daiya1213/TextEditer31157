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
			OpenExitJudge(sender, e, "Exit");
		}

		private void NamedSaveToolStripMenuItem_Click(object sender, EventArgs e) {
		//名前を付けて保存
		sfdFileSave.Filter = "リッチテキスト形式 (.rtf)|*.rtf|すべてのファイル (*.*)|*.*";
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
			rtTextArea.SaveFile(fileName, RichTextBoxStreamType.RichText);
			Text = fileName + " - テキストエディタ";
			initChanged();
		}

		private void OpenToolStripMenuItem_Click(object sender, EventArgs e) {
			//開く
			OpenExitJudge(sender, e, "Open");
		}

		private void FileOpen() {
			//開くメソッド
			if (ofdFileOpen.ShowDialog() == DialogResult.OK) {
				fileName = ofdFileOpen.FileName;
				switch (Path.GetExtension(fileName)) {
					case ".rtf":
						rtTextArea.LoadFile(fileName, RichTextBoxStreamType.RichText);
						break;
					default:
						rtTextArea.LoadFile(fileName, RichTextBoxStreamType.PlainText);
						break;
				}
				Text = fileName + " - テキストエディタ";
				initChanged();
			}
		}

		private void NewToolStripMenuItem_Click(object sender, EventArgs e) {
			//新規作成
			OpenExitJudge(sender, e, "NewCreate");
		}

		private void initTextEditer() {
			//初期化メソッド
			rtTextArea.Clear();
			fileName = "";
			Text = "無題 - テキストエディタ";
			PasteJudge();
			FontColorDelete();
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

		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e) {
			//削除
			int selectPos = rtTextArea.SelectionStart;
			try {
				if (rtTextArea.SelectionLength == 0) {
					rtTextArea.Text = rtTextArea.Text.Remove(selectPos, 1);
				}
				else {
					rtTextArea.Text = rtTextArea.Text.Remove(selectPos, rtTextArea.SelectionLength);
				}
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

		private void rtTextArea_TextChanged(object sender, EventArgs e) {
			//やり直し・元に戻す・削除・保存・カラー・フォントの判定
			RedoToolStripMenuItem.Enabled = rtTextArea.CanRedo;
			UndoToolStripMenuItem.Enabled = rtTextArea.CanUndo;
			Changed = true;
			FontColorDelete();
		}

		private void FontColorDelete() {
			//カラー・フォント・削除判定
			ColorToolStripMenuItem.Enabled = rtTextArea.Text.Length > 0;
			FontToolStripMenuItem.Enabled = rtTextArea.Text.Length > 0;
			DeleteToolStripMenuItem.Enabled = rtTextArea.Text.Length > 0;
		}

		private void rtTextArea_SelectionChanged(object sender, EventArgs e) {
			//切り取り・コピー判定
			CutToolStripMenuItem.Enabled = rtTextArea.SelectedText.Length > 0 ;
			CopyToolStripMenuItem.Enabled = rtTextArea.SelectedText.Length > 0 ;
		}

		private void PasteJudge() {
			//貼り付け判定
			PasteToolStripMenuItem.Enabled = Clipboard.GetDataObject().GetDataPresent(DataFormats.Rtf);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			//×を押したとき
			OpenExitJudge(sender, e, "Exit");
		}

		private void OpenExitJudge(object sender, EventArgs e, string judge) {
			//終了判定
			if (rtTextArea.Text != "") {
				if (Changed) {
					DialogResult dr = MessageBox.Show
						(Text + "は更新されています。保存しますか?",
						Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					Changed = judge != "Exit";
					if (dr == DialogResult.Yes) {
						SaveToolStripMenuItem_Click(sender, e);
						ExitElseFlow(judge);
						initChanged();
					}
					else {
						ExitElseFlow(judge);
					}
				}
				else {
					ExitElseFlow(judge);
				}
			}
			else {
				ExitElseFlow(judge);
			}
		}

		private void ExitElseFlow(string judge) {
			//分岐
			switch (judge) {
				case "NewCreate":
					initTextEditer();
					break;
				case "Open":
					FileOpen();
					break;
				case "Exit":
					Application.Exit();
					break;
				default:
					break;
			}
		}
	}
}