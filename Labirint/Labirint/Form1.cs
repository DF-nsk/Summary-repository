using System;
using System.Windows.Forms;

namespace Labirint
{
    public partial class Form_Meny : Form
    {
        public Form_Meny()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            start_Level1();
        }
        private void start_Level1()
        { 
            FormLevel_1 level1 = new FormLevel_1();
          DialogResult dr = level1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                start_Level2();
            
        }

        private void start_Level2()
        {
            FormLevel2 level2 = new FormLevel2();
            DialogResult dr = level2.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            { }
               
        }

        private void checkBox_Sound_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Sound.Checked)
            {
                checkBox_Sound.Text = "Sound Yes";
                Sound.Sound_on();
                Sound.play_key();
            }
            else
            {
                checkBox_Sound.Text = "Sound No";
                Sound.Sound_off();
            }
          
        }

        private void Form_Meny_Load(object sender, EventArgs e)
        {

        }
    }
}
