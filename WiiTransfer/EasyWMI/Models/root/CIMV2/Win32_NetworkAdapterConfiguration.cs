using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_NetworkAdapterConfiguration : WMIBase
    {
        
        private bool m_ArpAlwaysSourceRoute;
        
        private bool m_ArpUseEtherSNAP;
        
        private string m_Caption;
        
        private string m_DatabasePath;
        
        private bool m_DeadGWDetectEnabled;
        
        private string [] m_DefaultIPGateway;
        
        private ushort m_DefaultTOS;
        
        private ushort m_DefaultTTL;
        
        private string m_Description;
        
        private bool m_DHCPEnabled;
        
        private string m_DHCPLeaseExpires;
        
        private string m_DHCPLeaseObtained;
        
        private string m_DHCPServer;
        
        private string m_DNSDomain;
        
        private string [] m_DNSDomainSuffixSearchOrder;
        
        private bool m_DNSEnabledForWINSResolution;
        
        private string m_DNSHostName;
        
        private string [] m_DNSServerSearchOrder;
        
        private bool m_DomainDNSRegistrationEnabled;
        
        private uint m_ForwardBufferMemory;
        
        private bool m_FullDNSRegistrationEnabled;
        
        private ushort [] m_GatewayCostMetric;
        
        private ushort m_IGMPLevel;
        
        private uint m_Index;
        
        private uint m_InterfaceIndex;
        
        private string [] m_IPAddress;
        
        private uint m_IPConnectionMetric;
        
        private bool m_IPEnabled;
        
        private bool m_IPFilterSecurityEnabled;
        
        private bool m_IPPortSecurityEnabled;
        
        private string [] m_IPSecPermitIPProtocols;
        
        private string [] m_IPSecPermitTCPPorts;
        
        private string [] m_IPSecPermitUDPPorts;
        
        private string [] m_IPSubnet;
        
        private bool m_IPUseZeroBroadcast;
        
        private string m_IPXAddress;
        
        private bool m_IPXEnabled;
        
        private uint [] m_IPXFrameType;
        
        private uint m_IPXMediaType;
        
        private string [] m_IPXNetworkNumber;
        
        private string m_IPXVirtualNetNumber;
        
        private uint m_KeepAliveInterval;
        
        private uint m_KeepAliveTime;
        
        private string m_MACAddress;
        
        private uint m_MTU;
        
        private uint m_NumForwardPackets;
        
        private bool m_PMTUBHDetectEnabled;
        
        private bool m_PMTUDiscoveryEnabled;
        
        private string m_ServiceName;
        
        private string m_SettingID;
        
        private uint m_TcpipNetbiosOptions;
        
        private uint m_TcpMaxConnectRetransmissions;
        
        private uint m_TcpMaxDataRetransmissions;
        
        private uint m_TcpNumConnections;
        
        private bool m_TcpUseRFC1122UrgentPointer;
        
        private ushort m_TcpWindowSize;
        
        private bool m_WINSEnableLMHostsLookup;
        
        private string m_WINSHostLookupFile;
        
        private string m_WINSPrimaryServer;
        
        private string m_WINSScopeID;
        
        private string m_WINSSecondaryServer;
        
        private string m_MyPath;
        
        public Win32_NetworkAdapterConfiguration()
        {
        }
        
        public bool ArpAlwaysSourceRoute
        {
            get
            {
                return this.m_ArpAlwaysSourceRoute;
            }
            set
            {
                this.m_ArpAlwaysSourceRoute = value;
            }
        }
        
        public bool ArpUseEtherSNAP
        {
            get
            {
                return this.m_ArpUseEtherSNAP;
            }
            set
            {
                this.m_ArpUseEtherSNAP = value;
            }
        }
        
        public string Caption
        {
            get
            {
                return this.m_Caption;
            }
            set
            {
                this.m_Caption = value;
            }
        }
        
        public string DatabasePath
        {
            get
            {
                return this.m_DatabasePath;
            }
            set
            {
                this.m_DatabasePath = value;
            }
        }
        
        public bool DeadGWDetectEnabled
        {
            get
            {
                return this.m_DeadGWDetectEnabled;
            }
            set
            {
                this.m_DeadGWDetectEnabled = value;
            }
        }
        
        public string [] DefaultIPGateway
        {
            get
            {
                return this.m_DefaultIPGateway;
            }
            set
            {
                this.m_DefaultIPGateway = value;
            }
        }
        
        public ushort DefaultTOS
        {
            get
            {
                return this.m_DefaultTOS;
            }
            set
            {
                this.m_DefaultTOS = value;
            }
        }
        
        public ushort DefaultTTL
        {
            get
            {
                return this.m_DefaultTTL;
            }
            set
            {
                this.m_DefaultTTL = value;
            }
        }
        
        public string Description
        {
            get
            {
                return this.m_Description;
            }
            set
            {
                this.m_Description = value;
            }
        }
        
        public bool DHCPEnabled
        {
            get
            {
                return this.m_DHCPEnabled;
            }
            set
            {
                this.m_DHCPEnabled = value;
            }
        }
        
        public string DHCPLeaseExpires
        {
            get
            {
                return this.m_DHCPLeaseExpires;
            }
            set
            {
                this.m_DHCPLeaseExpires = value;
            }
        }
        
        public string DHCPLeaseObtained
        {
            get
            {
                return this.m_DHCPLeaseObtained;
            }
            set
            {
                this.m_DHCPLeaseObtained = value;
            }
        }
        
        public string DHCPServer
        {
            get
            {
                return this.m_DHCPServer;
            }
            set
            {
                this.m_DHCPServer = value;
            }
        }
        
        public string DNSDomain
        {
            get
            {
                return this.m_DNSDomain;
            }
            set
            {
                this.m_DNSDomain = value;
            }
        }
        
        public string [] DNSDomainSuffixSearchOrder
        {
            get
            {
                return this.m_DNSDomainSuffixSearchOrder;
            }
            set
            {
                this.m_DNSDomainSuffixSearchOrder = value;
            }
        }
        
        public bool DNSEnabledForWINSResolution
        {
            get
            {
                return this.m_DNSEnabledForWINSResolution;
            }
            set
            {
                this.m_DNSEnabledForWINSResolution = value;
            }
        }
        
        public string DNSHostName
        {
            get
            {
                return this.m_DNSHostName;
            }
            set
            {
                this.m_DNSHostName = value;
            }
        }
        
        public string [] DNSServerSearchOrder
        {
            get
            {
                return this.m_DNSServerSearchOrder;
            }
            set
            {
                this.m_DNSServerSearchOrder = value;
            }
        }
        
        public bool DomainDNSRegistrationEnabled
        {
            get
            {
                return this.m_DomainDNSRegistrationEnabled;
            }
            set
            {
                this.m_DomainDNSRegistrationEnabled = value;
            }
        }
        
        public uint ForwardBufferMemory
        {
            get
            {
                return this.m_ForwardBufferMemory;
            }
            set
            {
                this.m_ForwardBufferMemory = value;
            }
        }
        
        public bool FullDNSRegistrationEnabled
        {
            get
            {
                return this.m_FullDNSRegistrationEnabled;
            }
            set
            {
                this.m_FullDNSRegistrationEnabled = value;
            }
        }
        
        public ushort [] GatewayCostMetric
        {
            get
            {
                return this.m_GatewayCostMetric;
            }
            set
            {
                this.m_GatewayCostMetric = value;
            }
        }
        
        public ushort IGMPLevel
        {
            get
            {
                return this.m_IGMPLevel;
            }
            set
            {
                this.m_IGMPLevel = value;
            }
        }
        
        public uint Index
        {
            get
            {
                return this.m_Index;
            }
            set
            {
                this.m_Index = value;
            }
        }
        
        public uint InterfaceIndex
        {
            get
            {
                return this.m_InterfaceIndex;
            }
            set
            {
                this.m_InterfaceIndex = value;
            }
        }
        
        public string [] IPAddress
        {
            get
            {
                return this.m_IPAddress;
            }
            set
            {
                this.m_IPAddress = value;
            }
        }
        
        public uint IPConnectionMetric
        {
            get
            {
                return this.m_IPConnectionMetric;
            }
            set
            {
                this.m_IPConnectionMetric = value;
            }
        }
        
        public bool IPEnabled
        {
            get
            {
                return this.m_IPEnabled;
            }
            set
            {
                this.m_IPEnabled = value;
            }
        }
        
        public bool IPFilterSecurityEnabled
        {
            get
            {
                return this.m_IPFilterSecurityEnabled;
            }
            set
            {
                this.m_IPFilterSecurityEnabled = value;
            }
        }
        
        public bool IPPortSecurityEnabled
        {
            get
            {
                return this.m_IPPortSecurityEnabled;
            }
            set
            {
                this.m_IPPortSecurityEnabled = value;
            }
        }
        
        public string [] IPSecPermitIPProtocols
        {
            get
            {
                return this.m_IPSecPermitIPProtocols;
            }
            set
            {
                this.m_IPSecPermitIPProtocols = value;
            }
        }
        
        public string [] IPSecPermitTCPPorts
        {
            get
            {
                return this.m_IPSecPermitTCPPorts;
            }
            set
            {
                this.m_IPSecPermitTCPPorts = value;
            }
        }
        
        public string [] IPSecPermitUDPPorts
        {
            get
            {
                return this.m_IPSecPermitUDPPorts;
            }
            set
            {
                this.m_IPSecPermitUDPPorts = value;
            }
        }
        
        public string [] IPSubnet
        {
            get
            {
                return this.m_IPSubnet;
            }
            set
            {
                this.m_IPSubnet = value;
            }
        }
        
        public bool IPUseZeroBroadcast
        {
            get
            {
                return this.m_IPUseZeroBroadcast;
            }
            set
            {
                this.m_IPUseZeroBroadcast = value;
            }
        }
        
        public string IPXAddress
        {
            get
            {
                return this.m_IPXAddress;
            }
            set
            {
                this.m_IPXAddress = value;
            }
        }
        
        public bool IPXEnabled
        {
            get
            {
                return this.m_IPXEnabled;
            }
            set
            {
                this.m_IPXEnabled = value;
            }
        }
        
        public uint [] IPXFrameType
        {
            get
            {
                return this.m_IPXFrameType;
            }
            set
            {
                this.m_IPXFrameType = value;
            }
        }
        
        public uint IPXMediaType
        {
            get
            {
                return this.m_IPXMediaType;
            }
            set
            {
                this.m_IPXMediaType = value;
            }
        }
        
        public string [] IPXNetworkNumber
        {
            get
            {
                return this.m_IPXNetworkNumber;
            }
            set
            {
                this.m_IPXNetworkNumber = value;
            }
        }
        
        public string IPXVirtualNetNumber
        {
            get
            {
                return this.m_IPXVirtualNetNumber;
            }
            set
            {
                this.m_IPXVirtualNetNumber = value;
            }
        }
        
        public uint KeepAliveInterval
        {
            get
            {
                return this.m_KeepAliveInterval;
            }
            set
            {
                this.m_KeepAliveInterval = value;
            }
        }
        
        public uint KeepAliveTime
        {
            get
            {
                return this.m_KeepAliveTime;
            }
            set
            {
                this.m_KeepAliveTime = value;
            }
        }
        
        public string MACAddress
        {
            get
            {
                return this.m_MACAddress;
            }
            set
            {
                this.m_MACAddress = value;
            }
        }
        
        public uint MTU
        {
            get
            {
                return this.m_MTU;
            }
            set
            {
                this.m_MTU = value;
            }
        }
        
        public uint NumForwardPackets
        {
            get
            {
                return this.m_NumForwardPackets;
            }
            set
            {
                this.m_NumForwardPackets = value;
            }
        }
        
        public bool PMTUBHDetectEnabled
        {
            get
            {
                return this.m_PMTUBHDetectEnabled;
            }
            set
            {
                this.m_PMTUBHDetectEnabled = value;
            }
        }
        
        public bool PMTUDiscoveryEnabled
        {
            get
            {
                return this.m_PMTUDiscoveryEnabled;
            }
            set
            {
                this.m_PMTUDiscoveryEnabled = value;
            }
        }
        
        public string ServiceName
        {
            get
            {
                return this.m_ServiceName;
            }
            set
            {
                this.m_ServiceName = value;
            }
        }
        
        public string SettingID
        {
            get
            {
                return this.m_SettingID;
            }
            set
            {
                this.m_SettingID = value;
            }
        }
        
        public uint TcpipNetbiosOptions
        {
            get
            {
                return this.m_TcpipNetbiosOptions;
            }
            set
            {
                this.m_TcpipNetbiosOptions = value;
            }
        }
        
        public uint TcpMaxConnectRetransmissions
        {
            get
            {
                return this.m_TcpMaxConnectRetransmissions;
            }
            set
            {
                this.m_TcpMaxConnectRetransmissions = value;
            }
        }
        
        public uint TcpMaxDataRetransmissions
        {
            get
            {
                return this.m_TcpMaxDataRetransmissions;
            }
            set
            {
                this.m_TcpMaxDataRetransmissions = value;
            }
        }
        
        public uint TcpNumConnections
        {
            get
            {
                return this.m_TcpNumConnections;
            }
            set
            {
                this.m_TcpNumConnections = value;
            }
        }
        
        public bool TcpUseRFC1122UrgentPointer
        {
            get
            {
                return this.m_TcpUseRFC1122UrgentPointer;
            }
            set
            {
                this.m_TcpUseRFC1122UrgentPointer = value;
            }
        }
        
        public ushort TcpWindowSize
        {
            get
            {
                return this.m_TcpWindowSize;
            }
            set
            {
                this.m_TcpWindowSize = value;
            }
        }
        
        public bool WINSEnableLMHostsLookup
        {
            get
            {
                return this.m_WINSEnableLMHostsLookup;
            }
            set
            {
                this.m_WINSEnableLMHostsLookup = value;
            }
        }
        
        public string WINSHostLookupFile
        {
            get
            {
                return this.m_WINSHostLookupFile;
            }
            set
            {
                this.m_WINSHostLookupFile = value;
            }
        }
        
        public string WINSPrimaryServer
        {
            get
            {
                return this.m_WINSPrimaryServer;
            }
            set
            {
                this.m_WINSPrimaryServer = value;
            }
        }
        
        public string WINSScopeID
        {
            get
            {
                return this.m_WINSScopeID;
            }
            set
            {
                this.m_WINSScopeID = value;
            }
        }
        
        public string WINSSecondaryServer
        {
            get
            {
                return this.m_WINSSecondaryServer;
            }
            set
            {
                this.m_WINSSecondaryServer = value;
            }
        }
        
        public string MyPath
        {
            get
            {
                return this.m_MyPath;
            }
            set
            {
                this.m_MyPath = value;
            }
        }
        
        public Int32 EnableDHCP()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "EnableDHCP", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 RenewDHCPLease()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "RenewDHCPLease", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 RenewDHCPLeaseAll()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "RenewDHCPLeaseAll", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 ReleaseDHCPLease()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "ReleaseDHCPLease", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 ReleaseDHCPLeaseAll()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "ReleaseDHCPLeaseAll", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 EnableStatic(string [] IPAddress, string [] SubnetMask)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("EnableStatic");
InParams["IPAddress"] = IPAddress;
InParams["SubnetMask"] = SubnetMask;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "EnableStatic", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetGateways(string [] DefaultIPGateway, ushort [] GatewayCostMetric)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetGateways");
InParams["DefaultIPGateway"] = DefaultIPGateway;
InParams["GatewayCostMetric"] = GatewayCostMetric;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetGateways", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 EnableDNS(string DNSDomain, string [] DNSDomainSuffixSearchOrder, string DNSHostName, string [] DNSServerSearchOrder)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("EnableDNS");
InParams["DNSDomain"] = DNSDomain;
InParams["DNSDomainSuffixSearchOrder"] = DNSDomainSuffixSearchOrder;
InParams["DNSHostName"] = DNSHostName;
InParams["DNSServerSearchOrder"] = DNSServerSearchOrder;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "EnableDNS", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetDNSDomain(string DNSDomain)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetDNSDomain");
InParams["DNSDomain"] = DNSDomain;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetDNSDomain", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetDNSServerSearchOrder(string [] DNSServerSearchOrder)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetDNSServerSearchOrder");
InParams["DNSServerSearchOrder"] = DNSServerSearchOrder;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetDNSServerSearchOrder", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetDNSSuffixSearchOrder(string [] DNSDomainSuffixSearchOrder)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetDNSSuffixSearchOrder");
InParams["DNSDomainSuffixSearchOrder"] = DNSDomainSuffixSearchOrder;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetDNSSuffixSearchOrder", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetDynamicDNSRegistration(bool DomainDNSRegistrationEnabled, bool FullDNSRegistrationEnabled)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetDynamicDNSRegistration");
InParams["DomainDNSRegistrationEnabled"] = DomainDNSRegistrationEnabled;
InParams["FullDNSRegistrationEnabled"] = FullDNSRegistrationEnabled;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetDynamicDNSRegistration", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetIPConnectionMetric(uint IPConnectionMetric)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetIPConnectionMetric");
InParams["IPConnectionMetric"] = IPConnectionMetric;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetIPConnectionMetric", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetWINSServer(string WINSPrimaryServer, string WINSSecondaryServer)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetWINSServer");
InParams["WINSPrimaryServer"] = WINSPrimaryServer;
InParams["WINSSecondaryServer"] = WINSSecondaryServer;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetWINSServer", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 EnableWINS(bool DNSEnabledForWINSResolution, bool WINSEnableLMHostsLookup, string WINSHostLookupFile, string WINSScopeID)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("EnableWINS");
InParams["DNSEnabledForWINSResolution"] = DNSEnabledForWINSResolution;
InParams["WINSEnableLMHostsLookup"] = WINSEnableLMHostsLookup;
InParams["WINSHostLookupFile"] = WINSHostLookupFile;
InParams["WINSScopeID"] = WINSScopeID;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "EnableWINS", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetTcpipNetbios(uint TcpipNetbiosOptions)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetTcpipNetbios");
InParams["TcpipNetbiosOptions"] = TcpipNetbiosOptions;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetTcpipNetbios", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 EnableIPSec(string [] IPSecPermitIPProtocols, string [] IPSecPermitTCPPorts, string [] IPSecPermitUDPPorts)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("EnableIPSec");
InParams["IPSecPermitIPProtocols"] = IPSecPermitIPProtocols;
InParams["IPSecPermitTCPPorts"] = IPSecPermitTCPPorts;
InParams["IPSecPermitUDPPorts"] = IPSecPermitUDPPorts;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "EnableIPSec", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 DisableIPSec()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "DisableIPSec", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetIPXVirtualNetworkNumber(string IPXVirtualNetNumber)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetIPXVirtualNetworkNumber");
InParams["IPXVirtualNetNumber"] = IPXVirtualNetNumber;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetIPXVirtualNetworkNumber", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetIPXFrameTypeNetworkPairs(uint [] IPXFrameType, string [] IPXNetworkNumber)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetIPXFrameTypeNetworkPairs");
InParams["IPXFrameType"] = IPXFrameType;
InParams["IPXNetworkNumber"] = IPXNetworkNumber;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetIPXFrameTypeNetworkPairs", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetDatabasePath(string DatabasePath)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetDatabasePath");
InParams["DatabasePath"] = DatabasePath;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetDatabasePath", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetIPUseZeroBroadcast(bool IPUseZeroBroadcast)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetIPUseZeroBroadcast");
InParams["IPUseZeroBroadcast"] = IPUseZeroBroadcast;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetIPUseZeroBroadcast", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetArpAlwaysSourceRoute(bool ArpAlwaysSourceRoute)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetArpAlwaysSourceRoute");
InParams["ArpAlwaysSourceRoute"] = ArpAlwaysSourceRoute;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetArpAlwaysSourceRoute", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetArpUseEtherSNAP(bool ArpUseEtherSNAP)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetArpUseEtherSNAP");
InParams["ArpUseEtherSNAP"] = ArpUseEtherSNAP;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetArpUseEtherSNAP", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetDefaultTOS(UInt16 DefaultTOS)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetDefaultTOS");
InParams["DefaultTOS"] = DefaultTOS;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetDefaultTOS", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetDefaultTTL(UInt16 DefaultTTL)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetDefaultTTL");
InParams["DefaultTTL"] = DefaultTTL;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetDefaultTTL", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetDeadGWDetect(bool DeadGWDetectEnabled)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetDeadGWDetect");
InParams["DeadGWDetectEnabled"] = DeadGWDetectEnabled;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetDeadGWDetect", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetPMTUBHDetect(bool PMTUBHDetectEnabled)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetPMTUBHDetect");
InParams["PMTUBHDetectEnabled"] = PMTUBHDetectEnabled;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetPMTUBHDetect", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetPMTUDiscovery(bool PMTUDiscoveryEnabled)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetPMTUDiscovery");
InParams["PMTUDiscoveryEnabled"] = PMTUDiscoveryEnabled;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetPMTUDiscovery", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetForwardBufferMemory(uint ForwardBufferMemory)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetForwardBufferMemory");
InParams["ForwardBufferMemory"] = ForwardBufferMemory;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetForwardBufferMemory", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetIGMPLevel(UInt16 IGMPLevel)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetIGMPLevel");
InParams["IGMPLevel"] = IGMPLevel;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetIGMPLevel", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetKeepAliveInterval(uint KeepAliveInterval)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetKeepAliveInterval");
InParams["KeepAliveInterval"] = KeepAliveInterval;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetKeepAliveInterval", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetKeepAliveTime(uint KeepAliveTime)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetKeepAliveTime");
InParams["KeepAliveTime"] = KeepAliveTime;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetKeepAliveTime", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetMTU(uint MTU)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetMTU");
InParams["MTU"] = MTU;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetMTU", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetNumForwardPackets(uint NumForwardPackets)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetNumForwardPackets");
InParams["NumForwardPackets"] = NumForwardPackets;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetNumForwardPackets", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetTcpMaxConnectRetransmissions(uint TcpMaxConnectRetransmissions)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetTcpMaxConnectRetransmissions");
InParams["TcpMaxConnectRetransmissions"] = TcpMaxConnectRetransmissions;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetTcpMaxConnectRetransmissions", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetTcpMaxDataRetransmissions(uint TcpMaxDataRetransmissions)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetTcpMaxDataRetransmissions");
InParams["TcpMaxDataRetransmissions"] = TcpMaxDataRetransmissions;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetTcpMaxDataRetransmissions", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetTcpNumConnections(uint TcpNumConnections)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetTcpNumConnections");
InParams["TcpNumConnections"] = TcpNumConnections;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetTcpNumConnections", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetTcpUseRFC1122UrgentPointer(bool TcpUseRFC1122UrgentPointer)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetTcpUseRFC1122UrgentPointer");
InParams["TcpUseRFC1122UrgentPointer"] = TcpUseRFC1122UrgentPointer;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetTcpUseRFC1122UrgentPointer", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 SetTcpWindowSize(ushort TcpWindowSize)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetTcpWindowSize");
InParams["TcpWindowSize"] = TcpWindowSize;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetTcpWindowSize", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 EnableIPFilterSec(bool IPFilterSecurityEnabled)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("EnableIPFilterSec");
InParams["IPFilterSecurityEnabled"] = IPFilterSecurityEnabled;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "EnableIPFilterSec", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
    }
}
