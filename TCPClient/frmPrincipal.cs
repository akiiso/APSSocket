using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperSimpleTcp;

namespace TCPClient
{
    public partial class frmPrincipal : Form
    {
        //Parametros
        SimpleTcpClient client;
        public string username { get; set; } // Nome de usuario
        public string Relatorio { get; set; }//Denuncia a ser enviado ao host
        string connectionAdress = "127.0.0.1:9000"; //Endereco do host
        string buffer = String.Empty;

        //
        private void TelaLogin() // Trocar para tela de login
        {
            this.Width = 542;
            this.Height = 322;
            pnlLogin.Visible = true;
            pnlChat.Visible = false;
            pnlForms.Visible = false;
            this.Text = "Hard Finger 💬 - Entrar";
        }
        private void TelaChat() // Trocar para tela de chat
        {
            this.Width = 433;
            this.Height = 389;
            pnlLogin.Visible = false;
            pnlChat.Visible = true;
            pnlForms.Visible = false;
            this.Text = "Hard Finger 💬 - Chat";
        }
        private void TelaForm() // Trocar para tela de Formulario
        {
            this.Width = 404;
            this.Height = 512;
            pnlLogin.Visible = false;
            pnlChat.Visible = false;
            pnlForms.Visible = true;
            
            
            this.Text = "Hard Finger 💬 - Formulario";
        }
        public frmPrincipal()
        {
            InitializeComponent();
            
        }
        
        private void btnConnect_Click(object sender, EventArgs e) // 
        {
            if (!txfName.Text.Equals(""))
            {
                username = txfName.Text;
                lblName.Text = $"{username}";
                txfFormName.Text = username;
                lblError.Text = "";
                
                try
                {
                    client.Connect();
                    btnSend.Enabled = true;
                    btnConnect.Enabled = false;
                    TelaForm();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao conectar", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                lblError.Text = "Digite seu nome para prosseguir";
            }
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
                if (buffer == "Server")
                {
                    txfInfo.Text += $"{Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
                }
                else
                {

                    txfInfo.Text += $"{Environment.NewLine}[ Central ]: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
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

                        client.Send("["+username + "]: " + txfMessage.Text);
                        txfInfo.Text += $"{txfMessage.Text}{Environment.NewLine}";
                        txfMessage.Text = String.Empty;
                    }
                    else
                    {
                        buffer = "Client";
                        client.Send("[" + username + "]: " + txfMessage.Text);
                        txfInfo.Text += $"{Environment.NewLine} [ {username} ]: {txfMessage.Text}{Environment.NewLine}";
                        txfMessage.Text = String.Empty;
                    }
                }
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            TelaLogin();
            client = new(connectionAdress);    // Estabelece conexao com o servidor
            client.Events.Connected += Events_Connected;
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Disconnected += Events_Disconnected;
            
        }
        

        private void btnForm_Click(object sender, EventArgs e)
        {
            TelaLogin();
            client.Dispose();
            txfFormName.Text = "";
            txfFormType.Text = "";
            txfFormLocalization.Text = "";
            txfFormDescription.Text = "";
            txfInfo.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                Relatorio = 
                    $"{Environment.NewLine}" +
                    $"-----------------------------------------------------------------------{Environment.NewLine}" +
                    $"Nome: {txfFormName.Text}{Environment.NewLine}" +
                    $"Tipo de ocorrência: {txfFormType.Text}{Environment.NewLine}" +
                    $"Localização: {txfFormLocalization.Text}{Environment.NewLine}" +
                    $"Descrição: {txfFormDescription.Text}{Environment.NewLine}" +
                    $"-----------------------------------------------------------------------" +
                    $"{Environment.NewLine}";
                txfInfo.Text += Relatorio;
                client.Send(Relatorio);
                DialogResult GoChat = MessageBox.Show("Deseja conversar diretamente com um atendente?", "Hard Finger 💬", MessageBoxButtons.YesNo);

                if (GoChat == DialogResult.Yes) 
                { 
                    TelaChat(); 
                }
                else if(GoChat == DialogResult.No) 
                {
                    
                    TelaLogin();
                    client.Dispose();
                    txfFormName.Text = String.Empty;
                    txfFormType.Text = String.Empty;
                    txfFormLocalization.Text = String.Empty;
                    txfFormDescription.Text = String.Empty;
                    txfInfo.Text = String.Empty;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaLogin();
            client.Dispose();
            txfFormName.Text = "";
            txfFormType.Text = "";
            txfFormLocalization.Text = "";
            txfFormDescription.Text = "";
            txfInfo.Text = "";
        }



        private void txfMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (client.IsConnected)
                {
                    if (!string.IsNullOrEmpty(txfMessage.Text))
                    {

                        if (buffer == "Client")
                        {

                            client.Send("[" + username + "]: " + txfMessage.Text);
                            txfInfo.Text += $"{txfMessage.Text}{Environment.NewLine}";
                            txfMessage.Text = String.Empty;
                        }
                        else
                        {
                            buffer = "Client";
                            client.Send("[" + username + "]: " + txfMessage.Text);
                            txfInfo.Text += $"{Environment.NewLine} [ {username} ]: {txfMessage.Text}{Environment.NewLine}";
                            txfMessage.Text = String.Empty;
                        }
                    }
                }
            }
        }
    }
}
