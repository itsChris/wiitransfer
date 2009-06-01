using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PhysicalMemory : WMIBase
    {
        
        private string m_BankLabel;
        
        private ulong m_Capacity;
        
        private string m_Caption;
        
        private string m_CreationClassName;
        
        private ushort m_DataWidth;
        
        private string m_Description;
        
        private string m_DeviceLocator;
        
        private ushort m_FormFactor;
        
        private bool m_HotSwappable;
        
        private string m_InstallDate;
        
        private ushort m_InterleaveDataDepth;
        
        private uint m_InterleavePosition;
        
        private string m_Manufacturer;
        
        private ushort m_MemoryType;
        
        private string m_Model;
        
        private string m_Name;
        
        private string m_OtherIdentifyingInfo;
        
        private string m_PartNumber;
        
        private uint m_PositionInRow;
        
        private bool m_PoweredOn;
        
        private bool m_Removable;
        
        private bool m_Replaceable;
        
        private string m_SerialNumber;
        
        private string m_SKU;
        
        private uint m_Speed;
        
        private string m_Status;
        
        private string m_Tag;
        
        private ushort m_TotalWidth;
        
        private ushort m_TypeDetail;
        
        private string m_Version;
        
        private string m_MyPath;
        
        public Win32_PhysicalMemory()
        {
        }
        
        public string BankLabel
        {
            get
            {
                return this.m_BankLabel;
            }
            set
            {
                this.m_BankLabel = value;
            }
        }
        
        public ulong Capacity
        {
            get
            {
                return this.m_Capacity;
            }
            set
            {
                this.m_Capacity = value;
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
        
        public ushort DataWidth
        {
            get
            {
                return this.m_DataWidth;
            }
            set
            {
                this.m_DataWidth = value;
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
        
        public string DeviceLocator
        {
            get
            {
                return this.m_DeviceLocator;
            }
            set
            {
                this.m_DeviceLocator = value;
            }
        }
        
        public ushort FormFactor
        {
            get
            {
                return this.m_FormFactor;
            }
            set
            {
                this.m_FormFactor = value;
            }
        }
        
        public bool HotSwappable
        {
            get
            {
                return this.m_HotSwappable;
            }
            set
            {
                this.m_HotSwappable = value;
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
        
        public ushort InterleaveDataDepth
        {
            get
            {
                return this.m_InterleaveDataDepth;
            }
            set
            {
                this.m_InterleaveDataDepth = value;
            }
        }
        
        public uint InterleavePosition
        {
            get
            {
                return this.m_InterleavePosition;
            }
            set
            {
                this.m_InterleavePosition = value;
            }
        }
        
        public string Manufacturer
        {
            get
            {
                return this.m_Manufacturer;
            }
            set
            {
                this.m_Manufacturer = value;
            }
        }
        
        public ushort MemoryType
        {
            get
            {
                return this.m_MemoryType;
            }
            set
            {
                this.m_MemoryType = value;
            }
        }
        
        public string Model
        {
            get
            {
                return this.m_Model;
            }
            set
            {
                this.m_Model = value;
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
        
        public string OtherIdentifyingInfo
        {
            get
            {
                return this.m_OtherIdentifyingInfo;
            }
            set
            {
                this.m_OtherIdentifyingInfo = value;
            }
        }
        
        public string PartNumber
        {
            get
            {
                return this.m_PartNumber;
            }
            set
            {
                this.m_PartNumber = value;
            }
        }
        
        public uint PositionInRow
        {
            get
            {
                return this.m_PositionInRow;
            }
            set
            {
                this.m_PositionInRow = value;
            }
        }
        
        public bool PoweredOn
        {
            get
            {
                return this.m_PoweredOn;
            }
            set
            {
                this.m_PoweredOn = value;
            }
        }
        
        public bool Removable
        {
            get
            {
                return this.m_Removable;
            }
            set
            {
                this.m_Removable = value;
            }
        }
        
        public bool Replaceable
        {
            get
            {
                return this.m_Replaceable;
            }
            set
            {
                this.m_Replaceable = value;
            }
        }
        
        public string SerialNumber
        {
            get
            {
                return this.m_SerialNumber;
            }
            set
            {
                this.m_SerialNumber = value;
            }
        }
        
        public string SKU
        {
            get
            {
                return this.m_SKU;
            }
            set
            {
                this.m_SKU = value;
            }
        }
        
        public uint Speed
        {
            get
            {
                return this.m_Speed;
            }
            set
            {
                this.m_Speed = value;
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
        
        public string Tag
        {
            get
            {
                return this.m_Tag;
            }
            set
            {
                this.m_Tag = value;
            }
        }
        
        public ushort TotalWidth
        {
            get
            {
                return this.m_TotalWidth;
            }
            set
            {
                this.m_TotalWidth = value;
            }
        }
        
        public ushort TypeDetail
        {
            get
            {
                return this.m_TypeDetail;
            }
            set
            {
                this.m_TypeDetail = value;
            }
        }
        
        public string Version
        {
            get
            {
                return this.m_Version;
            }
            set
            {
                this.m_Version = value;
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
