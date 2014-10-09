namespace App_GUI_Lab2_WinForms
{
    partial class StyleParagraphForm
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
            this.controlStyleParagraph1 = new CL_Paragraph_GUI_Lab2.ControlStyleParagraph();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // controlStyleParagraph1
            // 
            this.controlStyleParagraph1.Location = new System.Drawing.Point(12, 12);
            this.controlStyleParagraph1.Name = "controlStyleParagraph1";
            this.controlStyleParagraph1.SelectionHangingIndent = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.controlStyleParagraph1.SelectionIndent = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.controlStyleParagraph1.Size = new System.Drawing.Size(200, 154);
            this.controlStyleParagraph1.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(58, 182);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(139, 182);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // StyleParagraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 217);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.controlStyleParagraph1);
            this.Name = "StyleParagraphForm";
            this.Text = "Форматирование абзаца";
            this.ResumeLayout(false);

        }

        #endregion

        private CL_Paragraph_GUI_Lab2.ControlStyleParagraph controlStyleParagraph1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}