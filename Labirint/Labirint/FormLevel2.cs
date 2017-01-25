using System;
using System.Drawing;
using System.Windows.Forms;

namespace Labirint
{
    public partial class FormLevel2 : Form
    {
        public FormLevel2()
        {
            InitializeComponent();
        }

     
        private void Start_Game()
        {
            Point point = label_Start.Location;
            point.Offset(label_Start.Width / 2, label_Start.Height / 2);
            Cursor.Position = PointToScreen(point);
            Sound.play_start();
        }
        private void finish_game()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void restart_game()
        {
            Sound.play_fail();
            DialogResult dr = MessageBox.Show("Выходить за рамки лабиринта и \nврезаться в стены нельзя!\nБедем еще раз играть",
                "Вы проиграли!",
                MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                Start_Game();
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void FormLevel2_Shown(object sender, EventArgs e)
        {
            Start_Game();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            restart_game();
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            label_door.Visible = false;
            label_key.Visible = false;
            Sound.play_key();
            
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
           
            MessageBox.Show("Победа!");
        }

          

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            restart_game();
            label_door.Visible = true;
            label_key.Visible = true;
        }

        private void label_finish_Click(object sender, EventArgs e)
        {

        }
    }
}
