namespace WiimoteTest
{
    partial class Form1
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
            this.lbNetworks = new System.Windows.Forms.ListBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lbConnectionNotificationList = new System.Windows.Forms.ListBox();
            this.lbNotifications = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbInterfaces = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGetIp = new System.Windows.Forms.Button();
            this.btnSetIP = new System.Windows.Forms.Button();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblDNS = new System.Windows.Forms.Label();
            this.lblGateway = new System.Windows.Forms.Label();
            this.lblMask = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtClientIP = new System.Windows.Forms.TextBox();
            this.txtClientPort = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.btnStopClient = new System.Windows.Forms.Button();
            this.txtRecMsg = new System.Windows.Forms.TextBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNetworks
            // 
            this.lbNetworks.FormattingEnabled = true;
            this.lbNetworks.Location = new System.Drawing.Point(12, 23);
            this.lbNetworks.Name = "lbNetworks";
            this.lbNetworks.Size = new System.Drawing.Size(163, 95);
            this.lbNetworks.TabIndex = 0;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(404, 12);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(404, 70);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 2;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(404, 41);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lbConnectionNotificationList
            // 
            this.lbConnectionNotificationList.FormattingEnabled = true;
            this.lbConnectionNotificationList.Location = new System.Drawing.Point(12, 139);
            this.lbConnectionNotificationList.Name = "lbConnectionNotificationList";
            this.lbConnectionNotificationList.Size = new System.Drawing.Size(163, 95);
            this.lbConnectionNotificationList.TabIndex = 4;
            // 
            // lbNotifications
            // 
            this.lbNotifications.FormattingEnabled = true;
            this.lbNotifications.Location = new System.Drawing.Point(12, 260);
            this.lbNotifications.Name = "lbNotifications";
            this.lbNotifications.Size = new System.Drawing.Size(163, 95);
            this.lbNotifications.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Networks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Connection Notifications";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Notifications";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // lbInterfaces
            // 
            this.lbInterfaces.FormattingEnabled = true;
            this.lbInterfaces.Location = new System.Drawing.Point(203, 260);
            this.lbInterfaces.Name = "lbInterfaces";
            this.lbInterfaces.Size = new System.Drawing.Size(151, 95);
            this.lbInterfaces.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Interfaces";
            // 
            // btnGetIp
            // 
            this.btnGetIp.Location = new System.Drawing.Point(404, 100);
            this.btnGetIp.Name = "btnGetIp";
            this.btnGetIp.Size = new System.Drawing.Size(75, 23);
            this.btnGetIp.TabIndex = 12;
            this.btnGetIp.Text = "Get IP";
            this.btnGetIp.UseVisualStyleBackColor = true;
            this.btnGetIp.Click += new System.EventHandler(this.btnGetIp_Click);
            // 
            // btnSetIP
            // 
            this.btnSetIP.Location = new System.Drawing.Point(404, 130);
            this.btnSetIP.Name = "btnSetIP";
            this.btnSetIP.Size = new System.Drawing.Size(75, 23);
            this.btnSetIP.TabIndex = 13;
            this.btnSetIP.Text = "Set IP";
            this.btnSetIP.UseVisualStyleBackColor = true;
            this.btnSetIP.Click += new System.EventHandler(this.btnSetIP_Click);
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(203, 97);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(35, 13);
            this.lblIP.TabIndex = 14;
            this.lblIP.Text = "label6";
            // 
            // lblDNS
            // 
            this.lblDNS.AutoSize = true;
            this.lblDNS.Location = new System.Drawing.Point(203, 167);
            this.lblDNS.Name = "lblDNS";
            this.lblDNS.Size = new System.Drawing.Size(35, 13);
            this.lblDNS.TabIndex = 15;
            this.lblDNS.Text = "label7";
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Location = new System.Drawing.Point(203, 140);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(35, 13);
            this.lblGateway.TabIndex = 16;
            this.lblGateway.Text = "label8";
            // 
            // lblMask
            // 
            this.lblMask.AutoSize = true;
            this.lblMask.Location = new System.Drawing.Point(203, 120);
            this.lblMask.Name = "lblMask";
            this.lblMask.Size = new System.Drawing.Size(35, 13);
            this.lblMask.TabIndex = 17;
            this.lblMask.Text = "label9";
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Location = new System.Drawing.Point(203, 70);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(73, 13);
            this.lblSettings.TabIndex = 18;
            this.lblSettings.Text = "Your Settings:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(727, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Start Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(674, 284);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(47, 20);
            this.txtServerPort.TabIndex = 20;
            this.txtServerPort.Text = "8000";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(727, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Connect to server";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtClientIP
            // 
            this.txtClientIP.Location = new System.Drawing.Point(568, 321);
            this.txtClientIP.Name = "txtClientIP";
            this.txtClientIP.Size = new System.Drawing.Size(100, 20);
            this.txtClientIP.TabIndex = 22;
            this.txtClientIP.Text = "127.0.0.1";
            // 
            // txtClientPort
            // 
            this.txtClientPort.Location = new System.Drawing.Point(674, 323);
            this.txtClientPort.Name = "txtClientPort";
            this.txtClientPort.Size = new System.Drawing.Size(47, 20);
            this.txtClientPort.TabIndex = 23;
            this.txtClientPort.Text = "8000";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(530, 222);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(218, 20);
            this.txtMessage.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(755, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 21);
            this.button3.TabIndex = 25;
            this.button3.Text = "Send Message";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnStopServer
            // 
            this.btnStopServer.Location = new System.Drawing.Point(855, 280);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(63, 23);
            this.btnStopServer.TabIndex = 26;
            this.btnStopServer.Text = "Stop";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // btnStopClient
            // 
            this.btnStopClient.Location = new System.Drawing.Point(855, 323);
            this.btnStopClient.Name = "btnStopClient";
            this.btnStopClient.Size = new System.Drawing.Size(63, 23);
            this.btnStopClient.TabIndex = 26;
            this.btnStopClient.Text = "Stop";
            this.btnStopClient.UseVisualStyleBackColor = true;
            this.btnStopClient.Click += new System.EventHandler(this.btnStopClient_Click);
            // 
            // txtRecMsg
            // 
            this.txtRecMsg.Location = new System.Drawing.Point(530, 12);
            this.txtRecMsg.Multiline = true;
            this.txtRecMsg.Name = "txtRecMsg";
            this.txtRecMsg.Size = new System.Drawing.Size(316, 204);
            this.txtRecMsg.TabIndex = 27;
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(755, 248);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(91, 21);
            this.btnSendData.TabIndex = 28;
            this.btnSendData.Text = "Send Data";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 367);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.txtRecMsg);
            this.Controls.Add(this.btnStopClient);
            this.Controls.Add(this.btnStopServer);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtClientPort);
            this.Controls.Add(this.txtClientIP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.lblMask);
            this.Controls.Add(this.lblGateway);
            this.Controls.Add(this.lblDNS);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.btnSetIP);
            this.Controls.Add(this.btnGetIp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbInterfaces);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNotifications);
            this.Controls.Add(this.lbConnectionNotificationList);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.lbNetworks);
            this.Name = "Form1";
            this.Text = "Secure file transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNetworks;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox lbConnectionNotificationList;
        private System.Windows.Forms.ListBox lbNotifications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbInterfaces;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGetIp;
        private System.Windows.Forms.Button btnSetIP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblDNS;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.Label lblMask;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtClientIP;
        private System.Windows.Forms.TextBox txtClientPort;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.Button btnStopClient;
        private System.Windows.Forms.TextBox txtRecMsg;
        private System.Windows.Forms.Button btnSendData;
    }
}

