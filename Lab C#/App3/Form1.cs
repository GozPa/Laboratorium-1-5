using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zakonczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void jakasOpcjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = (sender as ToolStripMenuItem).Text; 
        }

        private void oAutorachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Paulina Gozdek", "Autor Aplikacji", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
            
            if (result ==DialogResult.Yes)
            {
                label1.Text = "Tak";
            }
            else if (result == DialogResult.No)
            {
                label1.Text = "Nie";
            }
            else
            {
                MessageBox.Show("Czy jesteś 100% pewien ?! To może zaważyć na twoim życiu!!", "Ostrzerzenie!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = toolStripTextBox1.Text;
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = toolStripComboBox1.Text;
        }
    }
}
