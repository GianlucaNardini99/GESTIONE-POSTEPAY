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
    public partial class NewClient : Form
    {
        public List<Client> clients { get; set; }
        private String sex;

        // method for the creation of a new client
        public NewClient(List<Client> clients)
        {
            InitializeComponent();
            this.clients = clients;
            this.sex = null;
        }

        // method for the real creation of a new client
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                CheckRB();
                AddClient();
                Close();
            }
            else
            {
                MessageBox.Show("ERRORE! Uno o più campi non sono stati compilati!");
            }
        }

        // method that close the window of NewClient
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // method that adds the client to the clients list and the "now" in the datelist
        private void AddClient()
        {
            var client = new Client(tbName.Text, tbSurname.Text, dtpBirthdateDay.Value, sex,
                        tbBirthPlace.Text, tbTelNumber.Text, tbCardNumber.Text, float.Parse(tbEuro.Text));
            clients.Add(client);
            client.DateList.Add(DateTime.Now);
        }

        // method that checks fields
        private bool CheckFields()
        {
            return !string.IsNullOrEmpty(tbName.Text) &&
                   !string.IsNullOrEmpty(tbSurname.Text) &&
                   !string.IsNullOrEmpty(tbBirthPlace.Text) &&
                   !string.IsNullOrEmpty(tbTelNumber.Text) &&
                   !string.IsNullOrEmpty(tbCardNumber.Text) &&
                   !string.IsNullOrEmpty(tbEuro.Text) &&
                   (rbMale.Checked || rbFemale.Checked);
        }

        // method that checks the radio button
        private void CheckRB()
        {
            if (rbMale.Checked)
                sex = "M";
            else
                sex = "F";
            
        }

        // method that blocks wrong input
        internal void HandleInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == ',');
        }
    }
}
