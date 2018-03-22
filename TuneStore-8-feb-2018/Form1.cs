using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuneStore_8_feb_2018 {
    public partial class Form1 : Form {

        private AudioManager manager;
        private List<Track> tracks = new List<Track>();
        private Regex regex = new Regex("(?:\\d+\\: )(.*)");
        //These are the file types that you are allowed to open
        private String fileFilter = "TuneStorePlaylist (*.tstore)|*.tstore|JSON file (*.json)|*.json|Text (*.txt)|*.txt|All Types|*";

        public Form1() {
            InitializeComponent();

            this.manager = new AudioManager()
                .SetLabel(this.lblCurrentTrackDSte)
                .SetProgressBar(this.prbTrackIndicatorDSte);
            //Set a handler for the next song event
            this.manager.NextSongEvent += new EventHandler(this.manager_next_song);
        }

        private void Form1_Load(object sender, EventArgs e) {
            //Hide tabs
            //Remove 3d effects
            this.tabMainDSte.Appearance = TabAppearance.FlatButtons;
            //sets ‘thinness’  
            this.tabMainDSte.ItemSize = new Size(0, 1);
            this.tabMainDSte.SizeMode = TabSizeMode.Fixed;
            this.tmrSpashDSte.Start();

            this.lblCurrentTrackDSte.Text = "";

            this.Text = "TUNE STORE";
        }

        #region event handlers
        private void btnAddTrackDSte_Click(object sender, EventArgs e) {
            //
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                Track t = new Track(dialog.FileName);
                tracks.Add(t);
                t.DisplayName = tracks.Count + ": " + t.SafeFileName;
                this.lbTracksDSte.Items.Add(t.DisplayName);
            }
        }

        private void lbTracksDSte_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.lbTracksDSte.SelectedItem != null) {
                String songName = this.lbTracksDSte.SelectedItem.ToString();
                foreach (Track t in tracks) {
                    if (t != null && t.DisplayName == songName) {
                        manager.PlaySong(
                            t.FileName
                        );
                        break;
                    }
                }
            }
        }

        private void btnStopDSte_Click(object sender, EventArgs e) {
            manager.StopSong();
        }

        private void btnPauseDSte_Click(object sender, EventArgs e) {
            manager.PauseUnpauseSong();
        }

        private void manager_next_song(object sender, EventArgs e) {
            int trackindex = getTrackIndex(manager.SongName);
            PlayTrackFromIndex(trackindex, true);
        }

        private void NextAndPreviosButtons(object sender, EventArgs e) {
            bool next = Boolean.Parse(((Button)sender).Tag.ToString());
            int trackindex = getTrackIndex(manager.SongName);
            if (next) {
                //Next track
                PlayTrackFromIndex(trackindex, true);
            } else {
                // prev track
                PlayTrackFromIndex(trackindex - 2, true);
            }
        }

        /// <summary>
        /// This does the things for the splash screen trackbar
        /// </summary>
        private void SplashScreen() {
            this.prbSplashDSte.Value = 100;
            if (this.prbSplashDSte.Value < 100)
                this.prbSplashDSte.Value++;
            if(this.prbSplashDSte.Value == 100) {
                this.tmrSpashDSte.Stop();
                //Thread.Sleep(100);
                //for (int i = 0; i < 20; i++) {
                //    Thread.Sleep(100);
                //    Application.DoEvents();
                //}
                this.tabMainDSte.SelectTab(1);
            }

        }

        private void tmrSpashDSte_Tick(object sender, EventArgs e) {
            SplashScreen();
        }

        private void btnPlayTrackDSte_Click(object sender, EventArgs e) {
            int yes = toInteget(this.txbTrackNumDSte.Text);
            if (yes == int.MinValue) {
                MessageBox.Show("Please enter a valid number in the textbox next to the button", "Whoops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //PlayTrackFromIndex(yes - 1);
            String songName;
            try {
                songName = this.tracks[yes - 1].DisplayName;
                this.lbTracksDSte.SelectedIndex = yes - 1;
            }
            catch {
                MessageBox.Show("Could not select this song", "Whoops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                songName = null;
                return;
            }
            if (songName == null) {
                MessageBox.Show("No song found", "Whoops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (Track t in tracks) {
                if (t != null && t.DisplayName == songName) {
                    manager.PlaySong(
                        t.FileName
                    );
                    break;
                }
            }
        }

        private void txbSearchDSte_TextChanged(object sender, EventArgs e) {
            String text = this.txbSearchDSte.Text.ToLower();
            List<String> temp = new List<String>();
            foreach (Track t in tracks) {
                if (t.DisplayName.ToLower().IndexOf(text) > -1) {
                    temp.Add(t.DisplayName);
                }
            }
            this.lbTracksDSte.Items.Clear();
            this.lbTracksDSte.Items.AddRange(temp.ToArray());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            //
            String message = @"TuneStore

Created by:         Duncan Sterken
Date:                   8 feb 2018";
            MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e) {
            //
            NotepadHelperDSte.ShowMessage(@"Hello There
This is a manual.", "TuneStore Manual");
        }

        private void locateToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start("explorer.exe", Application.StartupPath);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure that you want to exit?", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                Application.Exit();
        }

        private void txbTrackNumDSte_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                btnPlayTrackDSte_Click(sender, null);
            }
        }

        private void crashPCToolStripMenuItem_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show(@"This functions will actialy trigger a harmless blue screen.

If you click OK a harmless blue screen will trigger.
If you click Cancel nothing will happen.

I'M NOT RESPONSIBLE FOR ANY DAMAGE TO YOUR COMPUTER!", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK) {
                MessageBox.Show("Preparing to crash pc, please wait", "Crashing");
                if (AllTheRequiredFilesArePresent()) {
                    CrashPc(false);
                } else {
                    MakeSureThatAllRequredFilesArePresentAndCrashPcAfter();
                }
            }
        }

        private void savePlaylistToolStripMenuItem_Click(object sender, EventArgs e) {

            String filename = manager.GetDefaultFileName();
            SaveTracksToFile(tracks, manager.GetDefaultFileName());
        }

        private void loadPlaylistToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.DefaultExt = ".tstore";
            dialog.Filter = fileFilter;
            if (dialog.ShowDialog() != DialogResult.OK) {
                return;
            }
            List<Track> ts = manager.ImportList(new StreamReader(dialog.FileName).ReadToEnd());
            if (ts == null) {
                MessageBox.Show("This file has an invalid format or no tracks are found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.tracks.Clear();
            this.tracks.AddRange(ts);
            this.lbTracksDSte.Items.Clear();
            foreach (Track t in tracks) {
                this.lbTracksDSte.Items.Add(t.DisplayName);
            }
        }

        private void btnSaveSearchDSte_Click(object sender, EventArgs e) {
            String text = this.txbSearchDSte.Text.ToLower();
            List<Track> temp = new List<Track>();
            foreach (Track t in tracks) {
                if (t.DisplayName.ToLower().IndexOf(text) > -1) {
                    temp.Add(t);
                    temp[temp.Count - 1].DisplayName = temp.Count + ": " + temp[temp.Count - 1].SafeFileName;
                }
            }
            SaveTracksToFile(temp, manager.GetDefaultFileName());
        }
        #endregion

        #region util functions
        /// <summary>
        /// Missspelled function to convert a string to an int
        /// </summary>
        /// <param name="s">the string</param>
        /// <returns>an int</returns>
        private int toInteget(String s) {

            try {
                return Convert.ToInt32(s);
            }
            catch(FormatException e) {
                return int.MinValue;
            }
        }
        
        /// <summary>
        /// Removes the "(number): " from the song
        /// </summary>
        /// <param name="songname">the songname to remove the index from</param>
        /// <returns>The filename - the index</returns>
        private string StripIndex(String songname) {
            return regex.Split(songname)[0];
        }
        /// <summary>
        /// Gets the track index for a track
        /// </summary>
        /// <param name="songname">name of the track</param>
        /// <returns>the track index for a track</returns>
        private int getTrackIndex(String songname) {
            int i = 0;
            foreach (Track t in tracks) {
                if (t != null && t.SafeFileName != songname) {
                    i++;
                } else return i + 1;
            }
            return -1;
        }

        /// <summary>
        /// Shortcut to the other function
        /// </summary>
        /// <param name="i">the index of the track</param>
        private void PlayTrackFromIndex(int i) {
            PlayTrackFromIndex(i, false);
        }

        /// <summary>
        /// A function that plays a track from an index that we provide
        /// </summary>
        /// <param name="trackindex">The index of the track</param>
        /// <param name="stopOnFail">if we should stop playing tracks when we fail</param>
        private void PlayTrackFromIndex(int trackindex, bool stopOnFail) {
            try {
                Track t = this.tracks[trackindex];
                if (t != null) {
                    manager.PlaySong(
                        t.FileName
                    );
                    this.lbTracksDSte.SelectedIndex = trackindex;
                }
            }
            catch {
                if(stopOnFail)
                    manager.StopSong();
            }
        }
        
        private void SaveTracksToFile(List<Track> t, string file) {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt = ".tstore";
            dialog.FileName = file;
            dialog.Filter = fileFilter;
            if (dialog.ShowDialog() == DialogResult.OK) {
                manager.ExportList(t, dialog.FileName);
            }
        }
        #endregion

    }
}
