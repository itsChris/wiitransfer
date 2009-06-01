using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using EasyWMI.Controllers;
namespace EasyWMI.Models.root.CIMV2
{
    
    
    public class Win32_Processor : WMIBase
    {
        
        private ushort m_AddressWidth;
        
        private ushort m_Architecture;
        
        private ushort m_Availability;
        
        private string m_Caption;
        
        private uint m_ConfigManagerErrorCode;
        
        private bool m_ConfigManagerUserConfig;
        
        private ushort m_CpuStatus;
        
        private string m_CreationClassName;
        
        private uint m_CurrentClockSpeed;
        
        private ushort m_CurrentVoltage;
        
        private ushort m_DataWidth;
        
        private string m_Description;
        
        private string m_DeviceID;
        
        private bool m_ErrorCleared;
        
        private string m_ErrorDescription;
        
        private uint m_ExtClock;
        
        private ushort m_Family;
        
        private string m_InstallDate;
        
        private uint m_L2CacheSize;
        
        private uint m_L2CacheSpeed;
        
        private uint m_L3CacheSize;
        
        private uint m_L3CacheSpeed;
        
        private uint m_LastErrorCode;
        
        private ushort m_Level;
        
        private ushort m_LoadPercentage;
        
        private string m_Manufacturer;
        
        private uint m_MaxClockSpeed;
        
        private string m_Name;
        
        private uint m_NumberOfCores;
        
        private uint m_NumberOfLogicalProcessors;
        
        private string m_OtherFamilyDescription;
        
        private string m_PNPDeviceID;
        
        private ushort [] m_PowerManagementCapabilities;
        
        private bool m_PowerManagementSupported;
        
        private string m_ProcessorId;
        
        private ushort m_ProcessorType;
        
        private ushort m_Revision;
        
        private string m_Role;
        
        private string m_SocketDesignation;
        
        private string m_Status;
        
        private ushort m_StatusInfo;
        
        private string m_Stepping;
        
        private string m_SystemCreationClassName;
        
        private string m_SystemName;
        
        private string m_UniqueId;
        
        private ushort m_UpgradeMethod;
        
        private string m_Version;
        
        private uint m_VoltageCaps;
        
        private string m_MyPath;
        
        public Win32_Processor()
        {
        }
        
        public ushort AddressWidth
        {
            get
            {
                return this.m_AddressWidth;
            }
            set
            {
                this.m_AddressWidth = value;
            }
        }
        
