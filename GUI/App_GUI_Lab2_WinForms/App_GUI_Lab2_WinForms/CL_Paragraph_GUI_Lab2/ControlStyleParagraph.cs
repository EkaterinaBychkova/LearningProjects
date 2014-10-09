using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CL_Paragraph_GUI_Lab2
{
    public partial class ControlStyleParagraph: UserControl
    {

        public decimal SelectionIndent
        {
            get
            {

                return numericUpDownSelectionIndent.Value;
            }
            set
            {

                numericUpDownSelectionIndent.Value = value;
            }
        }

        public decimal SelectionHangingIndent
        {

            get
            {

                return numericUpDownHangingIndent.Value;
            }
            set
            {

                numericUpDownHangingIndent.Value = value;
            }
        }

        public HorizontalAlignment SelectionAlignment
        {

            get { return (HorizontalAlignment)listBoxSelectionAlignment.SelectedItem; }
        }

        public ControlStyleParagraph()
        {
            InitializeComponent();

            numericUpDownSelectionIndent.Minimum = 0;
            numericUpDownSelectionIndent.Maximum = 100;

            numericUpDownHangingIndent.Minimum = 0;
            numericUpDownHangingIndent.Maximum = 100;


        }

    }
}
