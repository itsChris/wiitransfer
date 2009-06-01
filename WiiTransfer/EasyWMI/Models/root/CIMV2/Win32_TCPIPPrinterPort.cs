using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_TCPIPPrinterPort : WMIBase
    {
        
        private bool m_ByteCount;
        
        private string m_Caption;
        
        private string m_CreationClassName;
        
        private string m_Description;
        
        private string m_HostAddress;
        
        private string m_InstallDate;
        
        private string m_Name;
        
        private uint m_PortNumber;
        
        private uint m_Protocol;
        
        private string m_Queue;
        
        private string m_SNMPCommunity;
        
        private uint m_SNMPDevIndex;
        
        private bool m_SNMPEnabled;
        
        private string m_Status;
        
        private string m_SystemCreationClassName;
        
        private string m_SystemName;
        
        private uint m_Type;
        
        private string m_MyPath;
        
        public Win32_TCPIPPrinterPort()
        {
        }
        
        public bool ByteCount
        {
            get
            {
                return this.m_ByteCount;
            }
            set
            {
                this.m_ByteCount = value;
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
        
        public string CreationClassName
        {
            get
            {
                return this.m_CreationClassName;
            }
            set
            {
                this.m_CreationClassName = value;
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
        
        public string HostAddress
        {
            get
            {
                return this.m_HostAddress;
            }
            set
            {
                this.m_HostAddress = value;
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
        
        public uint PortNumber
        {
            get
            {
                return this.m_PortNumber;
            }
            set
            {
                this.m_PortNumber = value;
            }
        }
        
        public uint Protocol
        {
            get
            {
                return this.m_Protocol;
            }
            set
            {
                this.m_Protocol = value;
            }
        }
        
        public string Queue
        {
            get
            {
                return this.m_Queue;
            }
            set
            {
                this.m_Queue = value;
            }
        }
        
        public string SNMPCommunity
        {
            get
            {
                return this.m_SNMPCommunity;
            }
            set
            {
                this.m_SNMPCommunity = value;
            }
        }
        
        public uint SNMPDevIndex
        {
            get
            {
                return this.m_SNMPDevIndex;
            }
            set
            {
                this.m_SNMPDevIndex = value;
            }
        }
        
        public bool SNMPEnabled
        {
            get
            {
                return this.m_SNMPEnabled;
            }
            set
            {
                this.m_SNMPEnabled = value;
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
        
        public string SystemCreationClassName
        {
            get
            {
                return this.m_SystemCreationClassName;
            }
            set
            {
                this.m_SystemCreationClassName = value;
            }
        }
        
        public string SystemName
        {
            get
            {
                return this.m_SystemName;
            }
            set
            {
                this.m_SystemName = value;
            }
        }
        
        public uint Type
        {
            get
            {
                return this.m_Type;
            }
            set
            {
                this.m_Type = value;
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