        public ushort Architecture
        {
            get
            {
                return this.m_Architecture;
            }
            set
            {
                this.m_Architecture = value;
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
        
        public uint ConfigManagerErrorCode
        {
            get
            {
                return this.m_ConfigManagerErrorCode;
            }
            set
            {
                this.m_ConfigManagerErrorCode = value;
            }
        }
        
        public bool ConfigManagerUserConfig
        {
            get
            {
                return this.m_ConfigManagerUserConfig;
            }
            set
            {
                this.m_ConfigManagerUserConfig = value;
            }
        }
        
        public ushort CpuStatus
        {
            get
            {
                return this.m_CpuStatus;
            }
            set
            {
                this.m_CpuStatus = value;
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
        
        public uint CurrentClockSpeed
        {
            get
            {
                return this.m_CurrentClockSpeed;
            }
            set
            {
                this.m_CurrentClockSpeed = value;
            }
        }
        
        public ushort CurrentVoltage
        {
            get
            {
                return this.m_CurrentVoltage;
            }
            set
            {
                this.m_CurrentVoltage = value;
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
        
        public string DeviceID
        {
            get
            {
                return this.m_DeviceID;
            }
            set
            {
                this.m_DeviceID = value;
            }
        }
        
        public bool ErrorCleared
        {
            get
            {
                return this.m_ErrorCleared;
            }
            set
            {
                this.m_ErrorCleared = value;
            }
        }
        
        public string ErrorDescription
        {
            get
            {
                return this.m_ErrorDescription;
            }
            set
            {
                this.m_ErrorDescription = value;
            }
        }
        
        public uint ExtClock
        {
            get
            {
                return this.m_ExtClock;
            }
            set
            {
                this.m_ExtClock = value;
            }
        }
        
        public ushort Family
        {
            get
            {
                return this.m_Family;
            }
            set
            {
                this.m_Family = value;
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
        
        public uint L2CacheSize
        {
            get
            {
                return this.m_L2CacheSize;
            }
            set
            {
                this.m_L2CacheSize = value;
            }
        }
        
        public uint L2CacheSpeed
        {
            get
            {
                return this.m_L2CacheSpeed;
            }
            set
            {
                this.m_L2CacheSpeed = value;
            }
        }
        
        public uint L3CacheSize
        {
            get
            {
                return this.m_L3CacheSize;
            }
            set
            {
                this.m_L3CacheSize = value;
            }
        }
        
        public uint L3CacheSpeed
        {
            get
            {
                return this.m_L3CacheSpeed;
            }
            set
            {
                this.m_L3CacheSpeed = value;
            }
        }
        
        public uint LastErrorCode
        {
            get
            {
                return this.m_LastErrorCode;
            }
            set
            {
                this.m_LastErrorCode = value;
            }
        }
        
        public ushort Level
        {
            get
            {
                return this.m_Level;
            }
            set
            {
                this.m_Level = value;
            }
        }
        
        public ushort LoadPercentage
        {
            get
            {
                return this.m_LoadPercentage;
            }
            set
            {
                this.m_LoadPercentage = value;
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
        
        public uint MaxClockSpeed
        {
            get
            {
                return this.m_MaxClockSpeed;
            }
            set
            {
                this.m_MaxClockSpeed = value;
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
        
        public uint NumberOfCores
        {
            get
            {
                return this.m_NumberOfCores;
            }
            set
            {
                this.m_NumberOfCores = value;
            }
        }
        
        public uint NumberOfLogicalProcessors
        {
            get
            {
                return this.m_NumberOfLogicalProcessors;
            }
            set
            {
                this.m_NumberOfLogicalProcessors = value;
            }
        }
        
        public string OtherFamilyDescription
        {
            get
            {
                return this.m_OtherFamilyDescription;
            }
            set
            {
                this.m_OtherFamilyDescription = value;
            }
        }
        
        public string PNPDeviceID
        {
            get
            {
                return this.m_PNPDeviceID;
            }
            set
            {
                this.m_PNPDeviceID = value;
            }
        }
        
        public ushort [] PowerManagementCapabilities
        {
            get
            {
                return this.m_PowerManagementCapabilities;
            }
            set
            {
                this.m_PowerManagementCapabilities = value;
            }
        }
        
        public bool PowerManagementSupported
        {
            get
            {
                return this.m_PowerManagementSupported;
            }
            set
            {
                this.m_PowerManagementSupported = value;
            }
        }
        
        public string ProcessorId
        {
            get
            {
                return this.m_ProcessorId;
            }
            set
            {
                this.m_ProcessorId = value;
            }
        }
        
        public ushort ProcessorType
        {
            get
            {
                return this.m_ProcessorType;
            }
            set
            {
                this.m_ProcessorType = value;
            }
        }
        
        public ushort Revision
        {
            get
            {
                return this.m_Revision;
            }
            set
            {
                this.m_Revision = value;
            }
        }
        
        public string Role
        {
            get
            {
                return this.m_Role;
            }
            set
            {
                this.m_Role = value;
            }
        }
        
        public string SocketDesignation
        {
            get
            {
                return this.m_SocketDesignation;
            }
            set
            {
                this.m_SocketDesignation = value;
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
        
        public ushort StatusInfo
        {
            get
            {
                return this.m_StatusInfo;
            }
            set
            {
                this.m_StatusInfo = value;
            }
        }
        
        public string Stepping
        {
            get
            {
                return this.m_Stepping;
            }
            set
            {
                this.m_Stepping = value;
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
        
        public string UniqueId
        {
            get
            {
                return this.m_UniqueId;
            }
            set
            {
                this.m_UniqueId = value;
            }
        }
        
        public ushort UpgradeMethod
        {
            get
            {
                return this.m_UpgradeMethod;
            }
            set
            {
                this.m_UpgradeMethod = value;
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
        
        public uint VoltageCaps
        {
            get
            {
                return this.m_VoltageCaps;
            }
            set
            {
                this.m_VoltageCaps = value;
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
        
        public Int32 SetPowerState(ushort PowerState, string Time)
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementClass WMIClass = new ManagementClass("Win32_Processor");
            ManagementBaseObject InParams = WMIClass.GetMethodParameters("SetPowerState");
            InParams["PowerState"] = PowerState;
            InParams["Time"] = Time;

            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "SetPowerState", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
        
        public Int32 Reset()
        {
            System.Management.InvokeMethodOptions Options = new System.Management.InvokeMethodOptions();
            Options.Timeout = new TimeSpan(0, 0, 10);
            ManagementBaseObject InParams = null;
            ManagementBaseObject OutParams = null;
            OutParams = InvokeMethod(m_MyPath, "Reset", InParams, Options);

            Int32 numericResult = Convert.ToInt32(OutParams["ReturnValue"]);
            return numericResult;
        }
    }
}
