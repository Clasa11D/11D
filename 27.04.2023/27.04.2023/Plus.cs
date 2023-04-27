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
    public partial class Plus : Form
    {
        int N;
        TextBox[] termeni;
        Label[] plusuri;
        int suma;
        TextBox rezultat;
        public Plus(int n)
        {
            InitializeComponent();
            N = n;
        }

        private void Plus_Load(object sender, EventArgs e)
        {
            termeni = new TextBox[N];
            plusuri = new Label[N];
            for(int i = 0; i < N; i++)
            {
                termeni[i] = new TextBox();
                termeni[i].Name = i.ToString();
                termeni[i].Size = new Size(40, 40);
                termeni[i].Location = new Point(i * 60 + 20, 150);
                this.Controls.Add(termeni[i]);
            }

            for(int i = 0; i < N - 1; i++)
            {
                plusuri[i] = new Label();
                plusuri[i].Text = "+";
                plusuri[i].Size = new Size(35, 35);
                plusuri[i].Font = new Font("Bell MT", 15);
                plusuri[i].ForeColor = Color.White;
                plusuri[i].Location = new Point(i * 60 + 60, 150);
                this.Controls.Add(plusuri[i]);
            }
            plusuri[N - 1] = new Label();
            plusuri[N - 1].Text = "=";
            plusuri[N - 1].Size = new Size(20, 20);
            plusuri[N - 1].Font = new Font("Bell MT", 15);
            plusuri[N - 1].ForeColor = Color.White;
            plusuri[N - 1].Location = new Point((N - 1) * 60 + 60, 150);
            this.Controls.Add(plusuri[N - 1]);
            rezultat = new TextBox();
            rezultat.Name = "textBoxRezultat";
            rezultat.Size = new Size(50, 50);
            rezultat.Location = new Point((N) * 60 + 20, 150);
            this.Controls.Add(rezultat);
            plusuri[N - 1].Click += rezultat_Click;
        }
        private void rezultat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < N; i++)
                suma += int.Parse(termeni[i].Text);
            rezultat.Text = suma.ToString();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
