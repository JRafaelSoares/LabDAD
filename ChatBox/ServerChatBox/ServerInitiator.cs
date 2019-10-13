using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace ChatBox
{
    class ServerInitiator
    {
       
        static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel(8086);
            ChannelServices.RegisterChannel(channel, true);

            Console.WriteLine("Channel 8086 operational");

            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(ICServer),
                "CServer",
                WellKnownObjectMode.Singleton);

            Console.WriteLine("<enter> para sair...");
            Console.ReadLine();
        }
    }
}
