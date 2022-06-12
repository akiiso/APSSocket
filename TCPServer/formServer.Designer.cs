namespace TCPServer
{
    partial class formServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formServer));
            this.btnStart = new System.Windows.Forms.Button();
            this.txfInfo = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txfMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.listClientIP = new System.Windows.Forms.ListBox();
            this.lblClientIP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(487, 35);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txfInfo
            // 
            this.txfInfo.BackColor = System.Drawing.Color.White;
            this.txfInfo.Location = new System.Drawing.Point(12, 66);
            this.txfInfo.Multiline = true;
            this.txfInfo.Name = "txfInfo";
            this.txfInfo.ReadOnly = true;
            this.txfInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txfInfo.Size = new System.Drawing.Size(550, 332);
            this.txfInfo.TabIndex = 3;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 407);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(70, 15);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Messagem: ";
            // 
            // txfMessage
            // 
            this.txfMessage.Location = new System.Drawing.Point(88, 404);
            this.txfMessage.Name = "txfMessage";
            this.txfMessage.Size = new System.Drawing.Size(387, 23);
            this.txfMessage.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(483, 403);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // listClientIP
            // 
            this.listClientIP.BackColor = System.Drawing.Color.White;
            this.listClientIP.FormattingEnabled = true;
            this.listClientIP.ItemHeight = 15;
            this.listClientIP.Location = new System.Drawing.Point(585, 65);
            this.listClientIP.Name = "listClientIP";
            this.listClientIP.Size = new System.Drawing.Size(147, 334);
            this.listClientIP.TabIndex = 4;
            // 
            // lblClientIP
            // 
            this.lblClientIP.AutoSize = true;
            this.lblClientIP.Location = new System.Drawing.Point(586, 44);
            this.lblClientIP.Name = "lblClientIP";
            this.lblClientIP.Size = new System.Drawing.Size(62, 15);
            this.lblClientIP.TabIndex = 0;
            this.lblClientIP.Text = "Conexões:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Central Hard Finger";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TCPServer.Properties.Resources.LogoHF;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // formServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 436);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listClientIP);
            this.Controls.Add(this.txfInfo);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txfMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblClientIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "formServer";
            this.Text = "Hard Finger 💬 - Host";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txfInfo;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txfMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox listClientIP;
        private System.Windows.Forms.Label lblClientIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
