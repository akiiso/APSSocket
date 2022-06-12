using SuperSimpleTcp;
using System;
using System.Text;
using System.Windows.Forms;

namespace TCPServer
{
    public partial class formServer : Form
    {
        public formServer()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;
        private string Ip = "127.0.0.1:9000";
        private void btnStart_Click(object sender, EventArgs e)
        {
            server.Start();
            txfInfo.Text += $"Iniciando...{Environment.NewLine}";
            btnStart.Enabled = false;
            btnSend.Enabled = true;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                if (!string.IsNullOrEmpty(txfMessage.Text) && listClientIP.SelectedItem != null)
                {
                    server.Send(listClientIP.SelectedItem.ToString(), txfMessage.Text);
                    txfInfo.Text += $"[ Central ]: {txfMessage.Text}{Environment.NewLine}";
                    txfMessage.Text = String.Empty;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            server = new SimpleTcpServer(Ip);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;

        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                txfInfo.Text += $" {e.IpPort}: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";

            });
        }

        private void Events_ClientDisconnected(object? sender, ConnectionEventArgs e)
        {

            this.Invoke((MethodInvoker)delegate {
                txfInfo.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";
                listClientIP.Items.Remove(e.IpPort);
            });
        }

        private void Events_ClientConnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                txfInfo.Text += $"{e.IpPort} connected.{Environment.NewLine}";
                listClientIP.Items.Add(e.IpPort);
            });
        }
    }
}
