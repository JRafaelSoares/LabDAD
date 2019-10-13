using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBox
{
    public partial class Form1 : Form
    {
        TcpChannel c;
        CChat cc;
        ICServer s;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            c = new TcpChannel();
            ChannelServices.RegisterChannel(c, false);

            cc = new CChat();


            s = (ICServer)Activator.GetObject(
                typeof(ICServer),
                "tcp://localhost:" + textBox1.Text + "/CServer");

            RemotingServices.Marshal(cc, "ClientCChat", typeof(CChat));
            try
            {
                Console.WriteLine("tcp://localhost:" + textBox1.Text + "/CServer");
                s = (ICServer)Activator.GetObject(
                typeof(ICServer),
                "tcp://localhost:" + textBox1.Text + "/CServer");
                if(s == null)
                {
                    Console.WriteLine("ASDASDASD");
                }
                s.Subscribe(cc);
            }
            catch (SocketException)
            {
                System.Console.WriteLine("Could not locate server");
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            s.SendMessage(textBox2.Text);
        }
    }
}
