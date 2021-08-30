using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GESTIONE_POSTEPAY
{
    class DBclass
    {
        // field for singleton
        private static DBclass instance;

        // implementation of the singleton pattern
        public static DBclass GetInstance()
        {
            if (instance == null)
                instance = new DBclass();
            return instance;
        }

        // method that gets data from json file 
        public List<Client> GetData()
        {
            List<Client> clients = null;
            JArray jsonArray = JArray.Parse(File.ReadAllText("DBclienti"));
            clients = jsonArray.ToObject<List<Client>>();
            return clients;
        }

        // method that saves data writing a json file
        public void SaveData(List<Client> clients)
        {
            string jsonString;
            jsonString = JsonSerializer.Serialize(clients);
            File.WriteAllText("DBclienti", jsonString);
        }
    }
}
