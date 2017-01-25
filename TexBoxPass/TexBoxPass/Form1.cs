using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexBoxPass
{
    public partial class Form1 : Form
    {
        bool clickButton1 = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '#';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clickButton1)
            {
                label1.Text = textBox1.Text;
                clickButton1 = false;
                button1.Text = "Спрятать пароль";
                return;
            }
            else if (clickButton1 == false)
            {
                label1.Text = "";
                button1.Text = "Показать пароль";
                clickButton1 = true;
                return;
            }
          
           
        }
    }
}
