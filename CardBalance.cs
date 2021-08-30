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
    public partial class CardBalance : Form
    {
        public Client client { get; set; }
        public CardBalance(Client c)
        {
            InitializeComponent();
            this.client = c;
            // this instruction sets the minimum date by invoking the method LastDate,
            // thus we can't select a date in the past and the lists are ordered
            this.dtpDate.MinDate = c.LastDate(c.DateList);
        }

        // method that adds new balance of the card for a client
        private void btnOk_Click(object sender, EventArgs e)
        {
            client.EuroList.Add(float.Parse(tbAmount.Text));
            client.DateList.Add(dtpDate.Value);
            Close();
        }

        // method that close the window of the card balance
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // method that blocks wrong input
        internal void HandleInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == ',');
        }
    }
}
