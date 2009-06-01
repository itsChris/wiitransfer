using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_SystemSlot : WMIBase
    {
        
        private string m_Caption;
        
        private string m_ConnectorPinout;
        
        private ushort [] m_ConnectorType;
        
        private string m_CreationClassName;
        
        private ushort m_CurrentUsage;
        
        private string m_Description;
        
        private double m_HeightAllowed;
        
        private string m_InstallDate;
        
        private double m_LengthAllowed;
        
        private string m_Manufacturer;
        
        private ushort m_MaxDataWidth;
        
        private string m_Model;
        
        private string m_Name;
        
        private ushort m_Number;
        
        private string m_OtherIdentifyingInfo;
        
        private string m_PartNumber;
        
        private bool m_PMESignal;
        
        private bool m_PoweredOn;
        
        private string m_PurposeDescription;
        
        private string m_SerialNumber;
        
        private bool m_Shared;
        
        private string m_SKU;
        
        private string m_SlotDesignation;
        
        private bool m_SpecialPurpose;
        
        private string m_Status;
        
        private bool m_SupportsHotPlug;
        
        private string m_Tag;
        
        private uint m_ThermalRating;
        
        private ushort [] m_VccMixedVoltageSupport;
        
        private string m_Version;
        
        private ushort [] m_VppMixedVoltageSupport;
        
        private string m_MyPath;
        
        public Win32_SystemSlot()
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
        
        public ushort CurrentUsage
        {
            get
            {
                return this.m_CurrentUsage;
            }
            set
            {
                this.m_CurrentUsage = value;
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
        
        public double HeightAllowed
        {
            get
            {
                return this.m_HeightAllowed;
            }
            set
            {
                this.m_HeightAllowed = value;
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
        
        public double LengthAllowed
        {
            get
            {
                return this.m_LengthAllowed;
            }
            set
            {
                this.m_LengthAllowed = value;
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
        
        public ushort MaxDataWidth
        {
            get
            {
                return this.m_MaxDataWidth;
            }
            set
            {
                this.m_MaxDataWidth = value;
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
        
        public ushort Number
        {
            get
            {
                return this.m_Number;
            }
            set
            {
                this.m_Number = value;
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
        
        public bool PMESignal
        {
            get
            {
                return this.m_PMESignal;
            }
            set
            {
                this.m_PMESignal = value;
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
        
        public string PurposeDescription
        {
            get
            {
                return this.m_PurposeDescription;
            }
            set
            {
                this.m_PurposeDescription = value;
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
        
        public bool Shared
        {
            get
            {
                return this.m_Shared;
            }
            set
            {
                this.m_Shared = value;
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
        
        public string SlotDesignation
        {
            get
            {
                return this.m_SlotDesignation;
            }
            set
            {
                this.m_SlotDesignation = value;
            }
        }
        
        public bool SpecialPurpose
        {
            get
            {
                return this.m_SpecialPurpose;
            }
            set
            {
                this.m_SpecialPurpose = value;
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
        
        public bool SupportsHotPlug
        {
            get
            {
                return this.m_SupportsHotPlug;
            }
            set
            {
                this.m_SupportsHotPlug = value;
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
        
        public uint ThermalRating
        {
            get
            {
                return this.m_ThermalRating;
            }
            set
            {
                this.m_ThermalRating = value;
            }
        }
        
        public ushort [] VccMixedVoltageSupport
        {
            get
            {
                return this.m_VccMixedVoltageSupport;
            }
            set
            {
                this.m_VccMixedVoltageSupport = value;
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
        
        public ushort [] VppMixedVoltageSupport
        {
            get
            {
                return this.m_VppMixedVoltageSupport;
            }
            set
            {
                this.m_VppMixedVoltageSupport = value;
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
