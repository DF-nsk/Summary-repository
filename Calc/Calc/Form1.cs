using System;
using System.Windows.Forms;

//Программа калькулятор. В этой версии нет проверки вводимых символов в окно TextBox 
//Если ввести буквы, будет ошибка. В ближайщем будущем исправлю.

namespace Calc
{
    public partial class Form1 : Form
    {
        String znak = string.Empty; //знак арифметической операции
        bool startEntry = true; //Признак ввода нового числа
        double param1, param2; //вводимые пользователем числа

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right;
            //Связь события Click с кнопками
            //Цифры
            this.button1.Click += new System.EventHandler(_cifir);
            this.button2.Click += new System.EventHandler(_cifir);
            this.button3.Click += new System.EventHandler(_cifir);
            this.button4.Click += new System.EventHandler(_cifir);
            this.button5.Click += new System.EventHandler(_cifir);
            this.button6.Click += new System.EventHandler(_cifir);
            this.button7.Click += new System.EventHandler(_cifir);
            this.button8.Click += new System.EventHandler(_cifir);
            this.button9.Click += new System.EventHandler(_cifir);
            this.button10.Click += new System.EventHandler(_cifir);
                        //Операции
                        this.button12.Click += new System.EventHandler(_operaciya);
                        this.button13.Click += new System.EventHandler(_operaciya);
                        this.button14.Click += new System.EventHandler(_operaciya);
                        this.button15.Click += new System.EventHandler(_operaciya);
            //Знак
            this.button11.Click += new System.EventHandler(_result);

                    this.button16.Click += new System.EventHandler(_clear);
        }

        private void _clear(object sender, EventArgs e)
        {
            textBox1.Text = "0"; znak = null; startEntry = true;
        }

        private void _result(object sender, EventArgs e)
        {
            double result = 0;
            param2 = Double.Parse(textBox1.Text);
            if (znak == "+") result = param1 + param2;
            if (znak == "-") result = param1 - param2;
            if (znak == "*") result = param1 * param2;
            if (znak == "/") result = param1 / param2;
            znak = null;
            //Отобразить результат
            textBox1.Text = result.ToString();
            param1 = result; startEntry = true;
        }

        private void _operaciya(object sender, EventArgs e)
        {
            param1 = Double.Parse(textBox1.Text);
            Button myButton = (Button)sender;
            znak = myButton.Text;
            startEntry = true;
        }

        private void _cifir(object sender, EventArgs e)
        {
            //Обработка события нажатия кнопки
            Button myButton = (Button)sender;
            string digit = myButton.Text;
            if(startEntry==true)
            {
                textBox1.Text = digit;

                startEntry = false; return;
            }
            if (startEntry == false) textBox1.Text += digit;
        }
    }
}
