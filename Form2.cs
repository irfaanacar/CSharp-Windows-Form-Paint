using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintCizim
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog renk= new ColorDialog();
            renk.ShowDialog();
            label1.ForeColor=renk.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 git = new Form3();
            git.Show();
            this.Hide();
        }
    }
}
