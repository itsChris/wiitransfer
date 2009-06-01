using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_DMAChannel : WMIBase
    {
        
        private ushort m_AddressSize;
        
        private ushort m_Availability;
        
        private bool m_BurstMode;
        
        private ushort m_ByteMode;
        
        private string m_Caption;
        
        private ushort m_ChannelTiming;
        
        private string m_CreationClassName;
        
        private string m_CSCreationClassName;
        
        private string m_CSName;
        
        private string m_Description;
        
        private uint m_DMAChannel;
        
        private string m_InstallDate;
        
        private uint m_MaxTransferSize;
        
        private string m_Name;
        
        private uint m_Port;
        
        private string m_Status;
        
        private ushort [] m_TransferWidths;
        
        private ushort m_TypeCTiming;
        
        private ushort m_WordMode;
        
        private string m_MyPath;
        
        public Win32_DMAChannel()
        {
        }
        
        public ushort AddressSize
        {
            get
            {
                return this.m_AddressSize;
            }
            set
            {
                this.m_AddressSize = value;
            }
        }
        
        public ushort Availability
        {
            get
            {
                return this.m_Availability;
            }
            set
            {
                this.m_Availability = value;
            }
        }
        
        public bool BurstMode
        {
            get
            {
                return this.m_BurstMode;
            }
            set
            {
                this.m_BurstMode = value;
            }
        }
        
        public ushort ByteMode
        {
            get
            {
                return this.m_ByteMode;
            }
            set
            {
                this.m_ByteMode = value;
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
        
        public ushort ChannelTiming
        {
            get
            {
                return this.m_ChannelTiming;
            }
            set
            {
                this.m_ChannelTiming = value;
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
        
        public string CSCreationClassName
        {
            get
            {
                return this.m_CSCreationClassName;
            }
            set
            {
                this.m_CSCreationClassName = value;
            }
        }
        
        public string CSName
        {
            get
            {
                return this.m_CSName;
            }
            set
            {
                this.m_CSName = value;
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
        
        public uint DMAChannel
        {
            get
            {
                return this.m_DMAChannel;
            }
            set
            {
                this.m_DMAChannel = value;
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
        
        public uint MaxTransferSize
        {
            get
            {
                return this.m_MaxTransferSize;
            }
            set
            {
                this.m_MaxTransferSize = value;
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
        
        public uint Port
        {
            get
            {
                return this.m_Port;
            }
            set
            {
                this.m_Port = value;
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
        
        public ushort [] TransferWidths
        {
            get
            {
                return this.m_TransferWidths;
            }
            set
            {
                this.m_TransferWidths = value;
            }
        }
        
        public ushort TypeCTiming
        {
            get
            {
                return this.m_TypeCTiming;
            }
            set
            {
                this.m_TypeCTiming = value;
            }
        }
        
        public ushort WordMode
        {
            get
            {
                return this.m_WordMode;
            }
            set
            {
                this.m_WordMode = value;
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
