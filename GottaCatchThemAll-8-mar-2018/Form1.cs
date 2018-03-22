using System;
using System.IO;
using System.Windows.Forms;

namespace GottaCatchThemAll_8_mar_2018 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        String[] forLoopArray = new String[10000];
        int arrayCounter = -1;

        private void btnForDSte_Click(object sender, EventArgs e) {
            this.rtbForDSte.Text = "";
            int start = ConvertToFuckingInt(this.txbForStartDSte.Text);
            int inc = ConvertToFuckingInt(this.txbForIncDSte.Text);
            int step = ConvertToFuckingInt(this.txbForStepDSte.Text);

            for(int i = 0; i <= step; i++) {
                this.rtbForDSte.AppendText(start + "\n");
                start += inc;
            }
        }

        private void btnWhileGODSte_Click(object sender, EventArgs e) {
            this.rtbWhileDSte.Text = "";
            int start = ConvertToFuckingInt(this.txbWhileStartDSte.Text);
            int inc = ConvertToFuckingInt(this.txbWhileIncDSte.Text);
            int step = ConvertToFuckingInt(this.txbWhileStepDSte.Text);

            int i = 0;
            while(i <= step) {
                this.rtbWhileDSte.AppendText(start + "\n");
                start += inc;
                i++;
            }
        }

        private void btnEachAddDSte_Click(object sender, EventArgs e) {
            forLoopArray[++arrayCounter] = this.txbEachItemDSte.Text;
            this.txbEachItemDSte.Text = "";
        }

        private void btnEachShowDSte_Click(object sender, EventArgs e) {
            this.rtbEachDSte.Text = "";
            foreach (String item in forLoopArray) {
                if(!String.IsNullOrWhiteSpace(item))
                    this.rtbEachDSte.AppendText(item + "\n");
            }
        }

        private void btnPoAddDSte_Click(object sender, EventArgs e) {
            String input = this.txbPoPoDSte.Text;
            String type = this.txbPoTypeDSte.Text;

            if (!File.Exists("pokemon.txt"))
                File.Create("pokemon.txt").Close();

            String forFile = "Pokemon: " + input + ", Type: " + type;
            StreamWriter writer = new StreamWriter("pokemon.txt", true);
            writer.WriteLine(forFile);
            writer.Flush();
            writer.Close();

            this.txbPoPoDSte.Text = "";
            this.txbPoTypeDSte.Text = "";
        }

        private void btnPoShowDSte_Click(object sender, EventArgs e) {
            this.rtbPoDSte.Text = "";
            this.rtbPoDSte.AppendText(new StreamReader("pokemon.txt").ReadToEnd());
        }

        private int ConvertToFuckingInt(String s) {
            try {
                return Convert.ToInt32(s);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (FormatException ignored) {
#pragma warning restore CS0168 // Variable is declared but never used
                return 1;
            }
        }
    }
}
