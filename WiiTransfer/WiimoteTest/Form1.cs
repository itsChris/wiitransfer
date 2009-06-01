using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NativeWifi;
using System.Net.Sockets;

namespace WiimoteTest
{
    public partial class Form1 : Form
    {
        static string GetStringForSSID(Wlan.Dot11Ssid ssid)
        {
            return Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
        }


        WlanClient client;
        Wlan.WlanAvailableNetwork[] networks;
        string notification;
        bool notchanged = false;
        string connnotification;
        bool connnotchanged = false;

        public Form1()
        {

            client = new WlanClient();

            InitializeComponent();

            foreach (WlanClient.WlanInterface wlanIface in client.Interfaces)
            {
                lbInterfaces.Items.Add(wlanIface.InterfaceDescription);
                wlanIface.WlanConnectionNotification += new WlanClient.WlanInterface.WlanConnectionNotificationEventHandler(wlanIface_WlanConnectionNotification);
                wlanIface.WlanNotification += new WlanClient.WlanInterface.WlanNotificationEventHandler(wlanIface_WlanNotification);
            }            

            Timer t = new Timer();
            t.Interval = 100;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
                            
        }

        void t_Tick(object sender, EventArgs e)
        {
            if (notchanged)
            {
                lbConnectionNotificationList.Items.Add(notification);
                notchanged = false;
            }

            if (connnotchanged)
            {
                lbNotifications.Items.Add(connnotification);
                connnotchanged = false;
            }

            txtRecMsg.Text = texttoshow;

            label4.Text = client.Interfaces[0].InterfaceState.ToString();
            populateAvailableNetworks();

        }

        void wlanIface_WlanNotification(Wlan.WlanNotificationData notifyData)
        {
            notification = notifyData.NotificationCode.ToString();
            notchanged = true;
        }
       
        void wlanIface_WlanConnectionNotification(Wlan.WlanNotificationData notifyData, Wlan.WlanConnectionNotificationData connNotifyData)
        {
            connnotification = notifyData.NotificationCode.ToString();
            connnotchanged = true;
        }

        void populateAvailableNetworks()
        {
           // lbNetworks.Items.Clear();
            networks = client.Interfaces[0].GetAvailableNetworkList(0);

            foreach (Wlan.WlanAvailableNetwork network in networks)
            {
                string net  = GetStringForSSID(network.dot11Ssid);
                if (!lbNetworks.Items.Contains(net))
                    lbNetworks.Items.Add(net);

            }

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            client.Interfaces[0].Scan();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            // Connects to a known network with WEP security
           
            string profileName = "Cheesecake"; // this is also the SSID
            string mac = "52544131303235572D454137443638";
            string key = "playstation3";
            string authtype = "WPA2PSK";
            string enctype = "AES";
            string keytype = "passPhrase";
            string profileXml = string.Format("<?xml version=\"1.0\"?><WLANProfile xmlns=\"http://www.microsoft.com/networking/WLAN/profile/v1\"><name>{0}</name><SSIDConfig><SSID><hex>7261756C77706132</hex><name>{0}</name></SSID><nonBroadcast>false</nonBroadcast></SSIDConfig><connectionType>IBSS</connectionType><connectionMode>manual</connectionMode><MSM><security><authEncryption><authentication>{3}</authentication><encryption>{4}</encryption></authEncryption><sharedKey><keyType>{5}</keyType><protected>false</protected><keyMaterial>{2}</keyMaterial></sharedKey></security></MSM></WLANProfile>", profileName, mac, key,authtype,enctype,keytype);
            client.Interfaces[0].SetProfile(Wlan.WlanProfileFlags.AllUser, profileXml, true);

            client.Interfaces[0].Connect(Wlan.WlanConnectionMode.Profile, Wlan.Dot11BssType.Any, "raulwpa2");
          
               }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            client.Interfaces[0].Disconnect();
        }

