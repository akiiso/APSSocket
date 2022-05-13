using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPClient
{

    public partial class formClient : Form
    {
        string connectionAdress = "127.0.0.1:9000";
        string buffer = "";
        private string username;

        public formClient(string username)
        {
            InitializeComponent();
            this.username = username;
            
        }
       
        SimpleTcpClient client;

        


        private void Form1_Load(object sender, EventArgs e)
        {
            lblName.Text = $"Bem vindo, {username}!";
            // client = new(txfIP.Text);
            client = new(connectionAdress);
            client.Events.Connected += Events_Connected;
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Disconnected += Events_Disconnected;
            btnSend.Enabled = false;
        }

        private void Events_Disconnected(object? sender, ConnectionEventArgs e)
        {

            this.Invoke((MethodInvoker)delegate {
                txfInfo.Text += $"[ Server ] disconnected.{Environment.NewLine}";
                btnSend.Enabled = false;
                btnConnect.Enabled = true;
                client.Disconnect();
            });
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                if(buffer == "Server") 
                { 
                    txfInfo.Text += $"{Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}"; 
                }
                else 
                { 
                txfInfo.Text += $"[ Server ]: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
                buffer = "Server";
                }
            });
        }

        private void Events_Connected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                txfInfo.Text += $"[ {username} ] connected.{Environment.NewLine}";
            });


        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(txfMessage.Text))
                {
                   
                    if (buffer == "Client")
                    {
                        
                        client.Send(username + ";" + txfMessage.Text);
                        txfInfo.Text += $"{txfMessage.Text}{Environment.NewLine}";
                        txfMessage.Text = String.Empty;
                    }
                    else
                    {
                        buffer = "Client";
                        client.Send(username + ";"+ txfMessage.Text);
                        txfInfo.Text += $"[ {username} ]: {txfMessage.Text}{Environment.NewLine}";
                        txfMessage.Text = String.Empty;
                    }
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (username.Length < 3)
            {
                MessageBox.Show("Nome precisa ter 3 ou mais caracteres", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                try
                {
                    client.Connect();
                    btnSend.Enabled = true;
                    btnConnect.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Servidor desligado", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
