using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyBoardEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = string.Empty; label2.Text = String.Empty;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label1.Text = "Нажата клавиша: " + e.KeyChar;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label2.Text = String.Empty;
            //Если нажат ALT
            if (e.Alt == true) label2.Text += "Alt: Yes\n";
            else label2.Text += "Alt: No\n";
            //Если нажат Shift
            if (e.Shift == true) label2.Text += "Shift: Yes\n";
            else label2.Text += "Shift: No\n";
            //Если нажат Ctrl
            if (e.Control == true) label2.Text += "Ctrl: Yes\n";
            else label2.Text += "Ctrl: No\n";
            label2.Text += string.Format("код клавиши: {0} \nKeyData: {1} \nKeyValue: {2}", e.KeyCode, e.KeyData, e.KeyValue);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            label1.Text = string.Empty; label2.Text = string.Empty;
        }
    }
}
