using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NativeWifi;

namespace WiimoteTest
{


    class WifiManager
    {
        WlanClient client;
        Wlan.WlanAvailableNetwork[] networks;

        private string GetStringForSSID(Wlan.Dot11Ssid ssid)
        {
            return Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
        }

        public WifiManager()
        {
            client = new WlanClient();
            foreach (WlanClient.WlanInterface wlanIface in client.Interfaces)
            {
                //lbInterfaces.Items.Add(wlanIface.InterfaceDescription);
                wlanIface.WlanConnectionNotification += new WlanClient.WlanInterface.WlanConnectionNotificationEventHandler(wlanIface_WlanConnectionNotification);
                wlanIface.WlanNotification += new WlanClient.WlanInterface.WlanNotificationEventHandler(wlanIface_WlanNotification);
            }
        }
        void wlanIface_WlanNotification(Wlan.WlanNotificationData notifyData)
        {
            //notification = notifyData.NotificationCode.ToString();
            //notchanged = true;
        }

        void wlanIface_WlanConnectionNotification(Wlan.WlanNotificationData notifyData, Wlan.WlanConnectionNotificationData connNotifyData)
        {
            //connnotification = notifyData.NotificationCode.ToString();
            //connnotchanged = true;
        }

        public List<string> getAvailableNetworks(bool adhoc)
        {
            List<string> stringNetworks = new List<string>();
            //client.Interfaces[0].Scan();
            networks = client.Interfaces[0].GetAvailableNetworkList(0);

            foreach (Wlan.WlanAvailableNetwork network in networks)
            {
                if (network.dot11BssType == Wlan.Dot11BssType.Independent)
                {
                    string net = GetStringForSSID(network.dot11Ssid);
                    stringNetworks.Add(net);
                }
            }
            return stringNetworks;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            client.Interfaces[0].Scan();
        }

        private string CurrentlyConnectedTo = "";
        public void Connect(string Name)
        {
            Wlan.Dot11Ssid ssid = (from net in networks
                                   where GetStringForSSID(net.dot11Ssid) == Name
                                   select net.dot11Ssid).FirstOrDefault();
            client.Interfaces[0].Connect(Wlan.WlanConnectionMode.DiscoveryUnsecure, Wlan.Dot11BssType.Independent, ssid,
                                         Wlan.WlanConnectionFlags.AdhocJoinOnly);

        }

        public void ConnectToSecure(string Name,string Password)
        {
            string profileName = Name; // this is also the SSID
            string mac = "";
            string key = Password;
            string authtype = "WPA2PSK";
            string enctype = "AES";
            string keytype = "passPhrase";


            string profileXml = string.Format("<?xml version=\"1.0\"?><WLANProfile xmlns=\"http://www.microsoft.com/networking/WLAN/profile/v1\"><name>{0}</name><SSIDConfig><SSID><name>{0}</name></SSID><nonBroadcast>false</nonBroadcast></SSIDConfig><connectionType>IBSS</connectionType><connectionMode>manual</connectionMode><MSM><security><authEncryption><authentication>{3}</authentication><encryption>{4}</encryption></authEncryption><sharedKey><keyType>{5}</keyType><protected>false</protected><keyMaterial>{2}</keyMaterial></sharedKey></security></MSM></WLANProfile>", profileName, mac, key, authtype, enctype, keytype);
            
            client.Interfaces[0].SetProfile(Wlan.WlanProfileFlags.AllUser, profileXml, true);

            client.Interfaces[0].Connect(Wlan.WlanConnectionMode.Profile, Wlan.Dot11BssType.Independent, Name);

        }

        public string InterfaceDescription
        {
            get
            {
                return client.Interfaces[0].InterfaceDescription;
            }
        }

        public void CreateUnsecureAndConnect(string Name)
        {
            string profileName = Name; // this is also the SSID
            string mac = "";
            string key = "playstation3";
            string authtype = "WPA2PSK";
            string enctype = "AES";
            string keytype = "passPhrase";

            string profileXml = string.Format("<?xml version=\"1.0\"?><WLANProfile xmlns=\"http://www.microsoft.com/networking/WLAN/profile/v1\"><name>{0}</name><SSIDConfig><SSID><name>{0}</name></SSID><nonBroadcast>false</nonBroadcast></SSIDConfig><connectionType>IBSS</connectionType><connectionMode>manual</connectionMode><MSM><security><authEncryption><authentication>{3}</authentication><encryption>{4}</encryption></authEncryption><sharedKey><keyType>{5}</keyType><protected>false</protected><keyMaterial>{2}</keyMaterial></sharedKey></security></MSM></WLANProfile>", profileName, mac, key, authtype, enctype, keytype);
            string openProfileXml = string.Format("<?xml version=\"1.0\"?><WLANProfile xmlns=\"http://www.microsoft.com/networking/WLAN/profile/v1\"><name>{0}</name><SSIDConfig><SSID><name>{0}</name></SSID><nonBroadcast>false</nonBroadcast></SSIDConfig><connectionType>IBSS</connectionType><connectionMode>manual</connectionMode><MSM><security><authEncryption><authentication>open</authentication><encryption>none</encryption><useOneX>false</useOneX></authEncryption></security></MSM></WLANProfile>", profileName,mac);
            client.Interfaces[0].SetProfile(Wlan.WlanProfileFlags.AllUser, openProfileXml, true);

            client.Interfaces[0].Connect(Wlan.WlanConnectionMode.Profile, Wlan.Dot11BssType.Independent, profileName);
            CurrentlyConnectedTo = profileName;

        }

        public void CreateSecureAndConnect(string Name,string password)
        {
            string profileName = Name; // this is also the SSID
            string mac = "";
            string key = password;
            string authtype = "WPA2PSK";
            string enctype = "AES";
            string keytype = "passPhrase";

            string profileXml = string.Format("<?xml version=\"1.0\"?><WLANProfile xmlns=\"http://www.microsoft.com/networking/WLAN/profile/v1\"><name>{0}</name><SSIDConfig><SSID><name>{0}</name></SSID><nonBroadcast>false</nonBroadcast></SSIDConfig><connectionType>IBSS</connectionType><connectionMode>manual</connectionMode><MSM><security><authEncryption><authentication>{3}</authentication><encryption>{4}</encryption></authEncryption><sharedKey><keyType>{5}</keyType><protected>false</protected><keyMaterial>{2}</keyMaterial></sharedKey></security></MSM></WLANProfile>", profileName, mac, key, authtype, enctype, keytype);

            client.Interfaces[0].SetProfile(Wlan.WlanProfileFlags.AllUser, profileXml, true);

            client.Interfaces[0].Connect(Wlan.WlanConnectionMode.Profile, Wlan.Dot11BssType.Independent, profileName);
            CurrentlyConnectedTo = profileName;
        }

        public void Disconnect()
        {
            client.Interfaces[0].Disconnect();
            if (CurrentlyConnectedTo != "")
            {
                client.Interfaces[0].DeleteProfile(CurrentlyConnectedTo);
                CurrentlyConnectedTo = "";
            }
        }


    }
}

