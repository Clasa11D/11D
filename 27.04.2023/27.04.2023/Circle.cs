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
    public partial class Circle : Form
    {
        int N;
        public Circle(int n)
        {
            InitializeComponent();
            N = n;
        }

        private void Circle_Load(object sender, EventArgs e)
        {
            pictureBox1.Paint += pictureBox1_Paint;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen x = new Pen(Color.Red, 2);
            Point center = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
            Random r = new Random();
            for(int i = 5; i <= 5 * N; i += 5)
            {
                Color color;
                
                color = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
                x = new Pen(color, 2);
                g.DrawEllipse(x, center.X - i, center.Y - i, 2 * i, 2 * i);
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
