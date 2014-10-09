namespace App_GUI_Lab2_WinForms
{
    partial class StyleFontForm
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
            this.controlFormatText1 = new ControlLibrary_GUI_Lab2.ControlFormatText();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // controlFormatText1
            // 
            this.controlFormatText1.CheckBoxBoldChecked = false;
            this.controlFormatText1.CheckBoxItalicsChecked = false;
            this.controlFormatText1.CheckBoxUnderlinedChecked = false;
            this.controlFormatText1.ListBoxFontSelected = null;
            this.controlFormatText1.Location = new System.Drawing.Point(12, 12);
            this.controlFormatText1.Name = "controlFormatText1";
            this.controlFormatText1.NumericUpDownSizeFontMaximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.controlFormatText1.NumericUpDownSizeFontMinimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.controlFormatText1.NumericUpDownSizeFontValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.controlFormatText1.Size = new System.Drawing.Size(343, 155);
            this.controlFormatText1.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(280, 170);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(190, 170);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // StyleFontForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 205);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.controlFormatText1);
            this.Name = "StyleFontForm";
            this.Text = "Шрифт и Стиль форматирования";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLibrary_GUI_Lab2.ControlFormatText controlFormatText1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}