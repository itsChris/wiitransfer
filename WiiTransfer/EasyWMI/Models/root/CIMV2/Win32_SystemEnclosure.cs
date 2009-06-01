using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_SystemEnclosure : WMIBase
    {
        
        private bool m_AudibleAlarm;
        
        private string m_BreachDescription;
        
        private string m_CableManagementStrategy;
        
        private string m_Caption;
        
        private ushort [] m_ChassisTypes;
        
        private string m_CreationClassName;
        
        private short m_CurrentRequiredOrProduced;
        
        private double m_Depth;
        
        private string m_Description;
        
        private ushort m_HeatGeneration;
        
        private double m_Height;
        
        private bool m_HotSwappable;
        
        private string m_InstallDate;
        
        private bool m_LockPresent;
        
        private string m_Manufacturer;
        
        private string m_Model;
        
        private string m_Name;
        
        private ushort m_NumberOfPowerCords;
        
        private string m_OtherIdentifyingInfo;
        
        private string m_PartNumber;
        
        private bool m_PoweredOn;
        
        private bool m_Removable;
        
        private bool m_Replaceable;
        
        private ushort m_SecurityBreach;
        
        private ushort m_SecurityStatus;
        
        private string m_SerialNumber;
        
        private string [] m_ServiceDescriptions;
        
        private ushort [] m_ServicePhilosophy;
        
        private string m_SKU;
        
        private string m_SMBIOSAssetTag;
        
        private string m_Status;
        
        private string m_Tag;
        
        private string [] m_TypeDescriptions;
        
        private string m_Version;
        
        private bool m_VisibleAlarm;
        
        private double m_Weight;
        
        private double m_Width;
        
        private string m_MyPath;
        
        public Win32_SystemEnclosure()
        {
        }
        
        public bool AudibleAlarm
        {
            get
            {
                return this.m_AudibleAlarm;
            }
            set
            {
                this.m_AudibleAlarm = value;
            }
        }
        
        public string BreachDescription
        {
            get
            {
                return this.m_BreachDescription;
            }
            set
            {
                this.m_BreachDescription = value;
            }
        }
        
        public string CableManagementStrategy
        {
            get
            {
                return this.m_CableManagementStrategy;
            }
            set
            {
                this.m_CableManagementStrategy = value;
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
        
        public ushort [] ChassisTypes
        {
            get
            {
                return this.m_ChassisTypes;
            }
            set
            {
                this.m_ChassisTypes = value;
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
        
        public short CurrentRequiredOrProduced
        {
            get
            {
                return this.m_CurrentRequiredOrProduced;
            }
            set
            {
                this.m_CurrentRequiredOrProduced = value;
            }
        }
        
        public double Depth
        {
            get
            {
                return this.m_Depth;
            }
            set
            {
                this.m_Depth = value;
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
        
        public ushort HeatGeneration
        {
            get
            {
                return this.m_HeatGeneration;
            }
            set
            {
                this.m_HeatGeneration = value;
            }
        }
        
        public double Height
        {
            get
            {
                return this.m_Height;
            }
            set
            {
                this.m_Height = value;
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
        
        public bool LockPresent
        {
            get
            {
                return this.m_LockPresent;
            }
            set
            {
                this.m_LockPresent = value;
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
        
        public ushort NumberOfPowerCords
        {
            get
            {
                return this.m_NumberOfPowerCords;
            }
            set
            {
                this.m_NumberOfPowerCords = value;
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
        
        public ushort SecurityBreach
        {
            get
            {
                return this.m_SecurityBreach;
            }
            set
            {
                this.m_SecurityBreach = value;
            }
        }
        
        public ushort SecurityStatus
        {
            get
            {
                return this.m_SecurityStatus;
            }
            set
            {
                this.m_SecurityStatus = value;
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
        
        public string [] ServiceDescriptions
        {
            get
            {
                return this.m_ServiceDescriptions;
            }
            set
            {
                this.m_ServiceDescriptions = value;
            }
        }
        
        public ushort [] ServicePhilosophy
        {
            get
            {
                return this.m_ServicePhilosophy;
            }
            set
            {
                this.m_ServicePhilosophy = value;
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
        
        public string SMBIOSAssetTag
        {
            get
            {
                return this.m_SMBIOSAssetTag;
            }
            set
            {
                this.m_SMBIOSAssetTag = value;
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
        
        public string [] TypeDescriptions
        {
            get
            {
                return this.m_TypeDescriptions;
            }
            set
            {
                this.m_TypeDescriptions = value;
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
        
        public bool VisibleAlarm
        {
            get
            {
                return this.m_VisibleAlarm;
            }
            set
            {
                this.m_VisibleAlarm = value;
            }
        }
        
        public double Weight
        {
            get
            {
                return this.m_Weight;
            }
            set
            {
                this.m_Weight = value;
            }
        }
        
        public double Width
        {
            get
            {
                return this.m_Width;
            }
            set
            {
                this.m_Width = value;
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
        
        public Int32 IsCompatible(string ElementToCheck)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_SystemEnclosure");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("IsCompatible");
InParams["ElementToCheck"] = ElementToCheck;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "IsCompatible", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
    }
}
