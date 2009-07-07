using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WiimoteTest
{
    class NetworkManager
    {
        public string GetIP(string InterfaceDescription)
        {
            string[] ipadresses = new string[200];
            string[] subnets = new string[200];
            string[] gateways = new string[200];
            string[] dns = new string[200];
            WMIHelper.GetIP(InterfaceDescription, out ipadresses, out subnets, out gateways, out dns);
            if (ipadresses!=null && ipadresses.Count() > 0)
                return ipadresses[0];
            else
                return "";
            
            
        }



        public void SetIP(string InterfaceDescription,string ip,string mask)
        {
            WMIHelper.SetIP(InterfaceDescription, ip, mask, "192.168.1.2", "193.245.122.122");
            
        }

        public void SetAutoIp(string InterfaceDescription)
        {
            WMIHelper.SetDHCP(InterfaceDescription);
        }

    }
}
