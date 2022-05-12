namespace TCPClient
{
    partial class formClient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblServer = new System.Windows.Forms.Label();
            this.txfIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txfInfo = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txfMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(40, 15);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(42, 15);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Server:";

            // 
            // txfIP
            // 
            this.txfIP.Location = new System.Drawing.Point(88, 12);
            this.txfIP.Name = "txfIP";
            this.txfIP.Size = new System.Drawing.Size(305, 23);
            this.txfIP.TabIndex = 1;
            this.txfIP.Text = "127.0.0.1:9000";

            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(399, 11);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txfInfo
            // 
            this.txfInfo.Location = new System.Drawing.Point(88, 41);
            this.txfInfo.Multiline = true;
            this.txfInfo.Name = "txfInfo";
            this.txfInfo.ReadOnly = true;
            this.txfInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txfInfo.Size = new System.Drawing.Size(386, 263);
            this.txfInfo.TabIndex = 3;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 313);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(70, 15);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Messagem: ";

            // 
            // txfMessage
            // 
            this.txfMessage.Location = new System.Drawing.Point(88, 310);
            this.txfMessage.Name = "txfMessage";
            this.txfMessage.Size = new System.Drawing.Size(305, 23);
            this.txfMessage.TabIndex = 1;

            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(399, 310);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 344);
            this.Controls.Add(this.txfInfo);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txfMessage);
            this.Controls.Add(this.txfIP);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblServer);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TCP/IP Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txfIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txfInfo;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txfMessage;
        private System.Windows.Forms.Button btnSend;
    }
}
