using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Программа вводит через текстовое поле число, при щелчке на командной кнопке
извлекается корень и выводит результат на метку label1. В случае ввода не числа сообщает об ошидки, 
выводя красным цветом предупреждение в метку label1 */

namespace Корень
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            base.Text = "Извлечение квадратного корня";
            button1.Text = "Извлечь корень";
            textBox1.Clear();  //Отчистка текстового поля
            label1.Text = null; //или = String.Empty
            textBox1.TabIndex = 0; //Установка фокуса в текщем поле
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single X; //Из этого числа будем извлекать корень
            //Преорбазование
            bool num = Single.TryParse(textBox1.Text, out X);
            if (num ==false)
            {
                label1.Text = "Следует ввести число";
                label1.ForeColor = Color.Red;
                textBox1.Clear();
                return;
            }

            var Y = (Single)Math.Sqrt(X);
            label1.ForeColor = Color.Black;
            label1.Text = string.Format("Корень из {0} равен {1:F5}", X, Y);
        }
    }
}
