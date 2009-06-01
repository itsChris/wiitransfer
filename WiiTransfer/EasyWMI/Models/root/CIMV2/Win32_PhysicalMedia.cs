using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PhysicalMedia : WMIBase
    {
        
        private ulong m_Capacity;
        
        private string m_Caption;
        
        private bool m_CleanerMedia;
        
        private string m_CreationClassName;
        
        private string m_Description;
        
        private bool m_HotSwappable;
        
        private string m_InstallDate;
        
        private string m_Manufacturer;
        
        private string m_MediaDescription;
        
        private ushort m_MediaType;
        
        private string m_Model;
        
        private string m_Name;
        
        private string m_OtherIdentifyingInfo;
        
        private string m_PartNumber;
        
        private bool m_PoweredOn;
        
        private bool m_Removable;
        
        private bool m_Replaceable;
        
        private string m_SerialNumber;
        
        private string m_SKU;
        
        private string m_Status;
        
        private string m_Tag;
        
        private string m_Version;
        
        private bool m_WriteProtectOn;
        
        private string m_MyPath;
        
        public Win32_PhysicalMedia()
        {
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
        
        public bool CleanerMedia
        {
            get
            {
                return this.m_CleanerMedia;
            }
            set
            {
                this.m_CleanerMedia = value;
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
        
        public string MediaDescription
        {
            get
            {
                return this.m_MediaDescription;
            }
            set
            {
                this.m_MediaDescription = value;
            }
        }
        
        public ushort MediaType
        {
            get
            {
                return this.m_MediaType;
            }
            set
            {
                this.m_MediaType = value;
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
        
        public bool WriteProtectOn
        {
            get
            {
                return this.m_WriteProtectOn;
            }
            set
            {
                this.m_WriteProtectOn = value;
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
