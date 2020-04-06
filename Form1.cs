using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_cienti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
         
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ADIOS");
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("dddd dd 'de' MMMM 'de' yyyy");
            label5.Text = DateTime.Now.ToString("hh/mm/ss");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Single valor;
            Double res;
            valor = Single.Parse(textBox1.Text);
            res = System.Math.Sin(valor);
            textBox2.Text = res.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single valor;
            Double res;
            valor = Single.Parse(textBox1.Text);
            res = System.Math.Cos(valor);
            textBox2.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Single valor;
            Double res;
            valor = Single.Parse(textBox1.Text);
            res = System.Math.Tan(valor);
            textBox2.Text = res.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Single valor;
            Double res;
            valor = Single.Parse(textBox1.Text);
            res = System.Math.Asin(valor);
            textBox2.Text = res.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Single valor;
            Double res;
            valor = Single.Parse(textBox1.Text);
            res = System.Math.Acos(valor);
            textBox2.Text = res.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Single valor;
            Double res;
            valor = Single.Parse(textBox1.Text);
            res = System.Math.Atan(valor);
            textBox2.Text = res.ToString();
        }
    }
}
