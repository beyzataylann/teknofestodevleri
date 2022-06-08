using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teknofestodevleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox3.Text);
            int sonuc = 1;
            for (int i = 1; i <= sayi; i++)
            {
                if (i == 4)
                {

                }
                else
                {
                    sonuc = sonuc * i;
                }
            }
            label4.Text = Convert.ToString(sonuc);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            textBox1.Text = " ";
            textBox2.Text = "   ";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sayac++;
            label6.Text = sayac.ToString();
            pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y + 3);
        }

        
        private void button8_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}