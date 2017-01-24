using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public interface IMainForm
    {
        string FilePath { get; }
        string Content { get; set; }
        void SetSymbolCount(int count);
        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler ContentChanged;
    }

    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            butOpen.Click += new EventHandler (ButOpen_Click);
            butSave.Click += ButSave_Click;
            tBoxContent.TextChanged += ButContent_TextChanged;
            butSelect.Click += ButSelectFile_Click;
            numericUpDown1.ValueChanged += numFont_ValueChange;

        }
        #region //Проброс событий
        private void ButOpen_Click(object sender, EventArgs e)
        {
            if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            if (FileSaveClick != null) FileSaveClick(this, EventArgs.Empty);
        }

        private void ButContent_TextChanged(object sender, EventArgs e)
        {
            if (ContentChanged != null) ContentChanged(this, EventArgs.Empty);
        }
        #endregion
        #region Реализация интерфейса IMainForm
        public string FilePath
        { get { return tbFilePath.Text; } }

        public string Content
        {
            get { return tBoxContent.Text; }
            set { tBoxContent.Text = value; }
        }
        public void SetSymbolCount (int count)
        {
            tsLabelCount.Text = count.ToString();
        }

        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveClick;
        public event EventHandler ContentChanged;
        #endregion

        private void ButSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Текстовые файла|*.txt|Все файлы|*.*";

            if (dlg.ShowDialog()==DialogResult.OK)
            {
                tbFilePath.Text = dlg.FileName;
                if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
            }
        }

        private void numFont_ValueChange(object sender, EventArgs e)
        {
            tBoxContent.Font = new Font("Calibri", (float)numericUpDown1.Value);
        }


    }

}
