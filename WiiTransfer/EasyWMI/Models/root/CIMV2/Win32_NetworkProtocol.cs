using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_NetworkProtocol : WMIBase
    {
        
        private string m_Caption;
        
        private bool m_ConnectionlessService;
        
        private string m_Description;
        
        private bool m_GuaranteesDelivery;
        
        private bool m_GuaranteesSequencing;
        
        private string m_InstallDate;
        
        private uint m_MaximumAddressSize;
        
        private uint m_MaximumMessageSize;
        
        private bool m_MessageOriented;
        
        private uint m_MinimumAddressSize;
        
        private string m_Name;
        
        private bool m_PseudoStreamOriented;
        
        private string m_Status;
        
        private bool m_SupportsBroadcasting;
        
        private bool m_SupportsConnectData;
        
        private bool m_SupportsDisconnectData;
        
        private bool m_SupportsEncryption;
        
        private bool m_SupportsExpeditedData;
        
        private bool m_SupportsFragmentation;
        
        private bool m_SupportsGracefulClosing;
        
        private bool m_SupportsGuaranteedBandwidth;
        
        private bool m_SupportsMulticasting;
        
        private bool m_SupportsQualityofService;
        
        private string m_MyPath;
        
        public Win32_NetworkProtocol()
        {
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
        
        public bool ConnectionlessService
        {
            get
            {
                return this.m_ConnectionlessService;
            }
            set
            {
                this.m_ConnectionlessService = value;
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
        
        public bool GuaranteesDelivery
        {
            get
            {
                return this.m_GuaranteesDelivery;
            }
            set
            {
                this.m_GuaranteesDelivery = value;
            }
        }
        
        public bool GuaranteesSequencing
        {
            get
            {
                return this.m_GuaranteesSequencing;
            }
            set
            {
                this.m_GuaranteesSequencing = value;
            }
        }
        
        public string InstallDate
        {
            get
            {
                return this.m_InstallDate;
            }
            set
            {
                this.m_InstallDate = value;
            }
        }
        
        public uint MaximumAddressSize
        {
            get
            {
                return this.m_MaximumAddressSize;
            }
            set
            {
                this.m_MaximumAddressSize = value;
            }
        }
        
        public uint MaximumMessageSize
        {
            get
            {
                return this.m_MaximumMessageSize;
            }
            set
            {
                this.m_MaximumMessageSize = value;
            }
        }
        
        public bool MessageOriented
        {
            get
            {
                return this.m_MessageOriented;
            }
            set
            {
                this.m_MessageOriented = value;
            }
        }
        
        public uint MinimumAddressSize
        {
            get
            {
                return this.m_MinimumAddressSize;
            }
            set
            {
                this.m_MinimumAddressSize = value;
            }
        }
        
        public string Name
        {
            get
            {
                return this.m_Name;
            }
            set
            {
                this.m_Name = value;
            }
        }
        
        public bool PseudoStreamOriented
        {
            get
            {
                return this.m_PseudoStreamOriented;
            }
            set
            {
                this.m_PseudoStreamOriented = value;
            }
        }
        
        public string Status
        {
            get
            {
                return this.m_Status;
            }
            set
            {
                this.m_Status = value;
            }
        }
        
        public bool SupportsBroadcasting
        {
            get
            {
                return this.m_SupportsBroadcasting;
            }
            set
            {
                this.m_SupportsBroadcasting = value;
            }
        }
        
        public bool SupportsConnectData
        {
            get
            {
                return this.m_SupportsConnectData;
            }
            set
            {
                this.m_SupportsConnectData = value;
            }
        }
        
        public bool SupportsDisconnectData
        {
            get
            {
                return this.m_SupportsDisconnectData;
            }
            set
            {
                this.m_SupportsDisconnectData = value;
            }
        }
        
        public bool SupportsEncryption
        {
            get
            {
                return this.m_SupportsEncryption;
            }
            set
            {
                this.m_SupportsEncryption = value;
            }
        }
        
        public bool SupportsExpeditedData
        {
            get
            {
                return this.m_SupportsExpeditedData;
            }
            set
            {
                this.m_SupportsExpeditedData = value;
            }
        }
        
        public bool SupportsFragmentation
        {
            get
            {
                return this.m_SupportsFragmentation;
            }
            set
            {
                this.m_SupportsFragmentation = value;
            }
        }
        
        public bool SupportsGracefulClosing
        {
            get
            {
                return this.m_SupportsGracefulClosing;
            }
            set
            {
                this.m_SupportsGracefulClosing = value;
            }
        }
        
        public bool SupportsGuaranteedBandwidth
        {
            get
            {
                return this.m_SupportsGuaranteedBandwidth;
            }
            set
            {
                this.m_SupportsGuaranteedBandwidth = value;
            }
        }
        
        public bool SupportsMulticasting
        {
            get
            {
                return this.m_SupportsMulticasting;
            }
            set
            {
                this.m_SupportsMulticasting = value;
            }
        }
        
        public bool SupportsQualityofService
        {
            get
            {
                return this.m_SupportsQualityofService;
            }
            set
            {
                this.m_SupportsQualityofService = value;
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
    }
}
