namespace CL_Paragraph_GUI_Lab2
{
    partial class ControlStyleParagraph
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
            this.labelIndent = new System.Windows.Forms.Label();
            this.numericUpDownSelectionIndent = new System.Windows.Forms.NumericUpDown();
            this.labelHangingIndent = new System.Windows.Forms.Label();
            this.numericUpDownHangingIndent = new System.Windows.Forms.NumericUpDown();
            this.labelSelectionAlignment = new System.Windows.Forms.Label();
            this.listBoxSelectionAlignment = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelectionIndent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHangingIndent)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIndent
            // 
            this.labelIndent.AutoSize = true;
            this.labelIndent.Location = new System.Drawing.Point(15, 13);
            this.labelIndent.Name = "labelIndent";
            this.labelIndent.Size = new System.Drawing.Size(75, 13);
            this.labelIndent.TabIndex = 0;
            this.labelIndent.Text = "Отступ слева";
            // 
            // numericUpDownSelectionIndent
            // 
            this.numericUpDownSelectionIndent.Location = new System.Drawing.Point(18, 29);
            this.numericUpDownSelectionIndent.Name = "numericUpDownSelectionIndent";
            this.numericUpDownSelectionIndent.Size = new System.Drawing.Size(159, 20);
            this.numericUpDownSelectionIndent.TabIndex = 1;
            // 
            // labelHangingIndent
            // 
            this.labelHangingIndent.AutoSize = true;
            this.labelHangingIndent.Location = new System.Drawing.Point(15, 54);
            this.labelHangingIndent.Name = "labelHangingIndent";
            this.labelHangingIndent.Size = new System.Drawing.Size(119, 13);
            this.labelHangingIndent.TabIndex = 2;
            this.labelHangingIndent.Text = "Отступ первой строки";
            // 
            // numericUpDownHangingIndent
            // 
            this.numericUpDownHangingIndent.Location = new System.Drawing.Point(18, 70);
            this.numericUpDownHangingIndent.Name = "numericUpDownHangingIndent";
            this.numericUpDownHangingIndent.Size = new System.Drawing.Size(159, 20);
            this.numericUpDownHangingIndent.TabIndex = 3;
            // 
            // labelSelectionAlignment
            // 
            this.labelSelectionAlignment.AutoSize = true;
            this.labelSelectionAlignment.Location = new System.Drawing.Point(15, 95);
            this.labelSelectionAlignment.Name = "labelSelectionAlignment";
            this.labelSelectionAlignment.Size = new System.Drawing.Size(167, 13);
            this.labelSelectionAlignment.TabIndex = 4;
            this.labelSelectionAlignment.Text = "Горизонтальное выравнивание";
            // 
            // listBoxSelectionAlignment
            // 
            this.listBoxSelectionAlignment.FormattingEnabled = true;
            this.listBoxSelectionAlignment.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Center"});
            this.listBoxSelectionAlignment.Location = new System.Drawing.Point(18, 111);
            this.listBoxSelectionAlignment.Name = "listBoxSelectionAlignment";
            this.listBoxSelectionAlignment.Size = new System.Drawing.Size(159, 17);
            this.listBoxSelectionAlignment.TabIndex = 5;
            // 
            // ControlStyleParagraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxSelectionAlignment);
            this.Controls.Add(this.labelSelectionAlignment);
            this.Controls.Add(this.numericUpDownHangingIndent);
            this.Controls.Add(this.labelHangingIndent);
            this.Controls.Add(this.numericUpDownSelectionIndent);
            this.Controls.Add(this.labelIndent);
            this.Name = "ControlStyleParagraph";
            this.Size = new System.Drawing.Size(199, 162);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelectionIndent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHangingIndent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIndent;
        private System.Windows.Forms.NumericUpDown numericUpDownSelectionIndent;
        private System.Windows.Forms.Label labelHangingIndent;
        private System.Windows.Forms.NumericUpDown numericUpDownHangingIndent;
        private System.Windows.Forms.Label labelSelectionAlignment;
        private System.Windows.Forms.ListBox listBoxSelectionAlignment;
    }
}
