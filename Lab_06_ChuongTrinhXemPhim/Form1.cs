using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_06_ChuongTrinhXemPhim
{
    public partial class MediaPlayer : Form
    {
        private string[] files;
        List<string> listP = new List<string>();
        private OpenFileDialog dialog = new OpenFileDialog();
        private int hideAndShow = 0;
        private int playAndPause = 0;
        public MediaPlayer()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.KeyPreview = true;
            slbVolume.Minimum = 0;
            slbVolume.Maximum = 100;
            slbVolume.Value = 50;
            wmpMain.settings.volume = slbVolume.Value;
            DirectoryInfo d = new DirectoryInfo(@"Videos");
            FileInfo[] Files = d.GetFiles("*.mp4");

            for (int i = 0; i < Files.Length; i++)
            {
                listVideos.Items.Add(Files[i]);
                listP.Add(Directory.GetFiles(@"Videos\")[i]);
            }

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            dialog.Filter = "Media(.)|*.*";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog1.SafeFileNames;
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    listP.Add(openFileDialog1.FileNames[i]);
                }

                for (int i = 0; i < files.Length; i++)
                {
                    listVideos.Items.Add(files[i]);
                }
            }
            if (listVideos.Items.Count > 3)
            {
                wmpMain.URL = listP[listVideos.Items.Count - 1];
            }
        }

        private void btnHideAndShow_Click(object sender, EventArgs e)
        {
            if (hideAndShow == 0)
            {
                listVideos.Show();
                btnHideAndShow.Text = "Hide";
                lbList.Show();
                hideAndShow = 1;
            }
            else if (hideAndShow == 1)
            {
                listVideos.Hide();
                btnHideAndShow.Text = "Show";
                lbList.Hide();
                hideAndShow = 0;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            wmpMain.Ctlcontrols.play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            wmpMain.Ctlcontrols.pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            wmpMain.Ctlcontrols.stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (wmpMain.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                wmpMain.fullScreen = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVideos.SelectedItems.Count > 0)
            {
                wmpMain.URL = listP[listVideos.SelectedIndex];
            }
        }

        private void slbVolume_Scroll(object sender, EventArgs e)
        {
            wmpMain.settings.volume = slbVolume.Value;
        }

        private void wmpMain_Enter(object sender, EventArgs e)
        {

        }

        private void MediaPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.O)
            {
                btnOpen.PerformClick();
            }
        }

        private void wmpMain_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1)
            {
                if (listVideos.SelectedIndex != listVideos.Items.Count - 1)
                {
                    BeginInvoke(new Action(() => {
                        listVideos.SelectedIndex += 1;
                    }));
                }
            }
        }
    }
}
