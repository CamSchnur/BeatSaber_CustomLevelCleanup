using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeatSaber_CustomLevelCleanup
{
    public partial class FormMain : Form
    {
        String defaultDataDirectory = System.IO.Path.GetFullPath(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "..", "LocalLow", "Hyperbolic Magnetism", "Beat Saber"));
        String defaultCustomLevelsDirectory = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Beat Saber\\Beat Saber_Data\\CustomLevels\\";

        public FormMain()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxCustomLevels.Text = defaultCustomLevelsDirectory;
            textBoxPlayerData.Text = System.IO.Path.GetFullPath(Path.Combine(defaultDataDirectory, "PlayerData.dat"));
            textBoxSongHashData.Text = System.IO.Path.GetFullPath(Path.Combine(defaultDataDirectory, "SongHashData.dat"));
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            CustomLevelCleaner.CleanupUnstarredLevels(textBoxPlayerData.Text, textBoxSongHashData.Text, textBoxCustomLevels.Text);
        }

        #region Directory Change Related
        private void buttonChangePlayerData_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog f = new OpenFileDialog())
            {
                f.DefaultExt = ".dat";
                f.Filter = "Beat Saber Player Data files (PlayerData.dat)|PlayerData.dat|All Files (*.*)|*.*";
                f.InitialDirectory = defaultDataDirectory;
                if(f.ShowDialog() == DialogResult.OK)
                {
                    textBoxPlayerData.Text = f.FileName;
                }
            }
        }

        private void buttonChangeSongHashData_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog f = new OpenFileDialog())
            {
                f.DefaultExt = ".dat";
                f.Filter = "Beat Saber Song Hash Data files (SongHashData.dat)|SongHashData.dat|All Files (*.*)|*.*";
                f.InitialDirectory = defaultDataDirectory;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    textBoxSongHashData.Text = f.FileName;
                }
            }
        }

        private void buttonChangeCustomLevels_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog f = new FolderBrowserDialog())
            {
                f.SelectedPath = defaultCustomLevelsDirectory;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    textBoxCustomLevels.Text = f.SelectedPath;
                }
            }
        }
        #endregion
    }
}
