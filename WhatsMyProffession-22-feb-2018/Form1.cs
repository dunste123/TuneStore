using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsMyProffession_22_feb_2018 {
    public partial class Form1 : Form {

        Person[] peepz = new Person[100];

        public Form1() {
            InitializeComponent();
            setIndex(0);

        }

        private void btnSavePersonDSte_Click(object sender, EventArgs e) {
            String fname = this.txbFirstNameDSte.Text;
            String lname = this.txbLastNameDSte.Text;
            String salText = this.txbSaleryDSte.Text;

            if(fname == "" || lname == "" || salText == "") {
                MessageBox.Show("Please enter stuff", "No U");
                return;
            }

            int sal = StrToInt(salText);

            int ind = getIndex();

            peepz[ind] = new Person();

            peepz[ind].Id = ind + 1;
            peepz[ind].FirstName = fname;
            peepz[ind].LastName = lname;
            peepz[ind].Salary = sal;

            if(ind < 100)
                setIndex(ind + 1);
            else
                MessageBox.Show("I'm full, can't add more peepz");

            this.txbFirstNameDSte.Text = "";
            this.txbLastNameDSte.Text = "";
            this.txbSaleryDSte.Text = "";
        }


        public int StrToInt(String number) {
            try {
                return Convert.ToInt32(number);
            }
            catch (Exception e) {
                MessageBox.Show("That is not a valid number", "NO U");
                return 0;
            }

        }

        private void setIndex(int num) {
            this.lblPersonIdDSte.Text = num + 1 + "";
            this.lblPersonIdDSte.Tag = num;
        }

        private int getIndex() {
            return (int)this.lblPersonIdDSte.Tag;
        }

        private void btnGetPersonDSte_Click(object sender, EventArgs e) {
            this.rtbPersonDisplay.Text = "";
            //Needs a better name
            String asdfa = this.txbPersonNumberDSte.Text;

            if (asdfa == "") {
                MessageBox.Show("Please enter a number", "No u");
                return;
            }

            int id = StrToInt(asdfa);

            Person p = peepz[id];

            if (p != null) {
                this.rtbPersonDisplay.Text += "ID: " + p.Id + "\n";
                this.rtbPersonDisplay.Text += "First Name: " + p.FirstName + "\n";
                this.rtbPersonDisplay.Text += "Last Name: " + p.LastName + "\n";
                this.rtbPersonDisplay.Text += "Salery: " + p.Salary + "\n";
            } else {
                MessageBox.Show("No person found");
            }
        }
    }
}
