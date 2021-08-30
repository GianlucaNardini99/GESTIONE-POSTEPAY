using GESTIONE_POSTEPAY.Extensions;
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
    public partial class MainPage : Form
    {
        private List<Client> clients;
        private ListViewItem clientItem;
        // variable index used for the insertion of the client in the listview in the right line
        private int index;
        private DBclass dbHandler;

        public MainPage()
        {
            InitializeComponent();
            this.clients = new List<Client>();
            // instruction related to the singleton pattern
            dbHandler = DBclass.GetInstance();
            // loading of the DB
            LoadDB();
            // index is initialized with the number of the clients present in the list with the loading of the DB
            this.index = clients.Count;
            // with the exit from the application, a method is invoked and allows to save data in the DB
            Application.ApplicationExit += new EventHandler(FinalSaveData);
        }

        // method that reads the DB and inserts clients in the listview
        private void LoadDB()
        {
            clients = dbHandler.GetData();
            for(int i = 0; i < clients.Count; i++)
            {
                clientItem = new ListViewItem();
                clientItem = clients[i].ToListViewItem();
                listViewClients.Items.Add(clientItem);
            }
        }

        // method that save data into the DB
        private void FinalSaveData(object sender, EventArgs e)
        {
            dbHandler.SaveData(clients);
        }

        // method used to create a new client and allows to show the window NewClient
        private void btnNew_Click(object sender, EventArgs e)
        {
            NewClient NewClientForm = new NewClient(clients);
            NewClientForm.ShowDialog();
            if (NewClientForm.clients.Count != index)
            {
                clients = NewClientForm.clients;
                clientItem = new ListViewItem();
                clientItem = clients[index].ToListViewItem();
                listViewClients.Items.Add(clientItem);
                index++;
            }
        }

        // method that allows to modify some fields of the selected client
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (listViewClients.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleziona un cliente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int editIndex;
                ModifyClient ModifyClientForm = new ModifyClient(clients[listViewClients.SelectedIndices[0]]);
                ModifyClientForm.ShowDialog();
                editIndex = listViewClients.SelectedItems[0].Index;
                clients.RemoveAt(editIndex);
                listViewClients.Items.RemoveAt(editIndex);
                clients.Insert(editIndex, ModifyClientForm.modifiedClient);
                listViewClients.Items.Insert(editIndex, ModifyClientForm.modifiedClient.ToListViewItem());
            }
        }

        // method that allows to remove a selected client
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (listViewClients.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleziona un cliente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Il cliente verrà rimosso, sei sicuro?", "Conferma", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    clients.Remove(clients[listViewClients.SelectedIndices[0]]);
                    listViewClients.Items.Remove(listViewClients.SelectedItems[0]);
                    chartMovement.Series[0].Points.Clear();
                    index--;
                }
            }
        }

        // method that allows to show the window ClientPage with all the information of the client
        private void btnClient_Click(object sender, EventArgs e)
        {
            if (listViewClients.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Selezionare un cliente", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ClientPage ClientPageForm = new ClientPage(clients[listViewClients.SelectedIndices[0]]);
                ClientPageForm.ShowDialog();
            }
        }

        // method that allows to show the window CardBalance and add the balance of the card in a certain date
        private void btnBalance_Click(object sender, EventArgs e)
        {
            if (listViewClients.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleziona un cliente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int editIndex;
                CardBalance Movement = new CardBalance(clients[listViewClients.SelectedIndices[0]]);
                Movement.ShowDialog();
                editIndex = listViewClients.SelectedItems[0].Index;
                clients.RemoveAt(editIndex);
                listViewClients.Items.RemoveAt(editIndex);
                clients.Insert(editIndex, Movement.client);
                listViewClients.Items.Insert(editIndex, Movement.client.ToListViewItem());
            }
        }

        // method that generates the graph of a selected client 
        private void listViewClients_ItemActivate(object sender, EventArgs e)
        {
            var euroSeries = chartMovement.Series[0];
            euroSeries.Points.Clear();
            var selectedClient = clients[listViewClients.SelectedIndices[0]];
            chartMovement.ChartAreas[0].AxisY.Minimum = (selectedClient.FindMinimumEuro()) - 1;
            for (int i = 0; i < selectedClient.DateList.Count; i++)
            {
                var date = selectedClient.DateList[i];
                var euro = selectedClient.EuroList[i];
                euroSeries.Points.AddXY(date, euro);
            }
        }
    }
}
