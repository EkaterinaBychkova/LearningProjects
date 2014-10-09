using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_GUI_Lab2_WinForms
{
    public partial class MainForm : Form
    {

        List<WorkForm> _openDocuments;
        int _numberDocument = 1;
        string _lastActiveWorkFormNameFile;

        public string LastActiveWorkFormNameFile
        {

            get
            {

                return _lastActiveWorkFormNameFile;
            }
            set
            {

                _lastActiveWorkFormNameFile = value;
            }
        }

        public MainForm()
        {
            InitializeComponent();

            _openDocuments = new List<WorkForm>();
            _lastActiveWorkFormNameFile = null;
        }

        private WorkForm GetLastActiveWorkFormObj()
        {

            for (int i = _openDocuments.Count; i >= 0; i--)
            {

                if (_openDocuments[i].NameDocument == _lastActiveWorkFormNameFile)
                {

                    return _openDocuments[i];
                }
                else
                { }
            }

            return _openDocuments[_openDocuments.Count];
        }

        private void CreateDocument()
        {

            WorkForm openDocument = new WorkForm(_numberDocument, "Документ_" + _numberDocument.ToString(), this);
            openDocument.MdiParent = this;
            _numberDocument++;
            _openDocuments.Add(openDocument);

            openDocument.Show();
        }

        private void OpenFile()
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Rich Text (*.rtf) | *.rtf";

            this.CreateDocument();
            _openDocuments.Last().LoadFile(openFile.FileName);
            
        }

        private void ClickCreateFileToolStripMenuItem(object sender, EventArgs e)
        {

            this.CreateDocument();
        }

        private void ClickCreateToolStripButton(object sender, EventArgs e)
        {

            this.CreateDocument();
        }

        private void ClickSaveToolStripMenuItem(object sender, EventArgs e)
        {

            this.GetLastActiveWorkFormObj().SaveFile();
        }

        private void ClickSaveAsToolStripMenuItem(object sender, EventArgs e)
        {

            this.GetLastActiveWorkFormObj().SaveFileAs();
        }

        private void ClickOpenToolStripMenuItem(object sender, EventArgs e)
        {

            this.OpenFile();
        }

        private void ClickClearToolStripMenuItem(object sender, EventArgs e)
        {

            for (int i = 0; i < _openDocuments.Count; i++)
            {

                _openDocuments[i].CloseFile();
            }

            _openDocuments.Clear();
        }
        
    }
}
