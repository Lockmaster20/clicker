using System;
using System.Windows.Forms;

namespace clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Text = p.Ler;
            label2.Text = p.ResT();
        }
        Score p = new Score();
        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = p.Conta();
            timer1.Start();
            p.Move(sender);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = p.Temp();
            p.Gravar();
            label3.Text = p.Ler;
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            p.ResPos(button1);
            label1.Text = p.ResP();
            label2.Text = p.ResT();
        }
    }
}