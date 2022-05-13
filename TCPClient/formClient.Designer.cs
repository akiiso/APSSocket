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
            this.lblName = new System.Windows.Forms.Label();
            this.txfName = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txfInfo = new System.Windows.Forms.TextBox();
            this.txfMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 15);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(43, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // txfName
            // 
            this.txfName.Location = new System.Drawing.Point(57, 12);
            this.txfName.Name = "txfName";
            this.txfName.PlaceholderText = "Insira seu nome";
            this.txfName.Size = new System.Drawing.Size(257, 23);
            this.txfName.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(320, 11);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Entrar";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txfInfo
            // 
            this.txfInfo.Location = new System.Drawing.Point(9, 41);
            this.txfInfo.Multiline = true;
            this.txfInfo.Name = "txfInfo";
            this.txfInfo.ReadOnly = true;
            this.txfInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txfInfo.Size = new System.Drawing.Size(386, 263);
            this.txfInfo.TabIndex = 3;
            // 
            // txfMessage
            // 
            this.txfMessage.Location = new System.Drawing.Point(8, 310);
            this.txfMessage.Name = "txfMessage";
            this.txfMessage.PlaceholderText = "Mensagem";
            this.txfMessage.Size = new System.Drawing.Size(306, 23);
            this.txfMessage.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(320, 310);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // formClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 344);
            this.Controls.Add(this.txfInfo);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txfMessage);
            this.Controls.Add(this.txfName);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(418, 383);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(418, 383);
            this.Name = "formClient";
            this.Text = "TCP/IP Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txfName;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txfInfo;
        private System.Windows.Forms.TextBox txfMessage;
        private System.Windows.Forms.Button btnSend;
    }
}
