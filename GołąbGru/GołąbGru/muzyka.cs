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
    public partial class muzyka : Form
    {
        public muzyka()
        {
            InitializeComponent();
        }
        string[] paths, files;

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Write a code to play music 
            axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            //Code to SElect Songs 
            OpenFileDialog ofd = new OpenFileDialog();

            //Code to select multiple files 
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //Save the names of the track in files array 
                paths = ofd.FileNames; //Save the paths of the tracks in path array 

                //Display the music titles in listbox 
                for (int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); //Display Songs in Listbox 
                }
            }
        }
    }
}
