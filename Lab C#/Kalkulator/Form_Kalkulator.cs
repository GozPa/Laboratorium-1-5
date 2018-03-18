using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okno_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label3.Text = (System.Double.Parse(textBox1.Text) + System.Double.Parse(textBox2.Text)).ToString();
                label1.Text = "+";
            }
            if (radioButton2.Checked == true)
            {
                label3.Text = (System.Double.Parse(textBox1.Text) - System.Double.Parse(textBox2.Text)).ToString();
                label1.Text = "-";
            }
        }
    }
}
