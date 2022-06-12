namespace TCPClient
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblError = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblHardFinger = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txfName = new System.Windows.Forms.TextBox();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.btnSendForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblWhere = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.pnlChat = new System.Windows.Forms.Panel();
            this.btnForm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txfInfo = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txfMessage = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlForms = new System.Windows.Forms.Panel();
            this.txfFormType = new System.Windows.Forms.ComboBox();
            this.btnSndForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txfFormDescription = new System.Windows.Forms.TextBox();
            this.txfFormLocalization = new System.Windows.Forms.TextBox();
            this.txfFormName = new System.Windows.Forms.TextBox();
            this.lblFormDescription = new System.Windows.Forms.Label();
            this.lblFormLocalization = new System.Windows.Forms.Label();
            this.lblFormType = new System.Windows.Forms.Label();
            this.lblFormName = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(271, 166);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 6;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Controls.Add(this.lblHardFinger);
            this.pnlLogin.Controls.Add(this.lblName1);
            this.pnlLogin.Controls.Add(this.lblError);
            this.pnlLogin.Controls.Add(this.btnConnect);
            this.pnlLogin.Controls.Add(this.txfName);
            this.pnlLogin.Controls.Add(this.imgUser);
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(779, 431);
            this.pnlLogin.TabIndex = 12;
            // 
            // lblHardFinger
            // 
            this.lblHardFinger.AutoSize = true;
            this.lblHardFinger.Font = new System.Drawing.Font("Segoe UI Emoji", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHardFinger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lblHardFinger.Location = new System.Drawing.Point(247, 92);
            this.lblHardFinger.Name = "lblHardFinger";
            this.lblHardFinger.Size = new System.Drawing.Size(260, 47);
            this.lblHardFinger.TabIndex = 16;
            this.lblHardFinger.Text = "Hard Finger 💬";
            this.lblHardFinger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Location = new System.Drawing.Point(228, 166);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(43, 15);
            this.lblName1.TabIndex = 15;
            this.lblName1.Text = "Nome:";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(164)))), ((int)(((byte)(253)))));
            this.btnConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(164)))), ((int)(((byte)(223)))));
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnect.Location = new System.Drawing.Point(317, 221);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(99, 23);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Entrar ➜";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txfName
            // 
            this.txfName.Location = new System.Drawing.Point(228, 184);
            this.txfName.Name = "txfName";
            this.txfName.PlaceholderText = "Insira seu nome";
            this.txfName.Size = new System.Drawing.Size(267, 23);
            this.txfName.TabIndex = 13;
            // 
            // imgUser
            // 
            this.imgUser.Image = global::TCPClient.Properties.Resources.LogoHF;
            this.imgUser.Location = new System.Drawing.Point(12, 73);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(189, 181);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUser.TabIndex = 14;
            this.imgUser.TabStop = false;
            // 
            // btnSendForm
            // 
            this.btnSendForm.Location = new System.Drawing.Point(112, 364);
            this.btnSendForm.Name = "btnSendForm";
            this.btnSendForm.Size = new System.Drawing.Size(130, 23);
            this.btnSendForm.TabIndex = 29;
            this.btnSendForm.Text = "Enviar Formulario";
            this.btnSendForm.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label2.Location = new System.Drawing.Point(118, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 47);
            this.label2.TabIndex = 28;
            this.label2.Text = "Hard Finger 💬";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TCPClient.Properties.Resources.LogoHF;
            this.pictureBox2.Location = new System.Drawing.Point(11, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(17, 236);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(163, 15);
            this.lblDescription.TabIndex = 25;
            this.lblDescription.Text = "Descreva a ocorrencia abaixo:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(17, 254);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox4.Size = new System.Drawing.Size(331, 92);
            this.textBox4.TabIndex = 24;
            // 
            // lblWhere
            // 
            this.lblWhere.AutoSize = true;
            this.lblWhere.Location = new System.Drawing.Point(17, 192);
            this.lblWhere.Name = "lblWhere";
            this.lblWhere.Size = new System.Drawing.Size(38, 15);
            this.lblWhere.TabIndex = 22;
            this.lblWhere.Text = "Local:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(17, 210);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(331, 23);
            this.textBox3.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 23);
            this.textBox1.TabIndex = 21;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Desmatamento 🏞",
            "Maltrato a animais 🐕",
            "cu "});
            this.comboBox1.Location = new System.Drawing.Point(17, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(331, 23);
            this.comboBox1.TabIndex = 19;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(17, 148);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(33, 15);
            this.lblType.TabIndex = 18;
            this.lblType.Text = "Tipo:";
            // 
            // pnlChat
            // 
            this.pnlChat.BackColor = System.Drawing.Color.White;
            this.pnlChat.Controls.Add(this.btnForm);
            this.pnlChat.Controls.Add(this.pictureBox1);
            this.pnlChat.Controls.Add(this.txfInfo);
            this.pnlChat.Controls.Add(this.btnSend);
            this.pnlChat.Controls.Add(this.txfMessage);
            this.pnlChat.Controls.Add(this.lblName);
            this.pnlChat.Location = new System.Drawing.Point(1, 2);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(778, 429);
            this.pnlChat.TabIndex = 13;
            this.pnlChat.Visible = false;
            // 
            // btnForm
            // 
            this.btnForm.FlatAppearance.BorderSize = 0;
            this.btnForm.Location = new System.Drawing.Point(320, 19);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(83, 24);
            this.btnForm.TabIndex = 15;
            this.btnForm.Text = "Sair";
            this.btnForm.UseVisualStyleBackColor = true;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TCPClient.Properties.Resources.LogoHF;
            this.pictureBox1.Location = new System.Drawing.Point(17, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // txfInfo
            // 
            this.txfInfo.BackColor = System.Drawing.Color.White;
            this.txfInfo.Location = new System.Drawing.Point(17, 49);
            this.txfInfo.Multiline = true;
            this.txfInfo.Name = "txfInfo";
            this.txfInfo.ReadOnly = true;
            this.txfInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txfInfo.Size = new System.Drawing.Size(386, 259);
            this.txfInfo.TabIndex = 13;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(338, 314);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(65, 22);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txfMessage
            // 
            this.txfMessage.Location = new System.Drawing.Point(17, 313);
            this.txfMessage.Name = "txfMessage";
            this.txfMessage.PlaceholderText = "Mensagem ⌨";
            this.txfMessage.Size = new System.Drawing.Size(315, 23);
            this.txfMessage.TabIndex = 10;
            this.txfMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txfMessage_KeyDown);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(59, 19);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(53, 21);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // pnlForms
            // 
            this.pnlForms.Controls.Add(this.txfFormType);
            this.pnlForms.Controls.Add(this.btnSndForm);
            this.pnlForms.Controls.Add(this.button1);
            this.pnlForms.Controls.Add(this.pictureBox3);
            this.pnlForms.Controls.Add(this.txfFormDescription);
            this.pnlForms.Controls.Add(this.txfFormLocalization);
            this.pnlForms.Controls.Add(this.txfFormName);
            this.pnlForms.Controls.Add(this.lblFormDescription);
            this.pnlForms.Controls.Add(this.lblFormLocalization);
            this.pnlForms.Controls.Add(this.lblFormType);
            this.pnlForms.Controls.Add(this.lblFormName);
            this.pnlForms.Controls.Add(this.lblReport);
            this.pnlForms.Controls.Add(this.label3);
            this.pnlForms.Location = new System.Drawing.Point(2, 0);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(795, 532);
            this.pnlForms.TabIndex = 14;
            // 
            // txfFormType
            // 
            this.txfFormType.FormattingEnabled = true;
            this.txfFormType.Items.AddRange(new object[] {
            "Desmatamento de área preservada",
            "Descarte irregular de lixo",
            "Queima em área preservada",
            "Outro"});
            this.txfFormType.Location = new System.Drawing.Point(34, 213);
            this.txfFormType.Name = "txfFormType";
            this.txfFormType.Size = new System.Drawing.Size(310, 23);
            this.txfFormType.TabIndex = 24;
            // 
            // btnSndForm
            // 
            this.btnSndForm.Location = new System.Drawing.Point(225, 430);
            this.btnSndForm.Name = "btnSndForm";
            this.btnSndForm.Size = new System.Drawing.Size(119, 23);
            this.btnSndForm.TabIndex = 23;
            this.btnSndForm.Text = "Enviar Formulario";
            this.btnSndForm.UseVisualStyleBackColor = true;
            this.btnSndForm.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Retornar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TCPClient.Properties.Resources.forms;
            this.pictureBox3.Location = new System.Drawing.Point(34, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // txfFormDescription
            // 
            this.txfFormDescription.Location = new System.Drawing.Point(34, 311);
            this.txfFormDescription.Multiline = true;
            this.txfFormDescription.Name = "txfFormDescription";
            this.txfFormDescription.PlaceholderText = "Descreva sua ocorrencia";
            this.txfFormDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txfFormDescription.Size = new System.Drawing.Size(310, 108);
            this.txfFormDescription.TabIndex = 19;
            // 
            // txfFormLocalization
            // 
            this.txfFormLocalization.Location = new System.Drawing.Point(34, 262);
            this.txfFormLocalization.Name = "txfFormLocalization";
            this.txfFormLocalization.PlaceholderText = "Digite a localizacao da ocorrencia";
            this.txfFormLocalization.Size = new System.Drawing.Size(310, 23);
            this.txfFormLocalization.TabIndex = 19;
            // 
            // txfFormName
            // 
            this.txfFormName.Location = new System.Drawing.Point(34, 164);
            this.txfFormName.Name = "txfFormName";
            this.txfFormName.PlaceholderText = "Digite seu nome";
            this.txfFormName.Size = new System.Drawing.Size(310, 23);
            this.txfFormName.TabIndex = 19;
            // 
            // lblFormDescription
            // 
            this.lblFormDescription.AutoSize = true;
            this.lblFormDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFormDescription.Location = new System.Drawing.Point(34, 288);
            this.lblFormDescription.Name = "lblFormDescription";
            this.lblFormDescription.Size = new System.Drawing.Size(77, 20);
            this.lblFormDescription.TabIndex = 18;
            this.lblFormDescription.Text = "Descricao:";
            // 
            // lblFormLocalization
            // 
            this.lblFormLocalization.AutoSize = true;
            this.lblFormLocalization.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFormLocalization.Location = new System.Drawing.Point(34, 239);
            this.lblFormLocalization.Name = "lblFormLocalization";
            this.lblFormLocalization.Size = new System.Drawing.Size(90, 20);
            this.lblFormLocalization.TabIndex = 18;
            this.lblFormLocalization.Text = "Localizacao:";
            // 
            // lblFormType
            // 
            this.lblFormType.AutoSize = true;
            this.lblFormType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFormType.Location = new System.Drawing.Point(34, 190);
            this.lblFormType.Name = "lblFormType";
            this.lblFormType.Size = new System.Drawing.Size(137, 20);
            this.lblFormType.TabIndex = 18;
            this.lblFormType.Text = "Tipo de ocorrencia:";
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFormName.Location = new System.Drawing.Point(34, 141);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(53, 20);
            this.lblFormName.TabIndex = 18;
            this.lblFormName.Text = "Nome:";
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReport.Location = new System.Drawing.Point(33, 92);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(329, 40);
            this.lblReport.TabIndex = 18;
            this.lblReport.Text = "Prencha os campos abaixo para prosseguir com \r\nsua dênuncia.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label3.Location = new System.Drawing.Point(94, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 47);
            this.label3.TabIndex = 17;
            this.label3.Text = "Hard Finger 💬";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 534);
            this.Controls.Add(this.pnlChat);
            this.Controls.Add(this.pnlForms);
            this.Controls.Add(this.pnlLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Hard Finger 💬 - Entrar";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlChat.ResumeLayout(false);
            this.pnlChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlForms.ResumeLayout(false);
            this.pnlForms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.TextBox txfName;
        private System.Windows.Forms.Panel pnlChat;
        private System.Windows.Forms.TextBox txfInfo;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txfMessage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnForm;
        private System.Windows.Forms.Label lblHardFinger;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblWhere;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnSendForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlForms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSndForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txfFormDescription;
        private System.Windows.Forms.TextBox txfFormLocalization;
        private System.Windows.Forms.TextBox txfFormName;
        private System.Windows.Forms.Label lblFormDescription;
        private System.Windows.Forms.Label lblFormLocalization;
        private System.Windows.Forms.Label lblFormType;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.ComboBox txfFormType;
    }
}