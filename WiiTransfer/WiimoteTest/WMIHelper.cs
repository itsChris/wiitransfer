using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;
using EasyWMI.Models.root.CIMV2;
using EasyWMI.Controllers.root.CIMV2;

namespace WiimoteTest
{
	/// <summary>
	/// A Helper class which provides convenient methods to set/get network
	/// configuration
	/// </summary>
	public class WMIHelper
	{
		#region Public Static

		/// <summary>
		/// Enable DHCP on the NIC
		/// </summary>
		/// <param name="nicName">Name of the NIC</param>
		public static void SetDHCP( string nicName )
		{
			ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
			ManagementObjectCollection moc = mc.GetInstances();

         
			foreach(ManagementObject mo in moc)
			{
				// Make sure this is a IP enabled device. Not something like memory card or VM Ware
				if( (bool)mo["IPEnabled"] )
				{
					if( mo["Caption"].Equals( nicName ) )
					{
						ManagementBaseObject newDNS = mo.GetMethodParameters( "SetDNSServerSearchOrder" );
						newDNS[ "DNSServerSearchOrder" ] = null;
						ManagementBaseObject enableDHCP = mo.InvokeMethod( "EnableDHCP", null, null);
						ManagementBaseObject setDNS = mo.InvokeMethod( "SetDNSServerSearchOrder", newDNS, null);
					}
				}
			}
		}
		
		/// <summary>
		/// Set IP for the specified network card name
		/// </summary>
		/// <param name="nicName">Caption of the network card</param>
		/// <param name="IpAddresses">Comma delimited string containing one or more IP</param>
		/// <param name="SubnetMask">Subnet mask</param>
		/// <param name="Gateway">Gateway IP</param>
		/// <param name="DnsSearchOrder">Comma delimited DNS IP</param>
		public static void SetIP( string nicName, string IpAddresses, string SubnetMask, string Gateway, string DnsSearchOrder)
		{
            IList<Win32_NetworkAdapterConfiguration> networkCollection = null;
            NetworkAdapterConfiguration config = null;

            config = new NetworkAdapterConfiguration();
            networkCollection = config.SelectAll();

			
          foreach(Win32_NetworkAdapterConfiguration netconfig in networkCollection)
			{
				// Make sure this is a IP enabled device. Not something like memory card or VM Ware
				if( netconfig.IPEnabled )
				{
					if( netconfig.Description == nicName )
					{
                       netconfig.EnableStatic(new string[]{"192.168.1.1"}, new string[]{"255.255.255.0"});
                       netconfig.SetGateways(null, null);
                       netconfig.SetDNSServerSearchOrder(null);
                       //netconfig.SetGateways(new string[] { "192.168.2.2" }, new ushort[] { 1 });
                       netconfig.SetDNSServerSearchOrder(new string[] { "205.34.23.12" });
                       // netconfig.EnableDHCP();
                       // netconfig.SetDNSServerSearchOrder(null);
					    
                        break;
					}
				}
			}
		}

		/// <summary>
		/// Returns the network card configuration of the specified NIC
		/// </summary>
		/// <param name="nicName">Name of the NIC</param>
		/// <param name="ipAdresses">Array of IP</param>
		/// <param name="subnets">Array of subnet masks</param>
		/// <param name="gateways">Array of gateways</param>
		/// <param name="dnses">Array of DNS IP</param>
		public static void GetIP( string nicName, out string [] ipAdresses, out string [] subnets, out string [] gateways, out string [] dnses )
		{
            IList<Win32_NetworkAdapterConfiguration> networkCollection = null;
            NetworkAdapterConfiguration config = null;

            config = new NetworkAdapterConfiguration();
            networkCollection = config.SelectAll();

            ipAdresses = null;
			subnets = null;
			gateways = null;
			dnses = null;


            foreach (Win32_NetworkAdapterConfiguration netconfig in networkCollection)
            {
				// Make sure this is a IP enabled device. Not something like memory card or VM Ware
                if (netconfig.IPEnabled)
				{
					if( netconfig.Description == nicName )
					{
                        ipAdresses = netconfig.IPAddress;
                        subnets = netconfig.IPSubnet;
                        gateways = netconfig.DefaultIPGateway;
                        dnses = netconfig.DNSServerSearchOrder;
					}
				}
			}
		}

		/// <summary>
		/// Returns the list of Network Interfaces installed
		/// </summary>
		/// <returns>Array list of string</returns>
		public static ArrayList GetNICNames()
		{
			ArrayList nicNames = new ArrayList();

            IList<Win32_NetworkAdapterConfiguration> networkCollection = null;
            NetworkAdapterConfiguration config = null;
            config = new NetworkAdapterConfiguration();
            networkCollection = config.SelectAll();

            foreach (Win32_NetworkAdapterConfiguration netconfig in networkCollection)
            {
                if (netconfig.IPEnabled)
                {
					nicNames.Add( netconfig.Description);
				}
			}

			return nicNames;
		}

		#endregion
	}
}
