using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MusicPlayer : Form
    {
        public MusicPlayer()
        {
            InitializeComponent();
        }
        string[] paths, files;

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect= true;
            if (ofd.ShowDialog() ==System.Windows.Forms.DialogResult.OK)
            {
               paths = ofd.FileNames;
               files = ofd.SafeFileNames;
            }

            for (int i = 0; i < files.Length; i++)
            {
                ListMusic.Items.Add(files[i]);  
            }
        }

        private void ListMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[ListMusic.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
