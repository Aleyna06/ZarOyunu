using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zar_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastegele = new Random();
        int toplamben = 0;
        int toplampc = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = rastegele.Next(1, 7);
            int b = rastegele.Next(1, 7);

            toplamben = toplamben + a + b;
            label17.Text = toplamben.ToString();

            if (a==1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar1.png";
            }
            if (a == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar2.jpg";
            }
            if (a == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar3.jpg";
            }
            if (a == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar4.jpg";
            }
            if (a == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar5.jpg";
            }
            if (a == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar6.jpg";
            }


            if (b == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar1.png";
            }
            if (b == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar2.jpg";
            }
            if (b == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar3.jpg";
            }
            if (b == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar4.jpg";
            }
            if (b == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar5.jpg";
            }
            if (b == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar6.jpg";
            }

            label2.Text = a.ToString();
            label4.Text = b.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = rastegele.Next(1, 7);
            int d = rastegele.Next(1, 7);

            toplampc = toplampc + c + d;
            label15.Text = toplampc.ToString();

            label8.Text = c.ToString();
            label10.Text = d.ToString();



            if (c == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar1.png";
            }
            if (c == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar2.jpg";
            }
            if (c == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar3.jpg";
            }
            if (c == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar4.jpg";
            }
            if (c == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar5.jpg";
            }
            if (c == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar6.jpg";
            }

            if (d == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar1.png";
            }
            if (d == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar2.jpg";
            }
            if (d == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar3.jpg";
            }
            if (d == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar4.jpg";
            }
            if (d == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar5.jpg";
            }
            if (d == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Aleyna\\Desktop\\Zar\\Zar6.jpg";
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
