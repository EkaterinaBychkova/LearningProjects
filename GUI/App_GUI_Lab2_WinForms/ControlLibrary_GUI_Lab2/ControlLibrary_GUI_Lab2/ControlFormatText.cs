using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Бизнес логика элемента управления ControlFormatText.
 * Элемент управления используется для задания формата текста.
 */

/*
 * Используемая справка MSDN. 
 * http://msdn.microsoft.com/ru-ru/library/system.windows.forms.listbox%28v=vs.110%29.aspx
 * http://msdn.microsoft.com/ru-ru/library/system.windows.forms.numericupdown%28v=vs.110%29.aspx
 * http://msdn.microsoft.com/ru-ru/library/system.windows.forms.checkbox%28v=vs.110%29.aspx
 */

namespace ControlLibrary_GUI_Lab2
{
    public partial class ControlFormatText: UserControl
    {
        public ControlFormatText()
        {
            InitializeComponent();
        }

        //Свойства и методы для listBoxFonts.
        public Object ListBoxFontSelected
        {
            get
            {
                return listBoxFonts.SelectedItem;
            }
            set
            {

                listBoxFonts.SelectedItem = value;
            }
        }

        public void ListBoxFontAdd(object item)
        {

            listBoxFonts.Items.Add(item);
        }

        public void ListBoxFontAddRange(ListBox.ObjectCollection collectionItems)
        {

            listBoxFonts.Items.AddRange(collectionItems);
        }

        public void ListBoxFontAddRange(Object[] arrayItems)
        {

            listBoxFonts.Items.AddRange(arrayItems);
        }

        public void ListBoxFontClear()
        {

            listBoxFonts.Items.Clear();
        }

        //Свойства для numericUpDownSizeFont.
        public decimal NumericUpDownSizeFontMinimum
        {

            get
            {

                return numericUpDownSizeFont.Minimum;
            }
            set
            {

                numericUpDownSizeFont.Minimum = value;
            }
        }

        public decimal NumericUpDownSizeFontMaximum
        {

            get
            {

                return numericUpDownSizeFont.Maximum;
            }
            set
            {

                numericUpDownSizeFont.Maximum = value;
            }
        }

        public decimal NumericUpDownSizeFontValue
        {

            get
            {

                return numericUpDownSizeFont.Value;
            }
            set
            {

                numericUpDownSizeFont.Value = value;
            }
        }

        //Свойства для элементов checkBox.
        public bool CheckBoxBoldChecked
        {

            get
            {

                return checkBoxBold.Checked;
            }
            set
            {

                checkBoxBold.Checked = value;
            }
        }

        public bool CheckBoxItalicsChecked
        {

            get
            {

                return checkBoxItalics.Checked;
            }
            set
            {

                checkBoxItalics.Checked = value;
            }
        }

        public bool CheckBoxUnderlinedChecked
        {

            get
            {

                return checkBoxUnderlined.Checked;
            }
            set
            {

                checkBoxUnderlined.Checked = value;
            }
        }
    }
}
