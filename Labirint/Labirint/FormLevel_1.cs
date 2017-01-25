using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint
{
    public partial class FormLevel_1 : Form
    {
        public FormLevel_1()
        {
            InitializeComponent();
            
        }

        private void FormLevel_1_Load(object sender, EventArgs e)
        {

        }
        //Установка курсора мыши при старте
        private void Start_Game()
        {
            Point point = label_Start.Location;
           point.Offset(label_Start.Width / 2, label_Start.Height / 2);
            Cursor.Position = PointToScreen(point);
            Sound.play_start();
        }

        private void FormLevel_1_Shown(object sender, EventArgs e)
        {
            Start_Game();
        }

     

        private void finish_game()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            restart_game();
        }

        private void restart_game()
        {
            Sound.play_fail();
            DialogResult dr = MessageBox.Show("Выходить за рамки лабиринта и \nврезаться в стены нельзя!\nБедем еще раз играть","Вы проиграли!", 
                MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                Start_Game();
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            restart_game();
        }
    }
}
