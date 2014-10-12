using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace App_GUI_Lab2_WinForms
{
    public partial class WorkForm : Form
    {

        private int _numberDocument;
        private string _nameDocument;
        private MainForm _mainForm;
        private PrintDocument _printDoc;

        public int NumberDocument
        {

            get { return _numberDocument; }
        }

        public string NameDocument
        {

            get { return _nameDocument; }
        }

        public WorkForm(int numberDocument, string nameDocument, MainForm mainForm)
        {
            InitializeComponent();

            _numberDocument = numberDocument;
            _nameDocument = nameDocument;
            _mainForm = mainForm;

            this.Text = _nameDocument;
        }

        #region Form Operation

        public void SaveFile()
        {

            FileInfo textFile = new FileInfo(this.Text);

            if (textFile.Exists)
            {

                richTextBoxWorkWindow.SaveFile(textFile.FullName);
            }
            else
            {

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Rich Text (*.rtf) | *.rtf" ;

                if (saveFile.ShowDialog() == DialogResult.OK)
                {

                    richTextBoxWorkWindow.SaveFile(saveFile.FileName);
                    this.Text = saveFile.FileName;
                }
                else
                {

                    MessageBox.Show("Вы отменили сохранение файла.");
                }
            }
        }

        public void SaveFileAs()
        {

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Rich Text (*.rtf) | *.rtf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {

                richTextBoxWorkWindow.SaveFile(saveFile.FileName);
                this.Text = saveFile.FileName;
            }
            else
            {

                MessageBox.Show("Вы отменили сохранение файла.");
            }
        }

        public void LoadFile(string pathFile)
        {

            richTextBoxWorkWindow.LoadFile(pathFile);
            this.Text = pathFile;
        }

        public void CloseFile()
        {

            FileInfo closeFile = new FileInfo(this.Text);

            if (closeFile.Exists)
            {

                this.SaveFile();
            }
            else
            {

                var messageResult = MessageBox.Show("Сохранить " + this.Text + "?", "Закрытие файла", MessageBoxButtons.OKCancel);

                if (messageResult == DialogResult.OK)
                {

                    this.SaveFileAs();
                }
                else
                {

                    this.Close();
                }
            }
        }

        public void CopyText()
        {

            if (!string.IsNullOrEmpty(richTextBoxWorkWindow.SelectedText))
            {

                richTextBoxWorkWindow.Copy();
            }
            else
            {

                MessageBox.Show("Вы не выделили текст.");
            }

        }

        public void PasteText()
        {

            if (Clipboard.ContainsData(DataFormats.Rtf))
            {

                richTextBoxWorkWindow.Paste();
            }
            else
            {

                MessageBox.Show("Буфер обмена пуст.");
            }

        }

        public void CutText()
        {

            if (Clipboard.ContainsData(DataFormats.Rtf))
            {

                richTextBoxWorkWindow.Paste();
            }
            else
            {

                MessageBox.Show("Буфер обмена пуст.");
            }

        }

        private void ShowStyleFont()
        {

            StyleFontForm styleFont = new StyleFontForm();
            styleFont.Show();
        }

        private void ShowStyleParagraph()
        {

            StyleParagraphForm styleParagraph = new StyleParagraphForm();
            styleParagraph.Show();
        }

        private void SetLastActiveWorkForm()
        {

            _mainForm.LastActiveWorkFormNameFile = _nameDocument;
        }

        #endregion

        #region Form Events

        private void TextChangedRichTextBoxWorkWindow(object sender, EventArgs e)
        {

            this.toolStripButtonReturn.ToolTipText = this.richTextBoxWorkWindow.UndoActionName;
            this.toolStripButtonNext.ToolTipText = this.richTextBoxWorkWindow.RedoActionName;
        }

        private void ClickToolStripButtonReturn(object sender, EventArgs e)
        {

            if (richTextBoxWorkWindow.CanUndo)
            {

                richTextBoxWorkWindow.Undo();
            }
            else
            {

                MessageBox.Show("Последнее действие отменить нельзя.");
            }
            
        }

        private void ClickToolStripButtonNext(object sender, EventArgs e)
        {

            if (richTextBoxWorkWindow.CanRedo)
            {

                richTextBoxWorkWindow.Redo();
            }
            else
            {

                MessageBox.Show("Последнее действие применить снова не возможно.");
            }
        }

        private void ClickToolStripButtonSave(object sender, EventArgs e)
        {

            this.SaveFile();
        }

        private void MouseDownRichTextBoxWorkWindow(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {

                contextMenuStripWorkWindow.Show(richTextBoxWorkWindow, e.Location);
            }
        }

        private void ClickSaveFileToolStripMenuItem(object sender, EventArgs e)
        {

            this.SaveFile();
        }

        private void ClickSaveFileAsToolStripMenuItem(object sender, EventArgs e)
        {

            this.SaveFileAs();
        }

        private void ClickCopyToolStripMenuItem(object sender, EventArgs e)
        {

            this.CopyText();
        }

        private void ClickPasteToolStripMenuItem(object sender, EventArgs e)
        {

            this.PasteText();
        }

        private void ClickCutToolStripMenuItem(object sender, EventArgs e)
        {

            this.CutText();
        }

        private void ClickFontToolStripMenuItem(object sender, EventArgs e)
        {

            this.ShowStyleFont();
        }

        private void ClickFormatStyleToolStripMenuItem(object sender, EventArgs e)
        {

            this.ShowStyleFont();
        }

        private void ClickParagraphToolStripMenuItem(object sender, EventArgs e)
        {

            this.ShowStyleParagraph();
        }

        private void EnterWorkForm(object sender, EventArgs e)
        {

            this.SetLastActiveWorkForm();
        }

        private void EnterRichTextBoxWorkWindow(object sender, EventArgs e)
        {

            this.SetLastActiveWorkForm();
        }

        #endregion

    }
}
