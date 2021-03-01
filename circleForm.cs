using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Class;

namespace WinForms
{
    public partial class circleForm : Form
    {
        public circleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r = Convert.ToInt32(textBox1.Text);
            textBox3.Text = "" + calcCircle.getCircleArea(r);
            textBox4.Text = "" + calcCircle.getCirclePeri(r);
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
