namespace ControlLibrary_GUI_Lab2
{
    partial class ControlFormatText
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFonts = new System.Windows.Forms.Label();
            this.listBoxFonts = new System.Windows.Forms.ListBox();
            this.labelFontSize = new System.Windows.Forms.Label();
            this.numericUpDownSizeFont = new System.Windows.Forms.NumericUpDown();
            this.checkBoxBold = new System.Windows.Forms.CheckBox();
            this.checkBoxItalics = new System.Windows.Forms.CheckBox();
            this.checkBoxUnderlined = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeFont)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFonts
            // 
            this.labelFonts.AutoSize = true;
            this.labelFonts.Location = new System.Drawing.Point(17, 17);
            this.labelFonts.Name = "labelFonts";
            this.labelFonts.Size = new System.Drawing.Size(41, 13);
            this.labelFonts.TabIndex = 0;
            this.labelFonts.Text = "Шрифт";
            // 
            // listBoxFonts
            // 
            this.listBoxFonts.FormattingEnabled = true;
            this.listBoxFonts.Location = new System.Drawing.Point(20, 33);
            this.listBoxFonts.Name = "listBoxFonts";
            this.listBoxFonts.Size = new System.Drawing.Size(120, 17);
            this.listBoxFonts.TabIndex = 1;
            // 
            // labelFontSize
            // 
            this.labelFontSize.AutoSize = true;
            this.labelFontSize.Location = new System.Drawing.Point(193, 17);
            this.labelFontSize.Name = "labelFontSize";
            this.labelFontSize.Size = new System.Drawing.Size(88, 13);
            this.labelFontSize.TabIndex = 2;
            this.labelFontSize.Text = "Размер шрифта";
            // 
            // numericUpDownSizeFont
            // 
            this.numericUpDownSizeFont.Location = new System.Drawing.Point(196, 33);
            this.numericUpDownSizeFont.Name = "numericUpDownSizeFont";
            this.numericUpDownSizeFont.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSizeFont.TabIndex = 3;
            // 
            // checkBoxBold
            // 
            this.checkBoxBold.AutoSize = true;
            this.checkBoxBold.Location = new System.Drawing.Point(20, 69);
            this.checkBoxBold.Name = "checkBoxBold";
            this.checkBoxBold.Size = new System.Drawing.Size(91, 17);
            this.checkBoxBold.TabIndex = 4;
            this.checkBoxBold.Text = "Полужирный";
            this.checkBoxBold.UseVisualStyleBackColor = true;
            // 
            // checkBoxItalics
            // 
            this.checkBoxItalics.AutoSize = true;
            this.checkBoxItalics.Location = new System.Drawing.Point(20, 92);
            this.checkBoxItalics.Name = "checkBoxItalics";
            this.checkBoxItalics.Size = new System.Drawing.Size(62, 17);
            this.checkBoxItalics.TabIndex = 5;
            this.checkBoxItalics.Text = "Курсив";
            this.checkBoxItalics.UseVisualStyleBackColor = true;
            // 
            // checkBoxUnderlined
            // 
            this.checkBoxUnderlined.AutoSize = true;
            this.checkBoxUnderlined.Location = new System.Drawing.Point(20, 115);
            this.checkBoxUnderlined.Name = "checkBoxUnderlined";
            this.checkBoxUnderlined.Size = new System.Drawing.Size(99, 17);
            this.checkBoxUnderlined.TabIndex = 6;
            this.checkBoxUnderlined.Text = "Подчёркнутый";
            this.checkBoxUnderlined.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxUnderlined);
            this.Controls.Add(this.checkBoxItalics);
            this.Controls.Add(this.checkBoxBold);
            this.Controls.Add(this.numericUpDownSizeFont);
            this.Controls.Add(this.labelFontSize);
            this.Controls.Add(this.listBoxFonts);
            this.Controls.Add(this.labelFonts);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(343, 155);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeFont)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFonts;
        private System.Windows.Forms.ListBox listBoxFonts;
        private System.Windows.Forms.Label labelFontSize;
        private System.Windows.Forms.NumericUpDown numericUpDownSizeFont;
        private System.Windows.Forms.CheckBox checkBoxBold;
        private System.Windows.Forms.CheckBox checkBoxItalics;
        private System.Windows.Forms.CheckBox checkBoxUnderlined;
    }
}
