using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBox
{
    public interface ICChat 
    {
        int identifier { get; set; }
        void SendClient(String m);
        void RecieveMessage(String m);
    }

}
