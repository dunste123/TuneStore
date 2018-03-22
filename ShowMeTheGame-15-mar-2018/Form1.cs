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

namespace ShowMeTheGame_15_mar_2018 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            this.Text = "ShowMeTheGame";
        }

        private void btnLoadRtbDSte_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK) {
                return;
            }
            this.rtbDSte.Text = new StreamReader(dialog.FileName).ReadToEnd();
        }

        private void btnLoadListDSte_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK) {
                return;
            }
            this.lbListDSte.Items.Clear();
            StreamReader reader = new StreamReader(dialog.FileName);
            while(!reader.EndOfStream) {
                this.lbListDSte.Items.Add(reader.ReadLine());
            }
        }

        List<String> searchList = new List<String>();
        private void btnLoadSearchDSte_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK) {
                return;
            }
            this.lbSearchDSte.Items.Clear();
            StreamReader reader = new StreamReader(dialog.FileName);
            while (!reader.EndOfStream) {
                searchList.Add(searchList.Count + 1 + " " + reader.ReadLine());
            }
            this.lblSearchItemsCountDSte.Text = searchList.Count + " Items loaded";
            this.lbSearchDSte.Items.AddRange(searchList.ToArray());
        }

        private void txbSearchForDSte_TextChanged(object sender, EventArgs e) {
            String text = this.txbSearchForDSte.Text.ToLower();
            List<String> temp = new List<string>();

            foreach(String item in searchList) {
                if(item.ToLower().IndexOf(text) > -1) {
                    temp.Add(item);
                }
            }
            this.lbSearchDSte.Items.Clear();
            this.lbSearchDSte.Items.AddRange(temp.ToArray());
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            int ind = ConvertToFuckingInt(this.txbSelectDSte.Text) - 1;

            if (ind < 0) return;
            try {
                this.lbSearchDSte.SelectedIndex = ind;
                this.lblSelectDSte.Text = this.lbSearchDSte.SelectedItem.ToString();
            }
            catch { }
        }

        private int ConvertToFuckingInt(String s) {
            try {
                return Convert.ToInt32(s);
            }
            catch {
                return 0;
            }
        }

        private void lbListDSte_SelectedIndexChanged(object sender, EventArgs e) {
            this.lblListSelected.Text = this.lbListDSte.SelectedItem.ToString();
        }

        private void rtbDSte_MouseDoubleClick(object sender, MouseEventArgs e) {
            try {
                String songName = this.rtbDSte.Lines[
                            this.rtbDSte.GetLineFromCharIndex(
                                this.rtbDSte.SelectionStart
                            )
                        ];
                this.lblRtbDSte.Text = songName;
            }
            catch { }
        }
    }
}
