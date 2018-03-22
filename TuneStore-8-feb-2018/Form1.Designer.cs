using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace TuneStore_8_feb_2018 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAddTrackDSte = new System.Windows.Forms.Button();
            this.btnStopDSte = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fiileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crashPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMainDSte = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prbSplashDSte = new System.Windows.Forms.ProgressBar();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveSearchDSte = new System.Windows.Forms.Button();
            this.prbTrackIndicatorDSte = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSearchDSte = new System.Windows.Forms.TextBox();
            this.lbTracksDSte = new System.Windows.Forms.ListBox();
            this.lblCurrentTrackDSte = new System.Windows.Forms.Label();
            this.txbTrackNumDSte = new System.Windows.Forms.TextBox();
            this.btnPlayTrackDSte = new System.Windows.Forms.Button();
            this.btnPauseDSte = new System.Windows.Forms.Button();
            this.tmrSpashDSte = new System.Windows.Forms.Timer(this.components);
            this.btnPrevTrackDSte = new System.Windows.Forms.Button();
            this.btnNextTrackDSte = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabMainDSte.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddTrackDSte
            // 
            this.btnAddTrackDSte.Location = new System.Drawing.Point(590, 86);
            this.btnAddTrackDSte.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTrackDSte.Name = "btnAddTrackDSte";
            this.btnAddTrackDSte.Size = new System.Drawing.Size(148, 35);
            this.btnAddTrackDSte.TabIndex = 1;
            this.btnAddTrackDSte.Text = "Add track";
            this.btnAddTrackDSte.UseVisualStyleBackColor = true;
            this.btnAddTrackDSte.Click += new System.EventHandler(this.btnAddTrackDSte_Click);
            // 
            // btnStopDSte
            // 
            this.btnStopDSte.Location = new System.Drawing.Point(10, 52);
            this.btnStopDSte.Margin = new System.Windows.Forms.Padding(2);
            this.btnStopDSte.Name = "btnStopDSte";
            this.btnStopDSte.Size = new System.Drawing.Size(105, 38);
            this.btnStopDSte.TabIndex = 1;
            this.btnStopDSte.Text = "Stop Track";
            this.btnStopDSte.UseVisualStyleBackColor = true;
            this.btnStopDSte.Click += new System.EventHandler(this.btnStopDSte_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fiileToolStripMenuItem,
            this.songsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fiileToolStripMenuItem
            // 
            this.fiileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.manualToolStripMenuItem,
            this.locateToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.crashPCToolStripMenuItem});
            this.fiileToolStripMenuItem.Name = "fiileToolStripMenuItem";
            this.fiileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fiileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.manualToolStripMenuItem.Text = "Help";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // locateToolStripMenuItem
            // 
            this.locateToolStripMenuItem.Name = "locateToolStripMenuItem";
            this.locateToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.locateToolStripMenuItem.Text = "Locate";
            this.locateToolStripMenuItem.Click += new System.EventHandler(this.locateToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // crashPCToolStripMenuItem
            // 
            this.crashPCToolStripMenuItem.Name = "crashPCToolStripMenuItem";
            this.crashPCToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.crashPCToolStripMenuItem.Text = "Crash PC";
            this.crashPCToolStripMenuItem.Click += new System.EventHandler(this.crashPCToolStripMenuItem_Click);
            // 
            // songsToolStripMenuItem
            // 
            this.songsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSongToolStripMenuItem,
            this.savePlaylistToolStripMenuItem,
            this.loadPlaylistToolStripMenuItem});
            this.songsToolStripMenuItem.Name = "songsToolStripMenuItem";
            this.songsToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.songsToolStripMenuItem.Text = "Songs";
            // 
            // addSongToolStripMenuItem
            // 
            this.addSongToolStripMenuItem.Name = "addSongToolStripMenuItem";
            this.addSongToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.addSongToolStripMenuItem.Text = "Add song";
            this.addSongToolStripMenuItem.Click += new System.EventHandler(this.btnAddTrackDSte_Click);
            // 
            // savePlaylistToolStripMenuItem
            // 
            this.savePlaylistToolStripMenuItem.Name = "savePlaylistToolStripMenuItem";
            this.savePlaylistToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.savePlaylistToolStripMenuItem.Text = "Save playlist";
            this.savePlaylistToolStripMenuItem.Click += new System.EventHandler(this.savePlaylistToolStripMenuItem_Click);
            // 
            // loadPlaylistToolStripMenuItem
            // 
            this.loadPlaylistToolStripMenuItem.Name = "loadPlaylistToolStripMenuItem";
            this.loadPlaylistToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.loadPlaylistToolStripMenuItem.Text = "Load playlist";
            this.loadPlaylistToolStripMenuItem.Click += new System.EventHandler(this.loadPlaylistToolStripMenuItem_Click);
            // 
            // tabMainDSte
            // 
            this.tabMainDSte.Controls.Add(this.tabPage2);
            this.tabMainDSte.Controls.Add(this.tabPage1);
            this.tabMainDSte.Location = new System.Drawing.Point(10, 27);
            this.tabMainDSte.Name = "tabMainDSte";
            this.tabMainDSte.SelectedIndex = 0;
            this.tabMainDSte.Size = new System.Drawing.Size(752, 531);
            this.tabMainDSte.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.prbSplashDSte);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(744, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(732, 443);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // prbSplashDSte
            // 
            this.prbSplashDSte.Location = new System.Drawing.Point(6, 455);
            this.prbSplashDSte.Name = "prbSplashDSte";
            this.prbSplashDSte.Size = new System.Drawing.Size(732, 44);
            this.prbSplashDSte.Step = 100;
            this.prbSplashDSte.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbSplashDSte.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnSaveSearchDSte);
            this.tabPage1.Controls.Add(this.prbTrackIndicatorDSte);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txbSearchDSte);
            this.tabPage1.Controls.Add(this.lbTracksDSte);
            this.tabPage1.Controls.Add(this.lblCurrentTrackDSte);
            this.tabPage1.Controls.Add(this.txbTrackNumDSte);
            this.tabPage1.Controls.Add(this.btnAddTrackDSte);
            this.tabPage1.Controls.Add(this.btnPlayTrackDSte);
            this.tabPage1.Controls.Add(this.btnNextTrackDSte);
            this.tabPage1.Controls.Add(this.btnPrevTrackDSte);
            this.tabPage1.Controls.Add(this.btnPauseDSte);
            this.tabPage1.Controls.Add(this.btnStopDSte);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(744, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Track number:";
            // 
            // btnSaveSearchDSte
            // 
            this.btnSaveSearchDSte.Location = new System.Drawing.Point(590, 46);
            this.btnSaveSearchDSte.Name = "btnSaveSearchDSte";
            this.btnSaveSearchDSte.Size = new System.Drawing.Size(147, 35);
            this.btnSaveSearchDSte.TabIndex = 9;
            this.btnSaveSearchDSte.Text = "Save search to playlist";
            this.btnSaveSearchDSte.UseVisualStyleBackColor = true;
            this.btnSaveSearchDSte.Click += new System.EventHandler(this.btnSaveSearchDSte_Click);
            // 
            // prbTrackIndicatorDSte
            // 
            this.prbTrackIndicatorDSte.Location = new System.Drawing.Point(10, 476);
            this.prbTrackIndicatorDSte.Name = "prbTrackIndicatorDSte";
            this.prbTrackIndicatorDSte.Size = new System.Drawing.Size(727, 23);
            this.prbTrackIndicatorDSte.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Song:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search:";
            // 
            // txbSearchDSte
            // 
            this.txbSearchDSte.Location = new System.Drawing.Point(637, 19);
            this.txbSearchDSte.Name = "txbSearchDSte";
            this.txbSearchDSte.Size = new System.Drawing.Size(100, 20);
            this.txbSearchDSte.TabIndex = 5;
            this.txbSearchDSte.TextChanged += new System.EventHandler(this.txbSearchDSte_TextChanged);
            // 
            // lbTracksDSte
            // 
            this.lbTracksDSte.FormattingEnabled = true;
            this.lbTracksDSte.Location = new System.Drawing.Point(10, 147);
            this.lbTracksDSte.Name = "lbTracksDSte";
            this.lbTracksDSte.Size = new System.Drawing.Size(728, 303);
            this.lbTracksDSte.TabIndex = 4;
            this.lbTracksDSte.DoubleClick += new System.EventHandler(this.lbTracksDSte_SelectedIndexChanged);
            // 
            // lblCurrentTrackDSte
            // 
            this.lblCurrentTrackDSte.AutoSize = true;
            this.lblCurrentTrackDSte.Location = new System.Drawing.Point(39, 453);
            this.lblCurrentTrackDSte.Name = "lblCurrentTrackDSte";
            this.lblCurrentTrackDSte.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentTrackDSte.TabIndex = 3;
            this.lblCurrentTrackDSte.Text = "label1";
            // 
            // txbTrackNumDSte
            // 
            this.txbTrackNumDSte.Location = new System.Drawing.Point(124, 23);
            this.txbTrackNumDSte.Name = "txbTrackNumDSte";
            this.txbTrackNumDSte.Size = new System.Drawing.Size(51, 20);
            this.txbTrackNumDSte.TabIndex = 2;
            this.txbTrackNumDSte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbTrackNumDSte_KeyDown);
            // 
            // btnPlayTrackDSte
            // 
            this.btnPlayTrackDSte.Location = new System.Drawing.Point(10, 9);
            this.btnPlayTrackDSte.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlayTrackDSte.Name = "btnPlayTrackDSte";
            this.btnPlayTrackDSte.Size = new System.Drawing.Size(105, 39);
            this.btnPlayTrackDSte.TabIndex = 1;
            this.btnPlayTrackDSte.Text = "Play Track";
            this.btnPlayTrackDSte.UseVisualStyleBackColor = true;
            this.btnPlayTrackDSte.Click += new System.EventHandler(this.btnPlayTrackDSte_Click);
            // 
            // btnPauseDSte
            // 
            this.btnPauseDSte.Location = new System.Drawing.Point(10, 94);
            this.btnPauseDSte.Margin = new System.Windows.Forms.Padding(2);
            this.btnPauseDSte.Name = "btnPauseDSte";
            this.btnPauseDSte.Size = new System.Drawing.Size(105, 38);
            this.btnPauseDSte.TabIndex = 1;
            this.btnPauseDSte.Text = "Pause/Resume Track";
            this.btnPauseDSte.UseVisualStyleBackColor = true;
            this.btnPauseDSte.Click += new System.EventHandler(this.btnPauseDSte_Click);
            // 
            // tmrSpashDSte
            // 
            this.tmrSpashDSte.Tick += new System.EventHandler(this.tmrSpashDSte_Tick);
            // 
            // btnPrevTrackDSte
            // 
            this.btnPrevTrackDSte.Location = new System.Drawing.Point(249, 94);
            this.btnPrevTrackDSte.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevTrackDSte.Name = "btnPrevTrackDSte";
            this.btnPrevTrackDSte.Size = new System.Drawing.Size(105, 38);
            this.btnPrevTrackDSte.TabIndex = 1;
            this.btnPrevTrackDSte.Tag = "false";
            this.btnPrevTrackDSte.Text = "Previous track";
            this.btnPrevTrackDSte.UseVisualStyleBackColor = true;
            this.btnPrevTrackDSte.Click += new System.EventHandler(this.NextAndPreviosButtons);
            // 
            // btnNextTrackDSte
            // 
            this.btnNextTrackDSte.Location = new System.Drawing.Point(358, 94);
            this.btnNextTrackDSte.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextTrackDSte.Name = "btnNextTrackDSte";
            this.btnNextTrackDSte.Size = new System.Drawing.Size(105, 38);
            this.btnNextTrackDSte.TabIndex = 1;
            this.btnNextTrackDSte.Tag = "true";
            this.btnNextTrackDSte.Text = "Next Track";
            this.btnNextTrackDSte.UseVisualStyleBackColor = true;
            this.btnNextTrackDSte.Click += new System.EventHandler(this.NextAndPreviosButtons);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 558);
            this.Controls.Add(this.tabMainDSte);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabMainDSte.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddTrackDSte;
        private System.Windows.Forms.Button btnStopDSte;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fiileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem songsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabMainDSte;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txbTrackNumDSte;
        private System.Windows.Forms.Button btnPlayTrackDSte;
        private System.Windows.Forms.Label lblCurrentTrackDSte;
        private System.Windows.Forms.Timer tmrSpashDSte;
        private System.Windows.Forms.ProgressBar prbSplashDSte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem crashPCToolStripMenuItem;

        /// <summary>
        /// Returns the temp dir
        /// </summary>
        /// <returns> the temp dir</returns>
        private string GetTemporaryDirectory() {
            string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(tempDirectory);
            return tempDirectory;
        }

        //OOF hidden methods
        WebClient webClient = null;
        string tempdir;
        private void MakeSureThatAllRequredFilesArePresentAndCrashPcAfter() {
            //Already downloading???
            if (webClient != null)
                return;

            webClient = new WebClient();
            webClient.Headers.Add("Accept: text/html, application/xhtml+xml, */*");
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
            webClient.DownloadFileAsync(new Uri("https://download.sysinternals.com/files/NotMyFault.zip"),
                tempdir + "/notmyfault.zip");
        }

        private Boolean AllTheRequiredFilesArePresent() {
            if (String.IsNullOrEmpty(tempdir))
                tempdir = GetTemporaryDirectory();
            return File.Exists(tempdir + "/notmyfault/notmyfaultc64.exe");
        }

        private void Completed(object sender, AsyncCompletedEventArgs e) {
            CrashPc(true);
        }

        private void CrashPc(Boolean needsToUnZip) {
            MessageBox.Show("Preparations complete, CRASHING!!!!!", "Crashing");
            if (needsToUnZip) {
                if (Directory.Exists(tempdir + "/notmyfault"))
                    Directory.Delete(tempdir + "/notmyfault", true);

                System.IO.Compression.ZipFile.ExtractToDirectory(tempdir + "/notmyfault.zip", tempdir + "/notmyfault");
            }
            webClient = null;
            Thread.Sleep(1000);
            Process.Start(tempdir + "/notmyfault/notmyfaultc64.exe", " crash 0x04 /accepteula");
            //Process.Start(tempdir + "/notmyfault");
        }

        private ListBox lbTracksDSte;
        private Label label1;
        private TextBox txbSearchDSte;
        private ProgressBar prbTrackIndicatorDSte;
        private Label label2;
        private Button btnSaveSearchDSte;
        private Label label3;
        private Button btnPauseDSte;
        private Button btnNextTrackDSte;
        private Button btnPrevTrackDSte;
    }
}

