using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuneStore_8_feb_2018 {
    class AudioManager {

        private SoundPlayer Player;
        private Label Label = null;
        int songLength = 0;
        private ProgressBar progress = null;
        private Timer trackTimer = new Timer();
        private String songName = "";

        /// <summary>
        /// This creates a new audio manager insance
        /// </summary>
        public AudioManager() {
            this.Player = new SoundPlayer();

            //Set up timer
            this.trackTimer.Tick += new EventHandler(this.trackTimer_tick);
            this.trackTimer.Interval = 10;
        }

        /// <summary>
        /// This sets the label to display the song name in
        /// </summary>
        /// <param name="label">the label on your form</param>
        /// <returns>The audio manager, useful for chaining</returns>
        public AudioManager SetLabel(Label label) {
            this.Label = label;
            return this;
        }

        /// <summary>
        /// This sets the progress bar that should display the track lengh
        /// </summary>
        /// <param name="bar">The form element</param>
        /// <returns>The audio manager, useful for chaining</returns>
        public AudioManager SetProgressBar(ProgressBar bar) {
            this.progress = bar;
            return this;
        }

        /// <summary>
        /// Holds the name of the currently playing song or last playing song if the player is stopped
        /// </summary>
        public String SongName { get => songName; }

        /// <summary>
        /// This plays a song on the player and stops it first
        /// </summary>
        /// <param name="path">the path to the file</param>
        /// <param name="audioFile">The location of the audio file</param>
        public void PlaySong(String path, String audioFile) {
            StopSong();
            if (this.Label != null) {
                string[] split = audioFile.Split('\\');
                songName = split[split.Length - 1];
                this.Label.Text = songName + " [Playing]";
            }
            
            PlayAudio(path + audioFile);
        }

        /// <summary>
        /// This plays a song on the player and stops it first
        /// </summary>
        /// <param name="audioFile">The location of the audio file</param>
        public void PlaySong(String audioFile) {
            this.PlaySong("", audioFile);
        }

        /// <summary>
        /// This stops the song that is currently playing
        /// </summary>
        public void StopSong() {

            if (this.Label != null)
                this.Label.Text = "";

            StopAudio();
        }

        /// <summary>
        /// Pauses the song if playing
        /// Resumes the song if paused
        /// </summary>
        public void PauseUnpauseSong() {
            PauseUnpauseAudio();
        }

        /// <summary>
        /// This stops the player and removes it
        /// WARNING: you won't be able to use the player after you called this method
        /// </summary>
        public void Destroy() {
            StopSong();
            this.Player.Dispose();
            this.Player = null;
        }

        #region audio handeling code
        //Start default audio handling code
        //None of this is my code, all credit for this code goes to Jbra
        //dll import to add audio
        [DllImport("winmm.dll")]

        private static extern long mciSendString(
        string strCommand,
        StringBuilder strReturn,
        int iReturnLength,
        IntPtr hwndCallback);

        private void PlayAudio(String fileName) {
            //play audio
            mciSendString("open \"" +
                            fileName
                            + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);

            mciSendString("play MediaFile", null, 0, IntPtr.Zero);
            CalculateLength();
            this.trackTimer.Start();
        }

        private void StopAudio() {
            songLength = 0;
            SetProgressValue(0);
            //Stop audio if audio already played
            mciSendString("close MediaFile", null, 0, IntPtr.Zero);
            this.trackTimer.Stop();
        }

        private void PauseUnpauseAudio() {
            StringBuilder audioStatus = new StringBuilder(128);
            mciSendString("status MediaFile mode", audioStatus, 128, IntPtr.Zero);

            if(audioStatus.ToString().Equals("playing")) {
                mciSendString("pause MediaFile", null, 0, IntPtr.Zero);
                this.Label.Text = songName + " [Paused]";
            } else {
                mciSendString("resume MediaFile", null, 0, IntPtr.Zero);
                this.Label.Text = songName + " [Playing]";
            }
        }

        //End default audio handling code

        /// <summary>
        /// Calculates the song length
        /// </summary>
        private void CalculateLength() {
            StringBuilder m_songLengthAsString = new StringBuilder(128);

            mciSendString("status MediaFile length", m_songLengthAsString, 128, IntPtr.Zero);

            songLength = Convert.ToInt32(Convert.ToString(m_songLengthAsString));

            SetProgressMax(Convert.ToInt32(songLength));
        }

        /// <summary>
        /// Gets the playing posistion of the song and sets it in the progress bar
        /// </summary>
        private void GetSongPosition() {
            int m_songPosition;

            StringBuilder m_songPositionAsString = new StringBuilder(128);

            mciSendString("status MediaFile position", m_songPositionAsString, 128, IntPtr.Zero);

            m_songPosition = Convert.ToInt32(Convert.ToString(m_songPositionAsString));

            SetProgressValue(m_songPosition);
        }
        #endregion

        /// <summary>
        /// Sets the max value of the progress bar
        /// 
        /// it also checks if the progressbar isn't null
        /// </summary>
        /// <param name="value">The max value of the progressbar</param>
        private void SetProgressMax(int value) {
            if (this.progress != null)
                progress.Maximum = value;
        }

        /// <summary>
        /// Sets the value of the progressbar
        /// 
        /// it also checks if the progressbar isn't null
        /// </summary>
        /// <param name="val">The value for the progressbar</param>
        private void SetProgressValue(int val) {
            if (this.progress != null)
                progress.Value = val;
        }

        private void trackTimer_tick(object sender, EventArgs e) {
            GetSongPosition();
            StringBuilder trackStatus = new StringBuilder(128);

            mciSendString("status MediaFile mode", trackStatus, 128, IntPtr.Zero);

            if(trackStatus.ToString().Equals("stopped")) {
                this.trackTimer.Stop();
                NextSongEvent.Invoke(this, null);
            }
        }

        #region playlist saving / loading
        /// <summary>
        /// this generates a filename for the playlist
        /// </summary>
        /// <returns>A filename for the tunestore playlist</returns>
        public String GetDefaultFileName() {
            return "TuneStorePlaylist-" + DateTime.Now.ToString("MM-dd-yyyy_hh-mm-ss") + ".tstore";
        }

        /// <summary>
        /// This exports the playlist to a file
        /// </summary>
        /// <param name="playlist">The current playlsit</param>
        /// <param name="filename">The file (path) to write to</param>
        public void ExportList(List<Track> playlist, String filename) {
            //
            String json = JsonConvert.SerializeObject(playlist);
            //String filename = "TuneStorePlaylist-" + DateTime.Now.ToString("MM-dd-yyyy_hh-mm-ss") + ".tstore";
            if (!File.Exists(filename))
                File.Create(filename).Close();
            
            StreamWriter writer = new StreamWriter(filename, false);
            writer.WriteLine(json);
            writer.Flush();
            writer.Close();
        }

        /// <summary>
        /// Generates a list with tracks from the json playlist
        /// </summary>
        /// <param name="json">The playlist converted to json</param>
        /// <returns>A possible null list with the tracks</returns>
        public List<Track> ImportList(String json) {
            try {
                List<Track> tracks = JsonConvert.DeserializeObject<List<Track>>(json); //I think that it's goldplating because I'm using an external lib
                return tracks;
            }
            catch(JsonSerializationException ex) {
                return null;
            }
        }
        #endregion

        /// <summary>
        /// An event that is ran when we need to request a new song
        /// 
        /// NOTE: the "sender" object is an instance of the AudioManager
        /// </summary>
        public EventHandler NextSongEvent;
    }
}