        private void btnGetIp_Click(object sender, EventArgs e)
        {
            string[] ipadresses = new string[200];
            string[] subnets = new string[200];
            string[] gateways = new string[200];
            string[] dns = new string[200];
            WMIHelper.GetIP(client.Interfaces[0].InterfaceDescription, out ipadresses, out subnets, out gateways, out dns);

            lblIP.Text = ipadresses[0];
            lblMask.Text = subnets[0];
            lblGateway.Text = gateways[0];
            lblDNS.Text = dns[0];


        }

        private void btnSetIP_Click(object sender, EventArgs e)
        {
            WMIHelper.SetIP(client.Interfaces[0].InterfaceName, "192.168.1.1", "255.255.255.0", "192.168.1.2", "193.245.122.122");
        }


        //const int clientPort = 8000;
        //byte[] serverIP = Encoding.ASCII.GetBytes("127.0.0.1");

        public TcpClient tcpclient = null;
        public NetworkStream netStream = null;

        TcpListener tcpListner = null;


        private void button1_Click(object sender, EventArgs e)
        {
            

            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(serverListen);
            worker.RunWorkerAsync();
            

             
        }

        private void button2_Click(object sender, EventArgs e)
        {

            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(clientConnect);
            worker.RunWorkerAsync();
           

        }

        private void clientConnect(object sender, DoWorkEventArgs e)
        {
            try
            {
                tcpclient = new TcpClient();
                tcpclient.Connect(txtClientIP.Text, Convert.ToInt32(txtClientPort.Text));
                netStream = tcpclient.GetStream();
                byte[] byteBuffer = Encoding.ASCII.GetBytes("Raul");
                //netStream.Write(byteBuffer, 0, byteBuffer.Length);
                int totalBytesRcvd = 0; // Total bytes received so far
                int bytesRcvd = 0; // Bytes received in last read

                while ((bytesRcvd = netStream.Read(byteBuffer,
                        totalBytesRcvd, byteBuffer.Length - totalBytesRcvd)) > 0)
                {
                    UpdateText("\n" + Encoding.ASCII.GetString(byteBuffer));
                }
            }
            catch (Exception ex)
            {

            }

            finally
            {
                netStream.Close();
                tcpclient.Close();
            }
        }
        
        private const int BUFSIZE = 32;
        byte[] rcvBuffer = new byte[BUFSIZE];
        int bytesRcvd;

        void serverListen(object sender, DoWorkEventArgs e)
        {
            tcpListner = new TcpListener(Convert.ToInt32(txtServerPort.Text));
            tcpListner.Start();

            while (true)
            {
                
                
                try
                {
                    tcpclient = tcpListner.AcceptTcpClient(); // Get client connection
                    netStream = tcpclient.GetStream();
                    int totalBytesEchoed = 0;
                    while ((bytesRcvd = netStream.Read(rcvBuffer, 0, rcvBuffer.Length)) > 0)
                    {
                        //totalBytesEchoed += bytesRcvd;
                        //UpdateText(rcvBuffer[0].ToString());
                        texttoshow = rcvBuffer[0].ToString();
                    }

                    netStream.Close();
                    tcpclient.Close();
                }

                catch (Exception ex)
                {
                    //Console.WriteLine(e.Message);
                    netStream.Close();
                }
            }
        }


        string texttoshow = "";

        void UpdateText(string newTitle)
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate()
                {
                    txtRecMsg.Text = newTitle;
                }));
            else
            {
                txtRecMsg.Text += newTitle;
            }
        }


        private void btnStopClient_Click(object sender, EventArgs e)
        {
            netStream.Close();
            tcpclient.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] msg = Encoding.ASCII.GetBytes(txtMessage.Text);
            netStream.Write(msg, 0, msg.Length);
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            tcpListner.Stop();
        }
        public bool sendData = false;

        private void btnSendData_Click(object sender, EventArgs e)
        {
            sendData = !sendData;
            //BackgroundWorker w = new BackgroundWorker();
            //w.DoWork += new DoWorkEventHandler(sendDataContinuously);
            //w.RunWorkerAsync();
        }

        void sendDataContinuously(object sender, DoWorkEventArgs e)
        {

            
        }

        public void  SendByte(byte b)
        {
            byte[] msg = new byte[1];
            msg[0] = b;
            netStream.Write(msg,0,msg.Length);
        }



    
    }
}
