using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBox
{
    class CServer : MarshalByRefObject, ICServer
    {
        List<ICChat> clientList = new List<ICChat>();
        List<String> textHistory = new List<String>();

        public void SendMessage(String m)
        {
            foreach (ICChat client in clientList)
            {
                client.RecieveMessage(m);
            }
            textHistory.Add(m);
        }

        public void Subscribe(ICChat client)
        {
            clientList.Add(client);
        }
        public void Unsubscribe(int identifier)
        {
            foreach (ICChat client in clientList)
            {
                if (client.identifier == identifier)
                {
                    clientList.Remove(client);
                    break;
                }
            }
        }
    }
}
