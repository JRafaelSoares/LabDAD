using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBox
{
    public interface ICServer 
    {
        void SendMessage(String m);
        void Unsubscribe(int identifier);
        void Subscribe(ICChat client);
    }
}
