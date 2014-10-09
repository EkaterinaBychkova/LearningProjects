namespace App_GUI_Lab2_WinForms
{
    partial class WorkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkForm));
            this.contextMenuStripWorkWindow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paragraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripWorkWindow = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonReturn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.richTextBoxWorkWindow = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripWorkWindow.SuspendLayout();
            this.toolStripWorkWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripWorkWindow
            // 
            this.contextMenuStripWorkWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFileToolStripMenuItem,
            this.saveFileAsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.contextMenuStripWorkWindow.Name = "contextMenuStripWorkWindow";
            this.contextMenuStripWorkWindow.Size = new System.Drawing.Size(151, 92);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.saveFileToolStripMenuItem.Text = "Сохранить";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.ClickSaveFileToolStripMenuItem);
            // 
            // saveFileAsToolStripMenuItem
            // 
            this.saveFileAsToolStripMenuItem.Name = "saveFileAsToolStripMenuItem";
            this.saveFileAsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.saveFileAsToolStripMenuItem.Text = "Сохранить как";
            this.saveFileAsToolStripMenuItem.Click += new System.EventHandler(this.ClickSaveFileAsToolStripMenuItem);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.cutToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.editToolStripMenuItem.Text = "Правка";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.copyToolStripMenuItem.Text = "Копировать";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.ClickCopyToolStripMenuItem);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.pasteToolStripMenuItem.Text = "Вставить";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.ClickPasteToolStripMenuItem);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.cutToolStripMenuItem.Text = "Вырезать";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.ClickCutToolStripMenuItem);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.paragraphToolStripMenuItem,
            this.formatStyleToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.viewToolStripMenuItem.Text = "Вид";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.fontToolStripMenuItem.Text = "Шрифт";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.ClickFontToolStripMenuItem);
            // 
            // paragraphToolStripMenuItem
            // 
            this.paragraphToolStripMenuItem.Name = "paragraphToolStripMenuItem";
            this.paragraphToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.paragraphToolStripMenuItem.Text = "Абзац";
            this.paragraphToolStripMenuItem.Click += new System.EventHandler(this.ClickParagraphToolStripMenuItem);
            // 
            // formatStyleToolStripMenuItem
            // 
            this.formatStyleToolStripMenuItem.Name = "formatStyleToolStripMenuItem";
            this.formatStyleToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.formatStyleToolStripMenuItem.Text = "Стиль форматирования";
            this.formatStyleToolStripMenuItem.Click += new System.EventHandler(this.ClickFormatStyleToolStripMenuItem);
            // 
            // toolStripWorkWindow
            // 
            this.toolStripWorkWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonReturn,
            this.toolStripButtonNext,
            this.toolStripButtonSave});
            this.toolStripWorkWindow.Location = new System.Drawing.Point(0, 0);
            this.toolStripWorkWindow.Name = "toolStripWorkWindow";
            this.toolStripWorkWindow.Size = new System.Drawing.Size(592, 25);
            this.toolStripWorkWindow.TabIndex = 1;
            this.toolStripWorkWindow.Text = "toolStrip1";
            // 
            // toolStripButtonReturn
            // 
            this.toolStripButtonReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonReturn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReturn.Image")));
            this.toolStripButtonReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReturn.Name = "toolStripButtonReturn";
            this.toolStripButtonReturn.Size = new System.Drawing.Size(42, 22);
            this.toolStripButtonReturn.Text = "Назад";
            this.toolStripButtonReturn.Click += new System.EventHandler(this.ClickToolStripButtonReturn);
            // 
            // toolStripButtonNext
            // 
            this.toolStripButtonNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonNext.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNext.Image")));
            this.toolStripButtonNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNext.Name = "toolStripButtonNext";
            this.toolStripButtonNext.Size = new System.Drawing.Size(48, 22);
            this.toolStripButtonNext.Text = "Вперёд";
            this.toolStripButtonNext.Click += new System.EventHandler(this.ClickToolStripButtonNext);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(66, 22);
            this.toolStripButtonSave.Text = "Сохранить";
            this.toolStripButtonSave.Click += new System.EventHandler(this.ClickToolStripButtonSave);
            // 
            // richTextBoxWorkWindow
            // 
            this.richTextBoxWorkWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxWorkWindow.Location = new System.Drawing.Point(0, 28);
            this.richTextBoxWorkWindow.Name = "richTextBoxWorkWindow";
            this.richTextBoxWorkWindow.Size = new System.Drawing.Size(592, 241);
            this.richTextBoxWorkWindow.TabIndex = 2;
            this.richTextBoxWorkWindow.Text = "";
            this.richTextBoxWorkWindow.TextChanged += new System.EventHandler(this.TextChangedRichTextBoxWorkWindow);
            this.richTextBoxWorkWindow.Enter += new System.EventHandler(this.EnterRichTextBoxWorkWindow);
            this.richTextBoxWorkWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownRichTextBoxWorkWindow);
            // 
            // WorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 273);
            this.Controls.Add(this.richTextBoxWorkWindow);
            this.Controls.Add(this.toolStripWorkWindow);
            this.Name = "WorkForm";
            this.Text = "Документ";
            this.Enter += new System.EventHandler(this.EnterWorkForm);
            this.contextMenuStripWorkWindow.ResumeLayout(false);
            this.toolStripWorkWindow.ResumeLayout(false);
            this.toolStripWorkWindow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripWorkWindow;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paragraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripWorkWindow;
        private System.Windows.Forms.ToolStripButton toolStripButtonReturn;
        private System.Windows.Forms.ToolStripButton toolStripButtonNext;
        private System.Windows.Forms.RichTextBox richTextBoxWorkWindow;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
    }
}