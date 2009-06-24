using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WiimoteTest
{
    class NetworkManager
    {
        public void GetIP()
        {
            string[] ipadresses = new string[200];
            string[] subnets = new string[200];
            string[] gateways = new string[200];
            string[] dns = new string[200];
            //WMIHelper.GetIP(client.Interfaces[0].InterfaceDescription, out ipadresses, out subnets, out gateways, out dns);
        }

        public void SetIP()
        {
            //WMIHelper.SetIP(client.Interfaces[0].InterfaceName, "192.168.1.1", "255.255.255.0", "192.168.1.2", "193.245.122.122");
        }

    }
}
