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

        void getAvailableNetworks()
        {
            // lbNetworks.Items.Clear();
            networks = client.Interfaces[0].GetAvailableNetworkList(0);

            foreach (Wlan.WlanAvailableNetwork network in networks)
            {
                string net = GetStringForSSID(network.dot11Ssid);
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            client.Interfaces[0].Scan();
        }

        private void Connect()
        {
            string profileName = "Cheesecake"; // this is also the SSID
            string mac = "52544131303235572D454137443638";
            string key = "playstation3";
            string authtype = "WPA2PSK";
            string enctype = "AES";
            string keytype = "passPhrase";
            string profileXml = string.Format("<?xml version=\"1.0\"?><WLANProfile xmlns=\"http://www.microsoft.com/networking/WLAN/profile/v1\"><name>{0}</name><SSIDConfig><SSID><hex>7261756C77706132</hex><name>{0}</name></SSID><nonBroadcast>false</nonBroadcast></SSIDConfig><connectionType>IBSS</connectionType><connectionMode>manual</connectionMode><MSM><security><authEncryption><authentication>{3}</authentication><encryption>{4}</encryption></authEncryption><sharedKey><keyType>{5}</keyType><protected>false</protected><keyMaterial>{2}</keyMaterial></sharedKey></security></MSM></WLANProfile>", profileName, mac, key, authtype, enctype, keytype);
            client.Interfaces[0].SetProfile(Wlan.WlanProfileFlags.AllUser, profileXml, true);

            client.Interfaces[0].Connect(Wlan.WlanConnectionMode.Profile, Wlan.Dot11BssType.Any, "raulwpa2");


        }

        private void Disconnect()
        {
            client.Interfaces[0].Disconnect();
        }


    }
}

