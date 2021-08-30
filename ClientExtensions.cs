using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTIONE_POSTEPAY.Extensions
{
    public static class ClientExtensions
    {
        public static ListViewItem ToListViewItem(this Client client)
        {
            string[] row = { client.Name, client.Surname, client.CardNumber, client.LastEuro(client.EuroList).ToString()+" €"};
            return new ListViewItem(row);
        }
    }
}
