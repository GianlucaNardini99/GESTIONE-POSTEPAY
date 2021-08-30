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
    public partial class ClientPage : Form
    {
        // here we have all the information that are usefull for ClientPage
        public ClientPage(Client c)
        {
            InitializeComponent();
            this.tbName.Text = c.Name;
            this.tbSurname.Text = c.Surname;
            this.dtpBirthdateDay.Value = c.BirthdayDate;
            this.tbSex.Text = c.Sex;
            this.tbBirthPlace.Text = c.BirthPlace;
            this.tbTelNumber.Text = c.TelNumber;
            this.tbCardNumber.Text = c.CardNumber;
        }

        // method that close the ClientPage
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
