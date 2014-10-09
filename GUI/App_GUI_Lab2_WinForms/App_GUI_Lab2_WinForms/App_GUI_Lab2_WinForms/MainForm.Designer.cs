namespace App_GUI_Lab2_WinForms
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuStripMainWindow = new System.Windows.Forms.MenuStrip();
            this.FailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.абзацToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стильФорматированияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.панельИнструментовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.строкаСостоянияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадомToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поВертикалиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поГоризонталиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПоследнихОткрытыхОконToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStripMainWindow = new System.Windows.Forms.StatusStrip();
            this.FontToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.FontSizeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ColorFontToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ActiveWindowToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStripMainWindow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.окноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поВертикалиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поГоризонталиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПоследнихОткрытыхОконToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMainWindow = new System.Windows.Forms.ToolStrip();
            this.createToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPreview = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxFont = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonFontItalics = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFontBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUnderlined = new System.Windows.Forms.ToolStripButton();
            this.MenuStripMainWindow.SuspendLayout();
            this.StatusStripMainWindow.SuspendLayout();
            this.contextMenuStripMainWindow.SuspendLayout();
            this.toolStripMainWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripMainWindow
            // 
            this.MenuStripMainWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FailToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.ViewToolStripMenuItem,
            this.WindowToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.MenuStripMainWindow.Location = new System.Drawing.Point(0, 0);
            this.MenuStripMainWindow.Name = "MenuStripMainWindow";
            this.MenuStripMainWindow.Size = new System.Drawing.Size(992, 24);
            this.MenuStripMainWindow.TabIndex = 0;
            this.MenuStripMainWindow.Text = "menuStrip1";
            // 
            // FailToolStripMenuItem
            // 
            this.FailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createFileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.ClearToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.FailToolStripMenuItem.Name = "FailToolStripMenuItem";
            this.FailToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.FailToolStripMenuItem.Text = "Файл";
            // 
            // createFileToolStripMenuItem
            // 
            this.createFileToolStripMenuItem.Name = "createFileToolStripMenuItem";
            this.createFileToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.createFileToolStripMenuItem.Text = "Создать";
            this.createFileToolStripMenuItem.Click += new System.EventHandler(this.ClickCreateFileToolStripMenuItem);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.ClickSaveToolStripMenuItem);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.ClickOpenToolStripMenuItem);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.saveAsToolStripMenuItem.Text = "Сохранить как";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.ClickSaveAsToolStripMenuItem);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.ClearToolStripMenuItem.Text = "Отчичстить";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClickClearToolStripMenuItem);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.printPreviewToolStripMenuItem.Text = "Предварительный просмотр";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.вырезатьToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.EditToolStripMenuItem.Text = "Правка";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шрифтToolStripMenuItem,
            this.абзацToolStripMenuItem,
            this.стильФорматированияToolStripMenuItem,
            this.панельИнструментовToolStripMenuItem,
            this.строкаСостоянияToolStripMenuItem});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.ViewToolStripMenuItem.Text = "Вид";
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            // 
            // абзацToolStripMenuItem
            // 
            this.абзацToolStripMenuItem.Name = "абзацToolStripMenuItem";
            this.абзацToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.абзацToolStripMenuItem.Text = "Абзац";
            // 
            // стильФорматированияToolStripMenuItem
            // 
            this.стильФорматированияToolStripMenuItem.Name = "стильФорматированияToolStripMenuItem";
            this.стильФорматированияToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.стильФорматированияToolStripMenuItem.Text = "Стиль форматирования";
            // 
            // панельИнструментовToolStripMenuItem
            // 
            this.панельИнструментовToolStripMenuItem.Name = "панельИнструментовToolStripMenuItem";
            this.панельИнструментовToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.панельИнструментовToolStripMenuItem.Text = "Панель инструментов";
            // 
            // строкаСостоянияToolStripMenuItem
            // 
            this.строкаСостоянияToolStripMenuItem.Name = "строкаСостоянияToolStripMenuItem";
            this.строкаСостоянияToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.строкаСостоянияToolStripMenuItem.Text = "Строка состояния";
            // 
            // WindowToolStripMenuItem
            // 
            this.WindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каскадомToolStripMenuItem1,
            this.поВертикалиToolStripMenuItem1,
            this.поГоризонталиToolStripMenuItem1,
            this.списокПоследнихОткрытыхОконToolStripMenuItem1});
            this.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem";
            this.WindowToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.WindowToolStripMenuItem.Text = "Окно";
            // 
            // каскадомToolStripMenuItem1
            // 
            this.каскадомToolStripMenuItem1.Name = "каскадомToolStripMenuItem1";
            this.каскадомToolStripMenuItem1.Size = new System.Drawing.Size(249, 22);
            this.каскадомToolStripMenuItem1.Text = "Каскадом";
            // 
            // поВертикалиToolStripMenuItem1
            // 
            this.поВертикалиToolStripMenuItem1.Name = "поВертикалиToolStripMenuItem1";
            this.поВертикалиToolStripMenuItem1.Size = new System.Drawing.Size(249, 22);
            this.поВертикалиToolStripMenuItem1.Text = "По вертикали";
            // 
            // поГоризонталиToolStripMenuItem1
            // 
            this.поГоризонталиToolStripMenuItem1.Name = "поГоризонталиToolStripMenuItem1";
            this.поГоризонталиToolStripMenuItem1.Size = new System.Drawing.Size(249, 22);
            this.поГоризонталиToolStripMenuItem1.Text = "По горизонтали";
            // 
            // списокПоследнихОткрытыхОконToolStripMenuItem1
            // 
            this.списокПоследнихОткрытыхОконToolStripMenuItem1.Name = "списокПоследнихОткрытыхОконToolStripMenuItem1";
            this.списокПоследнихОткрытыхОконToolStripMenuItem1.Size = new System.Drawing.Size(249, 22);
            this.списокПоследнихОткрытыхОконToolStripMenuItem1.Text = "Список последних открытых окон";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.AboutToolStripMenuItem.Text = "О программе";
            // 
            // StatusStripMainWindow
            // 
            this.StatusStripMainWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontToolStripStatusLabel,
            this.FontSizeToolStripStatusLabel,
            this.ColorFontToolStripStatusLabel,
            this.ActiveWindowToolStripStatusLabel});
            this.StatusStripMainWindow.Location = new System.Drawing.Point(0, 501);
            this.StatusStripMainWindow.Name = "StatusStripMainWindow";
            this.StatusStripMainWindow.Size = new System.Drawing.Size(992, 22);
            this.StatusStripMainWindow.TabIndex = 1;
            this.StatusStripMainWindow.Text = "statusStrip1";
            // 
            // FontToolStripStatusLabel
            // 
            this.FontToolStripStatusLabel.Name = "FontToolStripStatusLabel";
            this.FontToolStripStatusLabel.Size = new System.Drawing.Size(50, 17);
            this.FontToolStripStatusLabel.Text = "Шрифт: ";
            // 
            // FontSizeToolStripStatusLabel
            // 
            this.FontSizeToolStripStatusLabel.Name = "FontSizeToolStripStatusLabel";
            this.FontSizeToolStripStatusLabel.Size = new System.Drawing.Size(92, 17);
            this.FontSizeToolStripStatusLabel.Text = "Размер шрифта: ";
            // 
            // ColorFontToolStripStatusLabel
            // 
            this.ColorFontToolStripStatusLabel.Name = "ColorFontToolStripStatusLabel";
            this.ColorFontToolStripStatusLabel.Size = new System.Drawing.Size(83, 17);
            this.ColorFontToolStripStatusLabel.Text = "Цвет шрифта: ";
            // 
            // ActiveWindowToolStripStatusLabel
            // 
            this.ActiveWindowToolStripStatusLabel.Name = "ActiveWindowToolStripStatusLabel";
            this.ActiveWindowToolStripStatusLabel.Size = new System.Drawing.Size(90, 17);
            this.ActiveWindowToolStripStatusLabel.Text = "Активное окно: ";
            // 
            // contextMenuStripMainWindow
            // 
            this.contextMenuStripMainWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.окноToolStripMenuItem});
            this.contextMenuStripMainWindow.Name = "contextMenuStripMainWindow";
            this.contextMenuStripMainWindow.Size = new System.Drawing.Size(101, 26);
            // 
            // окноToolStripMenuItem
            // 
            this.окноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каскадомToolStripMenuItem,
            this.поВертикалиToolStripMenuItem,
            this.поГоризонталиToolStripMenuItem,
            this.списокПоследнихОткрытыхОконToolStripMenuItem});
            this.окноToolStripMenuItem.Name = "окноToolStripMenuItem";
            this.окноToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.окноToolStripMenuItem.Text = "Окно";
            // 
            // каскадомToolStripMenuItem
            // 
            this.каскадомToolStripMenuItem.Name = "каскадомToolStripMenuItem";
            this.каскадомToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.каскадомToolStripMenuItem.Text = "Каскадом";
            // 
            // поВертикалиToolStripMenuItem
            // 
            this.поВертикалиToolStripMenuItem.Name = "поВертикалиToolStripMenuItem";
            this.поВертикалиToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.поВертикалиToolStripMenuItem.Text = "По вертикали";
            // 
            // поГоризонталиToolStripMenuItem
            // 
            this.поГоризонталиToolStripMenuItem.Name = "поГоризонталиToolStripMenuItem";
            this.поГоризонталиToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.поГоризонталиToolStripMenuItem.Text = "По горизонтали";
            // 
            // списокПоследнихОткрытыхОконToolStripMenuItem
            // 
            this.списокПоследнихОткрытыхОконToolStripMenuItem.Name = "списокПоследнихОткрытыхОконToolStripMenuItem";
            this.списокПоследнихОткрытыхОконToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.списокПоследнихОткрытыхОконToolStripMenuItem.Text = "Список последних открытых окон";
            // 
            // toolStripMainWindow
            // 
            this.toolStripMainWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripButton,
            this.toolStripButtonSave,
            this.toolStripButtonOpen,
            this.toolStripButtonPreview,
            this.toolStripComboBoxFont,
            this.toolStripButtonFontItalics,
            this.toolStripButtonFontBold,
            this.toolStripButtonUnderlined});
            this.toolStripMainWindow.Location = new System.Drawing.Point(0, 24);
            this.toolStripMainWindow.Name = "toolStripMainWindow";
            this.toolStripMainWindow.Size = new System.Drawing.Size(992, 25);
            this.toolStripMainWindow.TabIndex = 4;
            this.toolStripMainWindow.Text = "toolStrip1";
            // 
            // createToolStripButton
            // 
            this.createToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.createToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("createToolStripButton.Image")));
            this.createToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createToolStripButton.Name = "createToolStripButton";
            this.createToolStripButton.Size = new System.Drawing.Size(54, 22);
            this.createToolStripButton.Text = "Создать";
            this.createToolStripButton.Click += new System.EventHandler(this.ClickCreateToolStripButton);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(66, 22);
            this.toolStripButtonSave.Text = "Сохранить";
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonOpen.Text = "Открыть";
            // 
            // toolStripButtonPreview
            // 
            this.toolStripButtonPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonPreview.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPreview.Image")));
            this.toolStripButtonPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPreview.Name = "toolStripButtonPreview";
            this.toolStripButtonPreview.Size = new System.Drawing.Size(155, 22);
            this.toolStripButtonPreview.Text = "Предварительный просмотр";
            // 
            // toolStripComboBoxFont
            // 
            this.toolStripComboBoxFont.Name = "toolStripComboBoxFont";
            this.toolStripComboBoxFont.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripButtonFontItalics
            // 
            this.toolStripButtonFontItalics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFontItalics.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFontItalics.Image")));
            this.toolStripButtonFontItalics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFontItalics.Name = "toolStripButtonFontItalics";
            this.toolStripButtonFontItalics.Size = new System.Drawing.Size(47, 22);
            this.toolStripButtonFontItalics.Text = "Курсив";
            // 
            // toolStripButtonFontBold
            // 
            this.toolStripButtonFontBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFontBold.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFontBold.Image")));
            this.toolStripButtonFontBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFontBold.Name = "toolStripButtonFontBold";
            this.toolStripButtonFontBold.Size = new System.Drawing.Size(76, 22);
            this.toolStripButtonFontBold.Text = "Полужирный";
            // 
            // toolStripButtonUnderlined
            // 
            this.toolStripButtonUnderlined.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUnderlined.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUnderlined.Image")));
            this.toolStripButtonUnderlined.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUnderlined.Name = "toolStripButtonUnderlined";
            this.toolStripButtonUnderlined.Size = new System.Drawing.Size(87, 22);
            this.toolStripButtonUnderlined.Text = "Подчёркнутый";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 523);
            this.Controls.Add(this.toolStripMainWindow);
            this.Controls.Add(this.StatusStripMainWindow);
            this.Controls.Add(this.MenuStripMainWindow);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Главное окно";
            this.MenuStripMainWindow.ResumeLayout(false);
            this.MenuStripMainWindow.PerformLayout();
            this.StatusStripMainWindow.ResumeLayout(false);
            this.StatusStripMainWindow.PerformLayout();
            this.contextMenuStripMainWindow.ResumeLayout(false);
            this.toolStripMainWindow.ResumeLayout(false);
            this.toolStripMainWindow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripMainWindow;
        private System.Windows.Forms.ToolStripMenuItem FailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusStripMainWindow;
        private System.Windows.Forms.ToolStripStatusLabel FontToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel FontSizeToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ColorFontToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ActiveWindowToolStripStatusLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMainWindow;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem абзацToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стильФорматированияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem панельИнструментовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem строкаСостоянияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каскадомToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поВертикалиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поГоризонталиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem списокПоследнихОткрытыхОконToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem окноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каскадомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поВертикалиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поГоризонталиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПоследнихОткрытыхОконToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripMainWindow;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonPreview;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFont;
        private System.Windows.Forms.ToolStripButton toolStripButtonFontItalics;
        private System.Windows.Forms.ToolStripButton toolStripButtonFontBold;
        private System.Windows.Forms.ToolStripButton toolStripButtonUnderlined;
        private System.Windows.Forms.ToolStripMenuItem createFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton createToolStripButton;
    }
}

