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
    public partial class Form1 : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
        }

        private void animacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void muzykaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[2];
            muzyka mm = new muzyka();
            mm.Show();
        }

        private void pobieranieZInternetuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pobieranie mm = new pobieranie();
            mm.Show();
        }

        private void szukajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            szukaj mm = new szukaj();
            mm.Show();
        }

        private void internetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            przegladarka mm = new przegladarka();
            mm.Show();
        }

        private void gadajZGołębiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chat mm = new chat();
            mm.Show();
        }

        private void zagrajWGryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gry mm = new gry();
            mm.Show();
        }

        private void powiedzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            powiedz mm = new powiedz();
            mm.Show();
        }

        private void kalendarzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[4];
            kalendarz mm = new kalendarz();
            mm.Show();
        }

        private void opowiedzHistorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[1];
            MessageBox.Show("A więc opowiadam Historie... Raz Kiedy Jak Zawsze Byłem Na Fontannach Szukając Chleba Podszedł Do Mnie Człowiek I dał mi kawałek hot-doga");
            pictureBox1.Image = imageList1.Images[3];
        }

        private void stronaWWWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://grudroid.blogspot.com/");
        }

        private void opcjeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aktualizacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            System.Diagnostics.Process.Start("https://grudroid.blogspot.com/");
        }

        private void wyjdźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void animacja1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
        }

        private void animacja2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[1];
        }

        private void animacja3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[2];
        }

        private void animacja4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[3];
        }

        private void animacja5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[4];
        }

        private void gołąbBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GołąbBox To Twój Assystent który ma wiele funkcji! Strona: https://grudroid.blogspot.com/");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void opcjeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Opcje mm = new Opcje();
            mm.Show();
        }

        private void udostępnijMnieZnajomymToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wyślij znajomemu wiadomość: Cześć ostatnio znalazłem fajnego assystenta na pulpit pobierz go z http://grudroid.blogspot.com już dziś!");
        }

        private void powiedzŻartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[1];
            MessageBox.Show(" A Więc Opowiadam żart: Przychodzi Jasiu do domu ze szkoły i mówi- Mamo zostałem dziś wyróżniony- za co Jasiu pyta mama- Pani powiedziała że cała nasza klasa to debile a ja największy odpowiedział Jasiu");
            pictureBox1.Image = imageList1.Images[3];
        }

        private void powiedzFaktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[1];
            MessageBox.Show("A Więc Powiem ci jeden ciekawy fakt: Gołębie są uważane za jedne z najbardziej inteligentnych ptaków na świecie i zdolne są do podejmowania zadań uważanych do tej pory za wyłącznie domenę ludzi i naczelnych.");
            pictureBox1.Image = imageList1.Images[3];
        }

        private void powiedzMiJakSieNazywaszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mapyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mapy mm = new mapy();
            mm.Show();
        }

        private void animacja6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[5];
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X - start_point.Y);
            }
        }
    }
}
