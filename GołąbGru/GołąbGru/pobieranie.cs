using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace GołąbGru
{
    public partial class pobieranie : Form
    {
        WebClient wc = new WebClient();
        public pobieranie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);
            Uri imageurl = new Uri(textBox1.Text);
            wc.DownloadFileAsync(imageurl, "MojPobranyObraz.png");
        }

        private void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Pobrano Plik", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
