using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonPr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Кнопка";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Создание кнопки
            Button button1 = new Button();
            //Задание свойств кнопки   
            button1.Visible = true;
            //Размеры
            button1.Size = new Size(150,30);
            //Расположение
            button1.Location = new Point(70, 80);
            button1.Text = "Новая кнопка";
            this.Controls.Add(button1);

            //подписка на событие Click
            button1.Click += new EventHandler(btClick);


        }
        //Создание события btClick
        private void btClick(object sender, EventArgs e)
        {
            MessageBox.Show("Нажата кнопка");
        }
    }
}
