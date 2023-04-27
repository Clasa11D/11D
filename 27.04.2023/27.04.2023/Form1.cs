using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27._04._2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxPlus.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCircle.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPlus.ImageLocation = "plus.jpeg";
            pictureBoxCircle.ImageLocation = "circle.jpeg";
        }

        private void pictureBoxPlus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out _))
            {
                Plus x = new Plus(int.Parse(textBox1.Text));
                this.Hide();
                x.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("In textbox nu este un numar!");
            
        }

        private void pictureBoxCircle_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out _))
            {
                Circle x = new Circle(int.Parse(textBox1.Text));
                this.Hide();
                x.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("In textbox nu este un numar!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
