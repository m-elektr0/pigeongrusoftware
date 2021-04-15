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
    public partial class gry : Form
    {
        int punktyGracza = 0;
        public gry()
        {
            InitializeComponent();
        }

        private void gry_Load(object sender, EventArgs e)
        {
            pnlClicker.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlClicker.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            punktyGracza += 1;
            label1.Text = punktyGracza.ToString() + " PUNKTOW";
        }
    }
}
