using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GołąbGru
{
    public partial class chat : Form
    {
        public chat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "A więc nazywasz się ".ToString() + textBox1.Text.ToString() + " Miło mi Poznać ale musze już lecieć pa!";
            label4.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
