namespace ShowMeTheGame_15_mar_2018 {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbDSte = new System.Windows.Forms.RichTextBox();
            this.btnLoadRtbDSte = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbListDSte = new System.Windows.Forms.ListBox();
            this.btnLoadListDSte = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbSearchForDSte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearchItemsCountDSte = new System.Windows.Forms.Label();
            this.lbSearchDSte = new System.Windows.Forms.ListBox();
            this.btnLoadSearchDSte = new System.Windows.Forms.Button();
            this.adsfsadfas = new System.Windows.Forms.GroupBox();
            this.txbSelectDSte = new System.Windows.Forms.TextBox();
            this.lblSelectDSte = new System.Windows.Forms.Label();
            this.lblListSelected = new System.Windows.Forms.Label();
            this.lblRtbDSte = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.adsfsadfas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbDSte);
            this.groupBox1.Controls.Add(this.lblRtbDSte);
            this.groupBox1.Controls.Add(this.btnLoadRtbDSte);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RichTextBox";
            // 
            // rtbDSte
            // 
            this.rtbDSte.Location = new System.Drawing.Point(7, 50);
            this.rtbDSte.Name = "rtbDSte";
            this.rtbDSte.Size = new System.Drawing.Size(208, 347);
            this.rtbDSte.TabIndex = 1;
            this.rtbDSte.Text = "";
            this.rtbDSte.WordWrap = false;
            this.rtbDSte.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.rtbDSte_MouseDoubleClick);
            // 
            // btnLoadRtbDSte
            // 
            this.btnLoadRtbDSte.Location = new System.Drawing.Point(7, 20);
            this.btnLoadRtbDSte.Name = "btnLoadRtbDSte";
            this.btnLoadRtbDSte.Size = new System.Drawing.Size(75, 23);
            this.btnLoadRtbDSte.TabIndex = 0;
            this.btnLoadRtbDSte.Text = "Load";
            this.btnLoadRtbDSte.UseVisualStyleBackColor = true;
            this.btnLoadRtbDSte.Click += new System.EventHandler(this.btnLoadRtbDSte_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbListDSte);
            this.groupBox2.Controls.Add(this.lblListSelected);
            this.groupBox2.Controls.Add(this.btnLoadListDSte);
            this.groupBox2.Location = new System.Drawing.Point(240, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 425);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ListBox";
            // 
            // lbListDSte
            // 
            this.lbListDSte.FormattingEnabled = true;
            this.lbListDSte.Location = new System.Drawing.Point(7, 50);
            this.lbListDSte.Name = "lbListDSte";
            this.lbListDSte.Size = new System.Drawing.Size(208, 342);
            this.lbListDSte.TabIndex = 1;
            this.lbListDSte.SelectedIndexChanged += new System.EventHandler(this.lbListDSte_SelectedIndexChanged);
            // 
            // btnLoadListDSte
            // 
            this.btnLoadListDSte.Location = new System.Drawing.Point(6, 20);
            this.btnLoadListDSte.Name = "btnLoadListDSte";
            this.btnLoadListDSte.Size = new System.Drawing.Size(75, 23);
            this.btnLoadListDSte.TabIndex = 0;
            this.btnLoadListDSte.Text = "Load";
            this.btnLoadListDSte.UseVisualStyleBackColor = true;
            this.btnLoadListDSte.Click += new System.EventHandler(this.btnLoadListDSte_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbSearchForDSte);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblSearchItemsCountDSte);
            this.groupBox3.Controls.Add(this.lbSearchDSte);
            this.groupBox3.Controls.Add(this.btnLoadSearchDSte);
            this.groupBox3.Location = new System.Drawing.Point(467, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 352);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serch";
            // 
            // txbSearchForDSte
            // 
            this.txbSearchForDSte.Location = new System.Drawing.Point(72, 326);
            this.txbSearchForDSte.Name = "txbSearchForDSte";
            this.txbSearchForDSte.Size = new System.Drawing.Size(143, 20);
            this.txbSearchForDSte.TabIndex = 4;
            this.txbSearchForDSte.TextChanged += new System.EventHandler(this.txbSearchForDSte_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search for:";
            // 
            // lblSearchItemsCountDSte
            // 
            this.lblSearchItemsCountDSte.AutoSize = true;
            this.lblSearchItemsCountDSte.Location = new System.Drawing.Point(88, 28);
            this.lblSearchItemsCountDSte.Name = "lblSearchItemsCountDSte";
            this.lblSearchItemsCountDSte.Size = new System.Drawing.Size(16, 13);
            this.lblSearchItemsCountDSte.TabIndex = 2;
            this.lblSearchItemsCountDSte.Text = "...";
            // 
            // lbSearchDSte
            // 
            this.lbSearchDSte.FormattingEnabled = true;
            this.lbSearchDSte.Location = new System.Drawing.Point(7, 50);
            this.lbSearchDSte.Name = "lbSearchDSte";
            this.lbSearchDSte.Size = new System.Drawing.Size(208, 264);
            this.lbSearchDSte.TabIndex = 1;
            // 
            // btnLoadSearchDSte
            // 
            this.btnLoadSearchDSte.Location = new System.Drawing.Point(6, 19);
            this.btnLoadSearchDSte.Name = "btnLoadSearchDSte";
            this.btnLoadSearchDSte.Size = new System.Drawing.Size(75, 23);
            this.btnLoadSearchDSte.TabIndex = 0;
            this.btnLoadSearchDSte.Text = "Load";
            this.btnLoadSearchDSte.UseVisualStyleBackColor = true;
            this.btnLoadSearchDSte.Click += new System.EventHandler(this.btnLoadSearchDSte_Click);
            // 
            // adsfsadfas
            // 
            this.adsfsadfas.Controls.Add(this.txbSelectDSte);
            this.adsfsadfas.Controls.Add(this.lblSelectDSte);
            this.adsfsadfas.Location = new System.Drawing.Point(468, 371);
            this.adsfsadfas.Name = "adsfsadfas";
            this.adsfsadfas.Size = new System.Drawing.Size(220, 67);
            this.adsfsadfas.TabIndex = 1;
            this.adsfsadfas.TabStop = false;
            this.adsfsadfas.Text = "Select";
            // 
            // txbSelectDSte
            // 
            this.txbSelectDSte.Location = new System.Drawing.Point(9, 19);
            this.txbSelectDSte.Name = "txbSelectDSte";
            this.txbSelectDSte.Size = new System.Drawing.Size(100, 20);
            this.txbSelectDSte.TabIndex = 0;
            this.txbSelectDSte.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSelectDSte
            // 
            this.lblSelectDSte.AutoSize = true;
            this.lblSelectDSte.Location = new System.Drawing.Point(6, 42);
            this.lblSelectDSte.Name = "lblSelectDSte";
            this.lblSelectDSte.Size = new System.Drawing.Size(16, 13);
            this.lblSelectDSte.TabIndex = 2;
            this.lblSelectDSte.Text = "...";
            // 
            // lblListSelected
            // 
            this.lblListSelected.AutoSize = true;
            this.lblListSelected.Location = new System.Drawing.Point(6, 400);
            this.lblListSelected.Name = "lblListSelected";
            this.lblListSelected.Size = new System.Drawing.Size(16, 13);
            this.lblListSelected.TabIndex = 3;
            this.lblListSelected.Text = "...";
            // 
            // lblRtbDSte
            // 
            this.lblRtbDSte.AutoSize = true;
            this.lblRtbDSte.Location = new System.Drawing.Point(6, 400);
            this.lblRtbDSte.Name = "lblRtbDSte";
            this.lblRtbDSte.Size = new System.Drawing.Size(16, 13);
            this.lblRtbDSte.TabIndex = 3;
            this.lblRtbDSte.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.adsfsadfas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.adsfsadfas.ResumeLayout(false);
            this.adsfsadfas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbDSte;
        private System.Windows.Forms.Button btnLoadRtbDSte;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox adsfsadfas;
        private System.Windows.Forms.Button btnLoadListDSte;
        private System.Windows.Forms.ListBox lbListDSte;
        private System.Windows.Forms.TextBox txbSearchForDSte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSearchItemsCountDSte;
        private System.Windows.Forms.ListBox lbSearchDSte;
        private System.Windows.Forms.Button btnLoadSearchDSte;
        private System.Windows.Forms.TextBox txbSelectDSte;
        private System.Windows.Forms.Label lblSelectDSte;
        private System.Windows.Forms.Label lblListSelected;
        private System.Windows.Forms.Label lblRtbDSte;
    }
}

