using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBox
{
    class CChat : MarshalByRefObject, ICChat
    {
        public int identifier { get; set; }
        public void SendClient(String m)
        {
            //FormChat.BeginInvoke(formChat.addMessage, object[]{m});
        }

        public void RecieveMessage(String m)
        {

        }
    }
}
