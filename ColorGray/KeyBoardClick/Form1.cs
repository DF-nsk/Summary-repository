using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyBoardClick
{
    public partial class Form1 : Form
    {
        Bitmap bmp;

        public Form1()
        {
            InitializeComponent();
            LoadPicture("DSC_0082.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
           DialogResult result = openFileDialog1.ShowDialog();
            LoadPicture(openFileDialog1.FileName);

          
        }
        public void LoadPicture(string filename)
        {
            try
            {
                bmp = new Bitmap(Image.FromFile(filename));
                textBox1.Text = filename;
                pictureBox1.Image = bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangePicture();
        }

        public void ChangePicture()
        {
            Bitmap res = new Bitmap(bmp);
            for (int y =0;y<bmp.Height;y++)
                for(int x=0;x<bmp.Width;x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    if (checkBox1.Checked)
                    {
                        pixel = ChangeGray(pixel); 
                    }
                    res.SetPixel(x, y, pixel);
                }
            pictureBox1.Image = res;
        }

        private Color ChangeGray(Color pixel)
        {
            int avg = (pixel.R + pixel.G + pixel.B + 1) / 3;

            return Color.FromArgb(avg, avg, avg);
        }
    }
}
