using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_PortConnector : WMIBase
    {
        
        private string m_Caption;
        
        private string m_ConnectorPinout;
        
        private ushort [] m_ConnectorType;
        
        private string m_CreationClassName;
        
        private string m_Description;
        
        private string m_ExternalReferenceDesignator;
        
        private string m_InstallDate;
        
        private string m_InternalReferenceDesignator;
        
        private string m_Manufacturer;
        
        private string m_Model;
        
        private string m_Name;
        
        private string m_OtherIdentifyingInfo;
        
        private string m_PartNumber;
        
        private ushort m_PortType;
        
        private bool m_PoweredOn;
        
        private string m_SerialNumber;
        
        private string m_SKU;
        
        private string m_Status;
        
        private string m_Tag;
        
        private string m_Version;
        
        private string m_MyPath;
        
        public Win32_PortConnector()
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
        
        public string ConnectorPinout
        {
            get
            {
                return this.m_ConnectorPinout;
            }
            set
            {
                this.m_ConnectorPinout = value;
            }
        }
        
        public ushort [] ConnectorType
        {
            get
            {
                return this.m_ConnectorType;
            }
            set
            {
                this.m_ConnectorType = value;
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
        
        public string ExternalReferenceDesignator
        {
            get
            {
                return this.m_ExternalReferenceDesignator;
            }
            set
            {
                this.m_ExternalReferenceDesignator = value;
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
        
        public string InternalReferenceDesignator
        {
            get
            {
                return this.m_InternalReferenceDesignator;
            }
            set
            {
                this.m_InternalReferenceDesignator = value;
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
        
        public ushort PortType
        {
            get
            {
                return this.m_PortType;
            }
            set
            {
                this.m_PortType = value;
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
