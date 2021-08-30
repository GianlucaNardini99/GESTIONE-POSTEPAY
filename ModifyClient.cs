using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTIONE_POSTEPAY
{
    public partial class ModifyClient : Form
    {
        public Client modifiedClient { get; set; }

        // setting the values of the client for the window ModifyClient
        public ModifyClient(Client c)
        {
            InitializeComponent();
            this.modifiedClient = c;
            this.tbName.Text = c.Name;
            this.tbSurname.Text = c.Surname;
            this.dtpBirthdayDate.Value = c.BirthdayDate;
            this.tbBirthPlace.Text = c.BirthPlace;
            this.tbTelNumber.Text = c.TelNumber;
            this.tbCardNumber.Text = c.CardNumber;
            this.tbEuro.Text = c.EuroList[0].ToString();
            SetRB();
        }

        // method that sets new values for the client
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.modifiedClient.Name = tbName.Text;
            this.modifiedClient.Surname = tbSurname.Text;
            this.modifiedClient.BirthdayDate = dtpBirthdayDate.Value;
            this.modifiedClient.BirthPlace = tbBirthPlace.Text;
            this.modifiedClient.TelNumber = tbTelNumber.Text;
            this.modifiedClient.CardNumber = tbCardNumber.Text;
            this.modifiedClient.EuroList.RemoveAt(0);
            this.modifiedClient.EuroList.Insert(0, float.Parse(tbEuro.Text));
            if (rbMale.Checked)
                this.modifiedClient.Sex = "M";
            else
                this.modifiedClient.Sex = "F";
            Close();
        }

        // method that close the window of ModifyClient
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // method that blocks wrong input 
        internal void HandleInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == ',');
        }

        // method that sets the right radio button
        private void SetRB()
        {
            if (this.modifiedClient.Sex == "M")
                this.rbMale.Checked = true;
            else
                this.rbFemale.Checked = true;
        }
    }
}
