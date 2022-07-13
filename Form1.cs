using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product m1 = new Product
            {

                number = int.Parse(textBox1.Text),
                date = datetxt.Text,
                invnumb = int.Parse(textBox3.Text),
                objname = textBox4.Text,
                count = int.Parse(textBox5.Text),
                price = double.Parse(textBox6.Text),
            };
            MessageBox.Show("YOU HAVE COMPLETED THE SUBMISSION");
            m1.save();
            display.DataSource = null;
            display.DataSource = Product.getall();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
