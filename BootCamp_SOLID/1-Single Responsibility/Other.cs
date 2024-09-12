using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp_SOLID._1_Single_Responsibility
{
    internal class Other
    {
        // Exemplo ruim:
        public void EmailClients(List<int> clients)
        {
            foreach (var client in clients)
            {
                var clientRecord = db.Find(client);
                if (clientRecord.IsActive())
                {
                    Email(client);
                }
            }
        }

        // Exemplo bom:
        public void EmailClientsb(List<int> clients)
        {
            var activeClients = ActiveClients(clients);
            activeClients.ForEach(Email);
        }

        public List<int> ActiveClients(List<int> clients)
        {
            return clients.Where(IsClientActive).ToList();
        }

        public bool IsClientActive(int client)
        {
            var clientRecord = db.Find(client);
            return clientRecord.IsActive();
        }

        // Métodos auxiliares
        public void Email(int client)
        {
        }

        public class ClientRecord
        {
            public bool IsActive()
            {
                return true;
            }
        }

        public class Db
        {
            public ClientRecord Find(int client)
            {
                return new ClientRecord();
            }
        }

        private Db db = new Db();
    }
}
