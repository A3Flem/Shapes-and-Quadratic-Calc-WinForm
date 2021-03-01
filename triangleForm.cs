using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms;
using WinForms.Class;

namespace WinForms
{
    public partial class triangleForm : Form
    {
        public triangleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(textBox1.Text);
            double b = Convert.ToInt32(textBox2.Text);
            double c = Convert.ToInt32(textBox5.Text);

            textBox3.Text = "" + calcTriangle.getTriangleArea(a, b, c);
            textBox4.Text = "" + calcTriangle.getTrianglePeri(a, b, c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.ShowDialog();
            this.Close();
        }
    }
}
  