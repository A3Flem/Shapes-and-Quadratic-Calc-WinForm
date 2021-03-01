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
    public partial class squareForm : Form
    {
        public squareForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height = Convert.ToInt32(textBox1.Text);
            double width = Convert.ToInt32(textBox2.Text);
            //double areaSquare = calcSquare.getRectangleArea(height, width);
            //textBox3.Text = "" + areaSquare;

            textBox3.Text = "" + calcSquare.getRectangleArea(height, width);
            textBox4.Text = "" + calcSquare.getRectanglePeri(height, width);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.ShowDialog();
            this.Close();
        }
    }
}