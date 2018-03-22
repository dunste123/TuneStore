using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuneStore_8_feb_2018 {
    public partial class Form1 : Form {

        private AudioManager manager;
        private Track[] tracks = new Track[100];
        private int trackI = 0;

        public Form1() {
            InitializeComponent();

            this.manager = new AudioManager()
                .SetLabel(this.lblCurrentTrackDSte);
        }

        private void Form1_Load(object sender, EventArgs e) {
            //Hide tabs
            //Remove 3d effects
            this.tabMainDSte.Appearance = TabAppearance.FlatButtons;
            //sets ‘thinness’  
            this.tabMainDSte.ItemSize = new Size(0, 1);
            this.tabMainDSte.SizeMode = TabSizeMode.Fixed;
            this.tmrSpashDSte.Start();
        }

        private void btnAddTrackDSte_Click(object sender, EventArgs e) {
            //
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                tracks[trackI] = new Track(dialog.FileName);
                this.rtbTracksDSte.AppendText(tracks[trackI].SafeFileName + "\n");
                trackI++;
            }
        }

        private void rtbTracksDSte_MouseDoubleClick(object sender, MouseEventArgs e) {
            String songName = this.rtbTracksDSte.Lines[
                    this.rtbTracksDSte.GetLineFromCharIndex(
                        this.rtbTracksDSte.SelectionStart
                    )
                ];
            foreach(Track t in tracks) {
                if(t != null && t.SafeFileName == songName) {
                    manager.PlaySong(
                        t.FileName
                    );
                    break;
                }
            }

        }

        private void btnStopDSte_Click(object sender, EventArgs e) {
            manager.StopSong();
        }

        private void SplashScreen() {
            //
            this.prbSplashDSte.Value = 99;
            if (this.prbSplashDSte.Value < 100)
                this.prbSplashDSte.Value++;
            if(this.prbSplashDSte.Value == 100) {
                this.tmrSpashDSte.Stop();
                Thread.Sleep(100);
                for(int i=0; i < 20; i++) {
                    Thread.Sleep(100);
                    Application.DoEvents();
                }
                this.tabMainDSte.SelectTab(1);
            }

        }

        private void tmrSpashDSte_Tick(object sender, EventArgs e) {
            SplashScreen();
        }

        private void btnPlayTrackDSte_Click(object sender, EventArgs e) {
            int yes = toInteget(this.txbTrackNumDSte.Text);
            if (yes == int.MinValue) {
                MessageBox.Show("That is not a valid number", "Whoops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String songName;
            try {
                songName = this.rtbTracksDSte.Lines[
                    yes - 1
                ];
            }
            catch(IndexOutOfRangeException ew) {
                MessageBox.Show("Number is too large", "Whoops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                songName = null;
                return;
            }
            if(songName == null) {
                MessageBox.Show("That is not a valid number", "Whoops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (Track t in tracks) {
                if (t != null && t.SafeFileName == songName) {
                    manager.PlaySong(
                        t.FileName
                    );
                    break;
                }
            }
        }

        private int toInteget(String s) {

            try {
                return Convert.ToInt32(s);
            }
            catch(FormatException e) {
                return int.MinValue;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            //
            String message = @"TuneStore

Created by:         Duncan Sterken
Date:                 8 feb 2018";
            MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e) {
            //
        }

        private void locateToolStripMenuItem_Click(object sender, EventArgs e) {
            //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            //
            throw new Exception("Can't exit this app");
        }
    }
}
