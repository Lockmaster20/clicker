using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Score p = new Score();

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = p.Conta();
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = p.Temp();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = p.ResP();
            label2.Text = p.ResT();
        }
    }
}